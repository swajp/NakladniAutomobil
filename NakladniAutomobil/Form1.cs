using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NakladniAutomobil
{
    public partial class Form1 : Form
    {
        int aktualniNosnost = 0;
        int maximalniHmotnost = 0;
        int nalozeni;
        int vylozeni;

        int maximalniNafta = 100;
        int aktualniNafta;


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ZNACKA
            znackaStav.Text = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //NOSNOST
            nosnostStav.Text = aktualniNosnost + "/" + textBox2.Text+ "kg";;
            if (textBox2.Text != "")
            {
                maximalniHmotnost = int.Parse(textBox2.Text);
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //NAFTA
            aktualniNafta = int.Parse(textBox3.Text);
            naftaStav.Text = aktualniNafta + "/" + maximalniNafta.ToString() + "l";
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            nalozeni = int.Parse(textBox4.Text);
            aktualniNosnost = nalozeni + aktualniNosnost;
            nosnostStav.Text = aktualniNosnost + "/" + textBox2.Text + "kg";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vylozeni = int.Parse(textBox4.Text);
            aktualniNosnost =  aktualniNosnost - vylozeni;
            nosnostStav.Text = aktualniNosnost + "/" + textBox2.Text + "kg";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            aktualniNosnost = 0;
            nosnostStav.Text = "-";

        }

        private void nosnostStav_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
