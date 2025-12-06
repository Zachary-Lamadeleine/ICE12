using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICE12A
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ConfirmExit(e);
        }

        private void Button_New_Click(object sender, EventArgs e)
        {
            Program.Forms[(int)FormType.Selection].Show();
            Hide();
        }

        /// <summary>
        /// This event handler loads a character from a file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Load Character";
            dialog.Filter =
                "Text Character Files (*.chr)|*.chr|" +
                "Binary Character Files (*.dat)|*.dat|" +
                "JSON Character Files (*.json)|*.json|" +
                "All Files (*.*)|*.*";
            dialog.InitialDirectory = Program.DownloadsFolder;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                string extension = Path.GetExtension(fileName).ToLower();
                bool loaded = false;

                switch (extension)
                {
                    case ".chr":
                        loaded = Program.LoadCharacter(fileName);
                        break;
                    case ".dat":
                        loaded = Program.LoadCharacterBinary(fileName);
                        break;
                    case ".json":
                        loaded = Program.LoadCharacterJSON(fileName);
                        break;
                    default:
                        Program.ShowToast("Unknown file type. Please select .chr, .dat, or .json.",
                            ToastType.Warning);
                        return;
                }

                Program.HasLoadedCharacter = loaded;
                if (loaded)
                {
                    Program.Forms[(int)FormType.Selection].Show();
                    Hide();
                }
            }

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
