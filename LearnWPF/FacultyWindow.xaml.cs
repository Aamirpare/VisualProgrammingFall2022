using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearnWPF
{
    public partial class FacultyWindow : Window
    {
        public FacultyWindow()
        {
            InitializeComponent();
            Title = "Faculty Window";
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            var sw = new StudentWindow();
            this.Close();
            sw.Show();
        }
    }
}
