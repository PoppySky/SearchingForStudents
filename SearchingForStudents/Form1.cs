using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingForStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkImageCode()
        {
            string[] codes =
            {
                "mxyxw",
                "b5nmm",
                "74853",
                "cg5dd",
                "x3deb",
                "befbd",
                "c7gb3"
            };
        }

        private void linkChangePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image[] images =
            {
                SearchingForStudents.Properties.Resources._1,
                SearchingForStudents.Properties.Resources._2,
                SearchingForStudents.Properties.Resources._3,
                SearchingForStudents.Properties.Resources._4,
                SearchingForStudents.Properties.Resources._5,
                SearchingForStudents.Properties.Resources._6,
                SearchingForStudents.Properties.Resources._7
            };
            var rand = new Random();
            //pictureBox_CodePic.Image = images[rand.Next(images.Length)];
            
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
