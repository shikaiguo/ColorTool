using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorTool
{
    public partial class Form_Main : Form
    {
        private Bitmap[] bmpRG, bmpP;
        private Bitmap bmpB;
        private int red = 0, green = 0, blue = 0;
        private string tempRGB="0", tempH="000000";
        public Form_Main()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer
                        | ControlStyles.ResizeRedraw
                        | ControlStyles.Selectable
                        | ControlStyles.AllPaintingInWmPaint
                        | ControlStyles.UserPaint, true);
            label_R.ForeColor = Color.Red;
            label_G.ForeColor = Color.Green;
            label_B.ForeColor = Color.Blue;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            bmpRG = new Bitmap[256];
            bmpB = new Bitmap(20, 256);
            bmpP = new Bitmap[4];
            DrawPointer();
        }
        private void DrawPointer()
        {
            bmpP[0] = new Bitmap(9, 9);
            bmpP[1] = new Bitmap(9, 9);
            bmpP[2] = new Bitmap(30, 1);
            bmpP[3] = new Bitmap(30, 1);
            for (int i = 0; i < 9; i++)
            {
                bmpP[0].SetPixel(i, 4, Color.Black);
                bmpP[0].SetPixel(4, i, Color.Black);
                bmpP[1].SetPixel(i, 4, Color.White);
                bmpP[1].SetPixel(4, i, Color.White);
            }
            for (int i = 0; i < 30; i++)
            {
                bmpP[2].SetPixel(i, 0, Color.Black);
                bmpP[3].SetPixel(i, 0, Color.White);
            }
        }
        private void pictureBox_RG_Paint(object sender, PaintEventArgs e)
        {
            if (bmpRG[blue] == null)
            {
                bmpRG[blue] = new Bitmap(256, 256);
                for (int i = 0; i < 256; i++)
                {
                    for (int j = 0; j < 256; j++)
                        bmpRG[blue].SetPixel(i, j, Color.FromArgb(i, 255 - j, blue));
                }
            }
            Graphics g = e.Graphics;
            g.DrawImage(bmpRG[blue], 0, 0);
            g.DrawImage(bmpP[red + green > 255 ? 0 : 1], red - 4, 251 - green);
        }

        private void pictureBox_B_Paint(object sender, PaintEventArgs e)
        {
            bmpB = new Bitmap(30, 256);
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 256; j++)
                    bmpB.SetPixel(i, j, Color.FromArgb(red, green, 255 - j));
            }
            Graphics g = e.Graphics;
            g.DrawImage(bmpB, 0, 0);
            g.DrawImage(bmpP[blue > 127 ? 2 : 3], 0, 255 - blue);
        }

        private void pictureBox_RGB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(Color.FromArgb(red, green, blue)), 0, 0, 56, 56);
        }

        private void pictureBox_RG_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (textBox_R.Text == "")
                    textBox_R.Text = "0";
                if (textBox_G.Text == "")
                    textBox_G.Text = "0";
                if (textBox_B.Text == "")
                    textBox_B.Text = "0";
                int x = e.Location.X, y = e.Location.Y;
                SetText(x, y);
            }
        }
        private void pictureBox_RG_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.Location.X, y = e.Location.Y;
                SetText(x, y);
            }
        }

        private void pictureBox_B_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (textBox_R.Text == "")
                    textBox_R.Text = "0";
                if (textBox_G.Text == "")
                    textBox_G.Text = "0";
                if (textBox_B.Text == "")
                    textBox_B.Text = "0";
                int y = e.Location.Y;
                SetText(-1, y);
            }
        }
        private void pictureBox_B_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int y = e.Location.Y;
                SetText(-1, y);
            }
        }
        private void SetText(int x, int y)
        {
            y = y < 0 ? 0 : y;
            y = y > 255 ? 255 : y;
            y = 255 - y;
            if (x == -1)
            {
                textBox_B.Text = y.ToString();
                return;
            }
            x = x < 0 ? 0 : x;
            x = x > 255 ? 255 : x;
            textBox_R.Text = x.ToString();
            textBox_G.Text = y.ToString();
        }

        private void textBox_R_TextChanged(object sender, EventArgs e)
        {
            string s = textBox_R.Text;
            if (s == "") return;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    MessageBox.Show("Only 0 - 9 .");
                    textBox_R.Text = tempRGB;
                    return;
                }
            }
            int val = Int16.Parse(s);
            if (val < 0 || val > 255)
            {
                MessageBox.Show("Only 0 - 255 .");
                textBox_R.Text = tempRGB;
                return;
            }
            red = val;
            tempRGB = s;
            pictureBox_RG.Invalidate();
            pictureBox_B.Invalidate();
            pictureBox_RGB.Invalidate();
            SetHex();
        }

        private void textBox_G_TextChanged(object sender, EventArgs e)
        {
            string s = textBox_G.Text;
            if (s == "") return;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    MessageBox.Show("Only 0 - 9 .");
                    textBox_G.Text = tempRGB;
                    return;
                }
            }
            int val = Int16.Parse(s);
            if (val < 0 || val > 255)
            {
                MessageBox.Show("Only 0 - 255");
                textBox_G.Text = tempRGB;
                return;
            }
            green = val;
            tempRGB = s;
            pictureBox_RG.Invalidate();
            pictureBox_B.Invalidate();
            pictureBox_RGB.Invalidate();
            SetHex();
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            string s = textBox_B.Text;
            if (s == "") return;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9')
                {
                    MessageBox.Show("Only 0 - 9");
                    textBox_B.Text = tempRGB;
                    return;
                }
            }
            int val = Int16.Parse(s);
            if (val < 0 || val > 255)
            {
                MessageBox.Show("Only 0 - 255");
                textBox_B.Text = tempRGB;
                return;
            }
            blue = val;
            tempRGB = s;
            pictureBox_RG.Invalidate();
            pictureBox_B.Invalidate();
            pictureBox_RGB.Invalidate();
            SetHex();
        }

        private void textBox_H_TextChanged(object sender, EventArgs e)
        {
            string s = textBox_H.Text;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= '0' && s[i] <= '9') || (s[i] >= 'a' && s[i] <= 'f') || (s[i] >= 'A' && s[i] <= 'F'))
                    continue;
                else
                {
                    MessageBox.Show("Only 0 - 9 AND a - f ( A - F )");
                    textBox_H.Text = tempH;
                    textBox_H.SelectionStart = textBox_H.Text.Length;
                    return;
                }
            }
            tempH = textBox_H.Text;
            if (s.Length == 6)
            {
                textBox_R.Text = Convert.ToInt32(s.Substring(0, 2), 16).ToString();
                textBox_G.Text = Convert.ToInt32(s.Substring(2, 2), 16).ToString();
                textBox_B.Text = Convert.ToInt32(s.Substring(4, 2), 16).ToString();
            }
        }
        private void textBox_R_Enter(object sender, EventArgs e)
        {
            if (textBox_G.Text == "")
                textBox_G.Text = "0";
            if (textBox_B.Text == "")
                textBox_B.Text = "0";
            tempRGB = textBox_R.Text;
        }

        private void textBox_G_Enter(object sender, EventArgs e)
        {
            if (textBox_R.Text == "")
                textBox_R.Text = "0";
            if (textBox_B.Text == "")
                textBox_B.Text = "0";
            tempRGB = textBox_G.Text;
        }

        private void textBox_B_Enter(object sender, EventArgs e)
        {
            if (textBox_R.Text == "")
                textBox_R.Text = "0";
            if (textBox_G.Text == "")
                textBox_G.Text = "0";
            tempRGB = textBox_B.Text;
        }
        private void SetHex()
        {
            string s = string.Format("{0:x2}", Int16.Parse(textBox_R.Text));
            s += string.Format("{0:x2}", Int16.Parse(textBox_G.Text));
            s += string.Format("{0:x2}", Int16.Parse(textBox_B.Text));
            textBox_H.Text = s;
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            contextMenuStrip_Copy.Show(MousePosition.X,MousePosition.Y);
        }

        private void copyRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, "rgb(" + textBox_R.Text + ", " + textBox_G.Text + ", " + textBox_B.Text + ")");
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, "#" + textBox_H.Text);
        }

        private void button_Picker_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developing");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show(this);
        }
    }
}
