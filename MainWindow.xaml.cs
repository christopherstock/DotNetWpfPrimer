using System;
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
        *    Being invoked when the "Request a joke" button is clicked.
        ***************************************************************************************************************/
        private void MainButton_OnClick( object sender, RoutedEventArgs e )
        {
            Console.Out.WriteLine( "MainWindow.MainButton_OnClick being invoked" );

            Api.RequestRandomJoke( OnJokeResponse );
        }

        /***************************************************************************************************************
        *    Being invoked when the joke response arrives.
        *
        *    @param joke The received joke or error message as a string.
        ***************************************************************************************************************/
        private void OnJokeResponse( string joke )
        {
            AppendTextField( joke );
        }

        /***************************************************************************************************************
        *    Appends the specified message to the TextBlock.
        *
        *    @param msg The message to append.
        ***************************************************************************************************************/
        private void AppendTextField( string msg )
        {
            MainTextBlock.Text += msg;
            MainTextBlock.Text += "\n";

            MainScroller.ScrollToEnd();
        }
    }
}
