using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            Text = "Price";
            BackColor = Color.BlueViolet;
            Dock = DockStyle.Bottom;
            //AutoSize = true;
            Height += 10;
            ForeColor = Color.White;
        }
    }
}
