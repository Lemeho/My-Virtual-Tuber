using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.IO.Pipelines;

namespace MVt
{
    

    public partial class Preset : Form
    {
        public Preset()
        {
            InitializeComponent();
        }
        public class DefSet
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
        }

        private void Preset_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Settings.json"))
            {
                var defsettings = new DefSet
                {
                    AvatarsPath = "",
                    Language = "Русский"
                };
                string fileName = "Settings.json";
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping 
                };
                string jsonString = JsonSerializer.Serialize<DefSet>(defsettings, options);
                File.WriteAllText(fileName, jsonString);
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            ColorPrewiev.BackColor = colorDialog1.Color;
        }
    }
}
