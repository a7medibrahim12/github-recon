using System;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Policy;

namespace bughuntergithu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void words_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedItemText = words.SelectedItem.ToString();

            const string q = "\"";
            string githubUrl = "https://github.com/search";
            string searchQuery = domain.Text + " " + q + $"{selectedItemText}" + q;
            string fullUrl = $"{githubUrl}?q={searchQuery}&type=code";
            Process.Start(new ProcessStartInfo { FileName = fullUrl, UseShellExecute = true });


        }

        private void extension_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemText = extension.SelectedItem.ToString();

            const string q = "\"";
            string githubUrl = "https://github.com/search";
            string searchQuery = domain.Text + " " + q + $"\"{selectedItemText}\"" + q;
            string fullUrl = $"{githubUrl}?q={searchQuery}&type=code";
            Process.Start(new ProcessStartInfo { FileName = fullUrl, UseShellExecute = true });
        }

        private void filename_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItemText = filename.SelectedItem.ToString();

            const string q = "\"";
            string githubUrl = "https://github.com/search";
            string searchQuery = domain.Text + " " + q + $"\"{selectedItemText}\"" + q;
            string fullUrl = $"{githubUrl}?q={searchQuery}&type=code";
            Process.Start(new ProcessStartInfo { FileName = fullUrl, UseShellExecute = true });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://www.linkedin.com/in/a0ibx00?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app";
            Process.Start(new ProcessStartInfo { FileName = githubUrl, UseShellExecute = true });
        }

    }
}

