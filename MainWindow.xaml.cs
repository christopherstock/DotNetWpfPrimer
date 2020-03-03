using System;
using System.Net.Http;
using System.Windows;

namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    Represents the application's main window.
    *******************************************************************************************************************/
    public partial class MainWindow : Window
    {
        /***************************************************************************************************************
        *    The default constructor initializes this and all sub-components.
        ***************************************************************************************************************/
        public MainWindow()
        {
            Console.Out.WriteLine( "MainWindow.MainWindow() being invoked" );

            InitializeComponent();
        }

        /***************************************************************************************************************
        *    Being invoked when the system has initialized all components after
        *    {@link #InitializeComponent} has been invoked.
        ***************************************************************************************************************/
        private void Window_Loaded( Object sender, RoutedEventArgs args )
        {
            Console.Out.WriteLine( "MainWindow.Window_Loaded being invoked" );
        }

        /***************************************************************************************************************
        *    Being invoked when the "Request a joke" button is clicked.
        ***************************************************************************************************************/
        private async void MainButton_OnClick( object sender, RoutedEventArgs e )
        {
            Console.Out.WriteLine( "MainWindow.MainButton_OnClick being invoked" );

            // load joke via API
            string URL_ICND = "http://api.icndb.com/jokes/random";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync( URL_ICND );
            HttpContent content = response.Content;
            {
                string result = await content.ReadAsStringAsync();

                AppendTextField( result );
            }
        }

        /***************************************************************************************************************
        *    Appends the specified message to the TextBlock.
        *
        *    @param msg The message to append.
        ***************************************************************************************************************/
        private void AppendTextField( string msg )
        {
            this.MainTextBlock.Text += ( msg + "\n" );
            this.MainScroller.ScrollToEnd();
        }
    }
}
