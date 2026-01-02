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
using static System.Collections.Specialized.BitVector32;
using System.IO;

namespace MVt
{
    public partial class NewAvatar : Form
    {
        public event Action<bool> UpdateThis;
        string boofer = "";
        public string dirpath;

        public NewAvatar()
        {
            InitializeComponent();
        }
        public class DefSet
        {
            public string AvatarsPath { get; set; }
            public string Language { get; set; }
        }

        private void NewAvatar_Load(object sender, EventArgs e)
        {
            NameBox.Text = "Новый Чел";
            NameBox.ForeColor = Color.Gray;

            string fileName = "Settings.json";
            string jsonString = File.ReadAllText(fileName);
            DefSet defSet = JsonSerializer.Deserialize<DefSet>(jsonString);

            dirpath = defSet.AvatarsPath;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string name = NameBox.Text;
            bool reset = true;
            Directory.CreateDirectory($"{dirpath}\\{name}");
            UpdateThis?.Invoke(reset);
            this.Close();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

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
                NameBox.Text = "Новый Чел";
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
