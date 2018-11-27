using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Debug(object sender, RoutedEventArgs e)
        {
    
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Help1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/helpinmystudio");
        }

        private void SaveAll(object sender, RoutedEventArgs e)
        {

        }

        private void ExitEvent(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
