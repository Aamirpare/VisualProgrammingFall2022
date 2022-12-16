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

namespace SalesManagerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.BackColor= SystemColors.Info;
            //Button button2 = new Button();
            //button2.BackColor = Color.Pink;
            //button2.Text = "Submit";
            //button2.Width = 100;
            //button2.Height= 100;
            //Label label = new Label();
            //label.Text = "My Label";
            //button2.Controls.Add(label);

            //this.Controls.Add(button2);
            //var fileItem = new MenuItem("File");
            //var editItem = new MenuItem("Edit");
            //var menues = new MenuItem[] {fileItem, editItem};
            Menu = new MainMenu(new MenuItem[] 
            {
                new MenuItem("&File", new MenuItem[]
                { 
                    new MenuItem("&Open", OpenFile_Click),
                    new MenuItem("&Save", SaveFile_Click),
                    new MenuItem("E&xit"),
                }),
                new MenuItem("Edit")
            });
            if (Menu == null)
                MessageBox.Show("Menu is null...");


            Menu = null;
            InitializeComponent();

           
        
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.ShowDialog();
            
            System.IO.File.WriteAllText(sfd.FileName, AddressTextBox.Text); 
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Text Files";
            ofd.Filter = "Text File *.txt | *.txt | All Files *.* | *.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileName = ofd.FileName;
                var content = System.IO.File.ReadAllText(fileName);
                textBox1.Text = content;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
