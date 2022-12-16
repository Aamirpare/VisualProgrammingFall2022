using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFirstDemo
{
    public partial class Form1 : Form
    {
        public Button Button1 { get; set; }
        public Form1()
        {
            InitializeComponent();

            //start from here
            Button1 = new Button();
            Button1.Text = "Submit";
            Button1.Width = 200;
            Button1.Height = 100;
            Button1.Location = new Point(200, 100);
            Button1.TabIndex = 0;

            Controls.Add(Button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feedback form = new Feedback();
            form.ShowDialog();
        }
    }
}
