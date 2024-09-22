using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("www.google.com");
            browser.Load("www.google.com");
            panel1.Controls.Add(browser);
            guna2TextBox1.Text = browser.Address;
           

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }
         
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text ="";
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)

        {
            guna2TextBox1.Text = browser.Address;

            if (e.KeyCode == Keys.Enter && guna2TextBox1.Text.Trim().Length>0)
            { if (guna2TextBox1.Text.Contains("."))
                {
                    browser.Load(guna2TextBox1.Text);
                        }
                else {
                    browser.Load("https://www.google.com/search?q=" + guna2TextBox1.Text);
                }
                    
                        }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            browser.Back();
            guna2TextBox1.Text = browser.Address;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            browser.Forward();
            guna2TextBox1.Text = browser.Address;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            browser.Refresh();
            browser.Reload();
            guna2TextBox1.Text = browser.Address;

        }

        private void chromiumWebBrowser1_FrameLoadEnd(object sender, EventArgs e)
        {
           

        }

       
        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            guna2TextBox1.Select();

        }
    }
}
