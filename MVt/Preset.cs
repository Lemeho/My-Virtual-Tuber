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

        public string dirpath;
        public bool reset;

        public class DefSet
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
        }

        private void Preset_Load(object sender, EventArgs e)
        {
            string fileName = "Settings.json";
            string jsonDeserial = File.ReadAllText(fileName);

            if (!File.Exists("Settings.json"))
            {
                var defsettings = new DefSet
                {
                    AvatarsPath = "",
                    Language = "Русский"
                };
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping 
                };
                string jsonSerial = JsonSerializer.Serialize<DefSet>(defsettings, options);
                File.WriteAllText(fileName, jsonSerial);
            }
            DefSet defSet = JsonSerializer.Deserialize<DefSet>(jsonDeserial);

            dirpath = defSet.AvatarsPath;
            
            List<string> dirs = new List<string>(Directory.GetDirectories(dirpath));
            foreach (string dir in dirs) 
            {
                int eindex = dir.LastIndexOf("\\");
                string dirname = dir.Substring(eindex+1);
                AvatarsBox.Items.Add(dirname);
            }
            if (AvatarsBox.Text == "")
            {
                return;
            }
            else 
            {
                AvatarsBox.Text = AvatarsBox.Items[0].ToString();
            }
        }
        private void NewAvatarButton_Click(object sender, EventArgs e)
        {
            NewAvatar newav = new NewAvatar();
            newav.UpdateThis += (reset) =>
            {
                if (reset)
                {
                    AvatarsBox.Items.Clear();
                    List<string> dirs = new List<string>(Directory.GetDirectories(dirpath));
                    foreach (string dir in dirs)
                    {
                        int eindex = dir.LastIndexOf("\\");
                        string dirname = dir.Substring(eindex + 1);
                        AvatarsBox.Items.Add(dirname);
                    }
                    AvatarsBox.Text = AvatarsBox.Items[0].ToString();
                    reset = false;
                }
                else 
                {
                    return;
                }
            };
            newav.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            ColorPrewiev.BackColor = colorDialog1.Color;
        }
    }
}
