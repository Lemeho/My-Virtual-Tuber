using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MVt.Preset;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MVt
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        public class DefaultSettings
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
            public DefaultSettings(string avatarsPath, string language)
            {
                AvatarsPath = avatarsPath;
                Language = language;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("Settings.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.DeserializeAsync<DefaultSettings>(fs);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelppButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Lemeho/My-Virtual-Tuber/blob/master/README.md");
        }

        private void AuthorButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создал и дорабатывает эту фигню Boowomp","Автор", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                InputString.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
