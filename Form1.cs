using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Songs speichern (Pfad für Songs)
        String[] paths, files;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   // App schliessen
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // Songs auswählen

            ofd.Multiselect = true; // Mehrere Songs auswählen

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;  // Name vom Song speichern
                paths = ofd.FileNames;      // Ort vom Song speichern

                for (int i = 0; i < files.Length; i++)  // Titel in "ListBoxSongs" anzeigen
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex]; //Musik spielen lassen
        }

        private void Developer_Click(object sender, EventArgs e)
        {

        }
    }
}
