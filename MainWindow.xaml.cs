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
        private void MainButton_OnClick( object sender, RoutedEventArgs e )
        {
            Console.Out.WriteLine( "MainWindow.MainButton_OnClick being invoked" );

            this.MainTextBlock.Text += ( "MainButton clicked" + "\n" );
            this.MainScroller.ScrollToEnd();
        }
    }
}
