using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MVt
{
    public partial class NewState : Form
    {
        public event Action<bool> UpdateThis;
        string boofer = "";
        public string dirpath;
        public string avname;

        public class DefSet
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
        }

        public NewState()
        {
            InitializeComponent();
        }
        private void NewState_Load(object sender, EventArgs e)
        {
            NameBox.Text = "Весёло-Грустный";
            NameBox.ForeColor = Color.Gray;

            string fileName = "Settings.json";
            string jsonString = File.ReadAllText(fileName);
            DefSet defSet = JsonSerializer.Deserialize<DefSet>(jsonString);

            dirpath = defSet.AvatarsPath;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            string newstate = $"{dirpath}\\{avname}\\{name}";
            int n = 1;
            bool reset = true;
            while (Directory.Exists(newstate))
            {
                n++;
                newstate = $"{dirpath}\\{avname}\\{name} ({n})";
            }

            Directory.CreateDirectory(newstate);
            UpdateThis?.Invoke(reset);
            this.Close();
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.Text = boofer;
            NameBox.ForeColor = Color.Black;
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.Text = "Весёло-Грустный";
                NameBox.ForeColor = Color.Gray;
                boofer = "";
            }
            else
            {
                boofer = NameBox.Text;
            }
        }
    }
}
