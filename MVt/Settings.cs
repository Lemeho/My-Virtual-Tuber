using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVt
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelppButton_Click(object sender, EventArgs e)
        {
            Process.Start("www.cyberforum.ru");
        }
    }
}
