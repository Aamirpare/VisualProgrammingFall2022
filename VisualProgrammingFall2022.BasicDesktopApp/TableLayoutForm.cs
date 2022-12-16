using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingFall2022.BasicDesktopApp
{
    public partial class TableLayoutForm : Form
    {
        public TableLayoutForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var thread = new Thread(Task1);
            thread.Start();
        }


        public void Task1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
            }
            Thread.Sleep(200);
        }
    }
}
