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
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Windows.Threading;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Theme = 1;
        public MainWindow()
        {
            InitializeComponent();
           
        }

      

        private void Debug(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab.Content="ffgre";
        
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

        private void NewProject(object sender, RoutedEventArgs e)                                                                                    
        {
            AddNewItem Add = new AddNewItem(ref Theme);
            Add.ShowDialog();

        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            TabItem tabItem = new TabItem();
            
           
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {

                RichTextBox myRichTextBox = new RichTextBox();
                myRichTextBox.Document.Blocks.Add(new Paragraph(new Run(File.ReadAllText(openFile.FileName))));
                tabItem.Header = openFile.SafeFileName;
                myRichTextBox.Document.LineHeight = 1;
                tabItem.Content = myRichTextBox;
                TabItemss.Items.Add(tabItem);
            }
         

           

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Change item

        }

        private void MenuItem_Loaded(object sender, RoutedEventArgs e)
        {
            var timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
           if(Theme==1)
            {
                //Namee.Background = Brushes.Black;
           // Window.FontStyleProperty;
            }
        }
    }
}
