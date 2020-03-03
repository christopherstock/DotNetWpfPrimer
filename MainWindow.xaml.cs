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
            Console.Out.WriteLine( "MainWindow() being invoked" );

            InitializeComponent();
        }

        /***************************************************************************************************************
        *    Being invoked when the system has initialized all components after
        *    {@link #InitializeComponent} has been invoked.
        ***************************************************************************************************************/
        private void Window_Loaded( Object sender, RoutedEventArgs args )
        {
        }

        /***************************************************************************************************************
        *    Being invoked when the "Request a joke" button is clicked.
        ***************************************************************************************************************/
        private void MainButton_OnClick( object sender, RoutedEventArgs e )
        {
            Console.Out.WriteLine( "MainButton clicked" );

            this.MainTextBlock.Text += ( "MainButton clicked" + "\n" );
            this.MainScroller.ScrollToEnd();
        }
    }
}
