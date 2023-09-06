using Newtonsoft.Json;
using StockAnalyzer.Core;
using StockAnalyzer.Core.Domain;
using StockAnalyzer.Core.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace StockAnalyzer.Windows;

public partial class MainWindow : Window
{
    private static string API_URL = "https://ps-async.fekberg.com/api/stocks";
    private Stopwatch stopwatch = new Stopwatch();

    public MainWindow()
    {
        InitializeComponent();
    }

    CancellationTokenSource? cancellationTokenSource;

    private async void Search_Click(object sender, RoutedEventArgs e)
    {
        if (cancellationTokenSource is not null)
        {
            cancellationTokenSource.Cancel();
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;

            Search.Content = "Search";
            return;
        }

        try
        {
            cancellationTokenSource = new();

            cancellationTokenSource.Token.Register(() =>
            {
                Notes.Text = "Cancellation Requested";
            });

            Search.Content = "Cancel"; //button


            BeforeLoadingStockData();

            var identifiers = StockIdentifier.Text
                                             .Split(',', ' ');

            var service = new MockStockService();

            var loadingTasks = new List<Task<IEnumerable<StockPrice>>>();

            foreach(var identifier in identifiers)
            {
                var loadTask = service.GetStockPricesFor(identifier,
                    cancellationTokenSource.Token);

                loadingTasks.Add(loadTask);
            }

            var timeout = Task.Delay(120000);

            var allStocksLoadingTask = Task.WhenAll(loadingTasks);

            var completedTask = await Task.WhenAny(timeout, 
                allStocksLoadingTask);

            if(completedTask == timeout)
            {
                cancellationTokenSource.Cancel();
                throw new OperationCanceledException("Timeout!");
            }

            Stocks.ItemsSource = allStocksLoadingTask
                .Result
                .SelectMany(x => x);
        }
        catch (Exception ex)
        {
            Notes.Text = ex.Message;
        }
        finally
        {
            AfterLoadingStockData();
            cancellationTokenSource?.Dispose();
            cancellationTokenSource = null;

            Search.Content = "Search";
        }
        //var getStocksTask = GetStocks();

        //await getStocksTask;
    }

    private static Task<List<string>> SearchForStocks(
        CancellationToken cancellationToken
        )
    {
        return Task.Run(async () =>
        {
            using var stream = new StreamReader(File.OpenRead("StockPrices_Small.csv"));

            var lines = new List<string>();

            while (await stream.ReadLineAsync() is string line)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    break;
                }
                lines.Add(line);
            }
            return lines;
        }, cancellationToken);
    }

    //Task expects no return
    //Task<T> expects a return


    private async Task GetStocks()
    {
        try
        {
            var store = new DataStore();

            var responseTask = store.GetStockPrices(StockIdentifier.Text);

            Stocks.ItemsSource = await responseTask;
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private void BeforeLoadingStockData()
    {
        stopwatch.Restart();
        StockProgress.Visibility = Visibility.Visible;
        StockProgress.IsIndeterminate = true;
    }

    private void AfterLoadingStockData()
    {
        StocksStatus.Text = $"Loaded stocks for {StockIdentifier.Text} in {stopwatch.ElapsedMilliseconds}ms";
        StockProgress.Visibility = Visibility.Hidden;
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        Process.Start(new ProcessStartInfo { FileName = e.Uri.AbsoluteUri, UseShellExecute = true });

        e.Handled = true;
    }

    private void Close_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
}