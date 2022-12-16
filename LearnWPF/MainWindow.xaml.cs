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

namespace LearnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var ellipse = new Ellipse()
            {
                Width = 200,
                Height = 200,
                Fill = Brushes.Red,
                Margin = new Thickness(644, 0, 0, 0)
            };

            ParentGrid.Children.Add(ellipse);
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            var fw = new FacultyWindow();
            this.Close();
            fw.Show();
        }
    }
}
