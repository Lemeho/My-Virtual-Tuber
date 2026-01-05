using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            string jsonDeserial = File.ReadAllText(fileName);
            DefSet defSet = JsonSerializer.Deserialize<DefSet>(jsonDeserial);
            dirpath = defSet.AvatarsPath;

            if (dirpath == "")
            {
                return;
            }
            else
            {
                if (Directory.GetDirectories(dirpath).Length > 0)
                {
                    List<string> dirs = new List<string>(Directory.GetDirectories(dirpath));
                    foreach (string dir in dirs)
                    {
                        int eindex = dir.LastIndexOf("\\");
                        string dirname = dir.Substring(eindex + 1);
                        AvatarsBox.Items.Add(dirname);
                    }
                    if (AvatarsBox.Text == null)
                    {
                        return;
                    }
                    if (AvatarsBox.Text != null)
                    {
                        AvatarsBox.Text = AvatarsBox.Items[0].ToString();
                    }
                }
                else { return; }
            }
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

        private void OpenDirButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(dirpath))
            {
                Process.Start(dirpath);
            }
            else
            {
                MessageBox.Show("Вы не выбрали папку в настройках\n\nYou didn't shoose directory in the settings","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AvatarsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StateList.Items.Clear();
            List<string> dirs = new List<string>(Directory.GetDirectories($"{dirpath}\\{AvatarsBox.Text}"));
            foreach (string dir in dirs)
            {
                int eindex = dir.LastIndexOf("\\");
                string dirname = dir.Substring(eindex + 1);
                StateList.Items.Add(dirname);
            }
            if (StateList.Text == "")
            {
                return;
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

        private void DeleteAvatarButton_Click(object sender, EventArgs e)
        {
            if (AvatarsBox.Text != "")
            {
                var comf = MessageBox.Show($"Вы уверены что хотите удалить {AvatarsBox.Text}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (comf == DialogResult.Yes)
                {
                    Directory.Delete($"{dirpath}\\{AvatarsBox.Text}", true);
                    AvatarsBox.Items.Remove(AvatarsBox.SelectedItem);
                    if (AvatarsBox.Items.Count > 0)
                    {
                        AvatarsBox.Text = AvatarsBox.Items[0].ToString();
                    }
                    else
                    {
                        AvatarsBox.Text = "";
                    }
                    StateList.Items.Clear();
                }
                else { return; }
            }
            else
            {
                MessageBox.Show("Нечего удалять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewStateButton_Click(object sender, EventArgs e)
        {
            NewState newst = new NewState();
            newst.avname = this.AvatarsBox.Text;
            newst.UpdateThis += (reset) =>
            {
                if (reset)
                {
                    StateList.Items.Clear();
                    List<string> dirs = new List<string>(Directory.GetDirectories($"{dirpath}\\{AvatarsBox.Text}"));
                    foreach (string dir in dirs)
                    {
                        int eindex = dir.LastIndexOf("\\");
                        string dirname = dir.Substring(eindex + 1);
                        StateList.Items.Add(dirname);
                    }
                    if (StateList.Text == "")
                    {
                        return;
                    }
                    reset = false;
                }
                else
                {
                    return;
                }
            };
            if (AvatarsBox.Text != "")
            {
                newst.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы не выбрали аватар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteStateButton_Click(object sender, EventArgs e)
        {
            if (StateList.SelectedItem != null)
            {
                if (AvatarsBox.Text != "")
                {
                    var comf = MessageBox.Show($"Вы уверены что хотите удалить {StateList.SelectedItem}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (comf == DialogResult.Yes)
                    {
                        Directory.Delete($"{dirpath}\\{AvatarsBox.Text}\\{StateList.SelectedItem}", true);
                        StateList.Items.Clear();
                        List<string> dirs = new List<string>(Directory.GetDirectories($"{dirpath}\\{AvatarsBox.Text}"));
                        foreach (string dir in dirs)
                        {
                            int eindex = dir.LastIndexOf("\\");
                            string dirname = dir.Substring(eindex + 1);
                            StateList.Items.Add(dirname);
                        }
                        if (StateList.Text == "")
                        {
                            return;
                        }
                    }
                    else { return; }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали аватар", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            { 
                MessageBox.Show("Вы не выбрали что удалять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

        private void StateDirButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($"{dirpath}\\{AvatarsBox.Text}"))
            {
                Process.Start($"{dirpath}\\{AvatarsBox.Text}");
            }
            else
            {
                MessageBox.Show("Аватара не существует\n\nAvatar doesn't exist", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
