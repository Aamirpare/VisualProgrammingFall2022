using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditorApp.Abstraction;

namespace TextEditorApp.Implementation
{
    public class AppMainMenu : IAppMainMenu
    {
        public MainMenu CreateMainMenu()
        {
            var fileMenuItems = new MenuItem[]
            {
                new MenuItem("&Open"),
                new MenuItem("&Save"),
                new MenuItem("&Exit")
            };

            var fileMenu = new MenuItem[]
            {
                new MenuItem("&File", fileMenuItems),
                new MenuItem("&Help"),
            };

            return new MainMenu(fileMenu);
        }
    }
}
