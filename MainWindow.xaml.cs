using System;
using System.Windows;

namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    Represents the application's main window.
    *******************************************************************************************************************/
    public partial class MainWindow : Window
    {
        /*******************************************************************************************************************
        *    The default constructor initializes this and all sub-components.
        ************************************************************************************MainButton_OnClick*************/
        public MainWindow()
        {
            Console.Out.WriteLine( "MainWindow() being invoked" );

            InitializeComponent();
        }

        private void Window_Loaded( Object sender, RoutedEventArgs args )
        {
        }

        private void MainButton_OnClick( object sender, RoutedEventArgs e )
        {
            Console.Out.WriteLine( "MainButton clicked" );
        }
    }
}
