using System;
using System.ComponentModel;
using System.Windows.Forms;
using TextEditorApp.Database;

namespace TextEditorApp
{
    public partial class FrmPureEditor : Form
    {
        public string ApplicationName => "Pure Text Editor";
        public string ActiveFileName { get; set; } = "Text1.txt";

        public FrmPureEditor()
        {
            //var mainMenu = new AppMainMenu();
            InitializeComponent();

            CreateMainMenu();

            SetTitle(ActiveFileName);

            //Rich Text Editor
            richTextBoxEditor.Dock = DockStyle.Fill;
        }

        public void SetTitle(string fileName)
        {
            Text = $"{ApplicationName} - {fileName}";
        }
        
        protected override void OnClosing(CancelEventArgs e)
        {
            if (MessageBox.Show("Sure to close this application?", "Application Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
            e.Cancel = true;
        }

        void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure to close this application?", "Application Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files | *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IsFileOpened = true;
                ActiveFileName = ofd.FileName;
                richTextBoxEditor.Text = System.IO.File.ReadAllText(ActiveFileName);
                SetTitle(ofd.SafeFileName);
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text Files | *.txt";
            if (ActiveFileName.CompareTo("Text1.txt") == 0)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var content = richTextBoxEditor.Text;

                    System.IO.File.WriteAllText(sfd.FileName, content);

                    SetTitle(System.IO.Path.GetFileName(sfd.FileName));
                }
                return;
            }

            System.IO.File.WriteAllText(ActiveFileName, richTextBoxEditor.Text);
        }

        void OpenColor_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxEditor.ForeColor = cd.Color;
            }
        }

        public void OpenFont_Click(object sender, EventArgs e)
        {
            var ofd = new FontDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBoxEditor.Font = ofd.Font;
            }
        }

        private void CreateMainMenu()
        {
            var fileMenuItems = new MenuItem[]
            {
                new MenuItem("&Open", OpenFile_Click),
                new MenuItem("&Save", SaveFile_Click),
                new MenuItem("&Exit", Exit_Click)
            };

            var fileMenu = new MenuItem[]
            {
                new MenuItem("&File", fileMenuItems),
                new MenuItem("&Edit", new MenuItem[]
                {
                    new MenuItem("Font", OpenFont_Click),
                    new MenuItem("Color",OpenColor_Click)
                }),
            };

            this.Menu = new MainMenu(fileMenu);
        }
    }
}
