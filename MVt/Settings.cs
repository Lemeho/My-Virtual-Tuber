using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public event Action<bool> UpdateThis;

        public string dirpath;
        public string lang;
        public int counter = 0;
        public bool reset;
        public class DefSet
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            string fileName = "Settings.json";
            string jsonString = File.ReadAllText(fileName);
            DefSet defSet = JsonSerializer.Deserialize<DefSet>(jsonString);

            dirpath = defSet.AvatarsPath;
            lang = defSet.Language;

            InputString.Text = dirpath;
            LangBox.Text = lang;
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
            reset = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                InputString.Text = folderBrowserDialog1.SelectedPath;
                
                var dirsettings = new DefSet()
                {
                    AvatarsPath = folderBrowserDialog1.SelectedPath,
                    Language = lang,
                };
                string fileName = "Settings.json";
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                string jsonString = JsonSerializer.Serialize<DefSet>(dirsettings, options);
                File.WriteAllText(fileName, jsonString);
                
            }
            UpdateThis?.Invoke(reset);
        }

        private void LangBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var langsettings = new DefSet()
            {
                AvatarsPath = dirpath,
                Language = LangBox.Text,
            };
            string fileName = "Settings.json";
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            string jsonString = JsonSerializer.Serialize<DefSet>(langsettings, options);
            File.WriteAllText(fileName, jsonString);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
