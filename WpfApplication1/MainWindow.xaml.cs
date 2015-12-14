using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
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

        private void button1_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            switch (e.ClickCount)
            {
                case 1:
                    label1.Content = "LeftClick";
                    break;
                case 2:
                    label1.Content = "DoubleClick";
                    break;
                default:
                    label1.Content = "TestLabel";
                    break;
            }
        }

        private void button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            label1.Content = "RightClick";
        }
    }
}
