using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Benchmarks

{

    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        public Form1()
        {
            InitializeComponent();
        }

        public void radiof()
        {
            pictureBox2.Image = null;
            checkBox1.Text = "--";
            checkBox2.Text = "--";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            listBox1.Visible = true;
        }
        public void com1()
        {
            checkBox1.Text = "Single-Thread";
            checkBox2.Text = "Multi-Thread";
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            pictureBox2.Image = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            listBox1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;

            if (com1boBox1.SelectedIndex == 0)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = false;
                radioButton1.Text = "Geração 1000";
                radioButton2.Text = "Geração 2000";
                radioButton3.Text = "Geração 3000";
                radioButton4.Text = "Geração 4000";
                radioButton5.Text = "Geração 5000";
                pictureBox1.Image = Properties.Resources.Ryzen;
            } else if (com1boBox1.SelectedIndex == 1)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton1.Text = "7º Geração (Kaby Lake)";
                radioButton2.Text = "8º Geração (Coffee Lake)";
                radioButton3.Text = "9º Geração (Coffee Lake Refresh)";
                radioButton4.Text = "10º Geração (Comet Lake)";
                radioButton5.Text = "11º Geração (Rocket Lake)";
                radioButton6.Text = "12º Geração (Alder Lake)";
                pictureBox1.Image = Properties.Resources.intel_white;
            }
            else
            {
                radioButton1.Text = "--";
                radioButton2.Text = "--";
                radioButton3.Text = "--";
                radioButton4.Text = "--";
                radioButton5.Text = "--";
                radioButton6.Text = "--";
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            label1.Text = "";
            label2.Text = "";

            if (com1boBox1.SelectedIndex == 0)
            {
                com1();
                if (listBox1.Text == "Ryzen 3 1200")
                {
                    pictureBox2.Image = Properties.Resources.r3_1200;

                }
                else if (listBox1.Text == "Ryzen 5 1600")
                {
                    pictureBox2.Image = Properties.Resources.r5;
                }
                else if (listBox1.Text == "Ryzen 7 1700")
                {
                    pictureBox2.Image = Properties.Resources.r7;
                }
                else if (listBox1.Text == "Ryzen 3 2200g")
                {
                    pictureBox2.Image = Properties.Resources.r3_2200;
                }
                else if (listBox1.Text == "Ryzen 5 2600")
                {
                    pictureBox2.Image = Properties.Resources.r5;
                }
                else if (listBox1.Text == "Ryzen 7 2700")
                {
                    pictureBox2.Image = Properties.Resources.r7;
                }
                else if (listBox1.Text == "Ryzen 3 3200g")
                {
                    pictureBox2.Image = Properties.Resources.r3_3200;
                }
                else if (listBox1.Text == "Ryzen 5 3600")
                {
                    pictureBox2.Image = Properties.Resources.r5_3600;
                }
                else if (listBox1.Text == "Ryzen 7 3700x")
                {
                    pictureBox2.Image = Properties.Resources.r7_3700;
                }
                else if (listBox1.Text == "Ryzen 3 4100")
                {
                    pictureBox2.Image = Properties.Resources.r3_4100;
                }
                else if (listBox1.Text == "Ryzen 5 4600g")
                {
                    pictureBox2.Image = Properties.Resources.r5_4600;
                }
                else if (listBox1.Text == "Ryzen 7 4700g")
                {
                    pictureBox2.Image = Properties.Resources.r7;
                }
                else if (listBox1.Text == "Ryzen 3 5300g")
                {
                    pictureBox2.Image = Properties.Resources.r3_5300;
                }
                else if (listBox1.Text == "Ryzen 5 5600")
                {
                    pictureBox2.Image = Properties.Resources.r5_5600;
                }
                else if (listBox1.Text == "Ryzen 7 5800x")
                {
                    pictureBox2.Image = Properties.Resources.r7_5800;
                }
            }

            else if (com1boBox1.SelectedIndex == 1) {
                com1();
                if (listBox1.Text == "i3-7100")
                {
                    pictureBox2.Image = Properties.Resources.i37100;
                }
                else if (listBox1.Text == "i3-8100")
                {
                    pictureBox2.Image = Properties.Resources.i38100;
                }
                else if (listBox1.Text == "i3-9100")
                {
                    pictureBox2.Image = Properties.Resources.i39100;
                }
                else if (listBox1.Text == "i3-10100")
                {
                    pictureBox2.Image = Properties.Resources.i310100;
                }
                else if (listBox1.Text == "i3-11100")
                {
                    pictureBox2.Image = Properties.Resources.i311100;
                }
                else if (listBox1.Text == "i3-12100")
                {
                    pictureBox2.Image = Properties.Resources.i312100;
                }
                else if (listBox1.Text == "i5-7500")
                {
                    pictureBox2.Image = Properties.Resources.i57500;
                }
                else if (listBox1.Text == "i5-8500")
                {
                    pictureBox2.Image = Properties.Resources.i58500;
                }
                else if (listBox1.Text == "i5-9500")
                {
                    pictureBox2.Image = Properties.Resources.i59500;
                }
                else if (listBox1.Text == "i5-10500")
                {
                    pictureBox2.Image = Properties.Resources.i510500;
                }
                else if (listBox1.Text == "i5-11500")
                {
                    pictureBox2.Image = Properties.Resources.i511500;
                }
                else if (listBox1.Text == "i5-12500")
                {
                    pictureBox2.Image = Properties.Resources.i512500;
                }
                else if (listBox1.Text == "i7-7700")
                {
                    pictureBox2.Image = Properties.Resources.i77700;
                }
                else if (listBox1.Text == "i7-8700")
                {
                    pictureBox2.Image = Properties.Resources.i78700;
                }
                else if (listBox1.Text == "i7-9700")
                {
                    pictureBox2.Image = Properties.Resources.i79700;
                }
                else if (listBox1.Text == "i7-10700")
                {
                    pictureBox2.Image = Properties.Resources.i710700;
                }
                else if (listBox1.Text == "i7-11700")
                {
                    pictureBox2.Image = Properties.Resources.i711700;
                }
                else if (listBox1.Text == "i7-12700")
                {
                    pictureBox2.Image = Properties.Resources.i712700;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 0 && radioButton1.Checked)
            {
                listBox1.Items.Clear(); 
                listBox1.Items.Add("Ryzen 3 1200");
                listBox1.Items.Add("Ryzen 5 1600");
                listBox1.Items.Add("Ryzen 7 1700");
            }
            if (com1boBox1.SelectedIndex == 1 && radioButton1.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-7100");
                listBox1.Items.Add("i5-7500");
                listBox1.Items.Add("i7-7700");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 0 && radioButton2.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ryzen 3 2200g");
                listBox1.Items.Add("Ryzen 5 2600");
                listBox1.Items.Add("Ryzen 7 2700");
            }
            if (com1boBox1.SelectedIndex == 1 && radioButton2.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-8100");
                listBox1.Items.Add("i5-8500");
                listBox1.Items.Add("i7-8700");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 0 && radioButton3.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ryzen 3 3200g");
                listBox1.Items.Add("Ryzen 5 3600");
                listBox1.Items.Add("Ryzen 7 3700x");
            }
            if (com1boBox1.SelectedIndex == 1 && radioButton3.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-9100");
                listBox1.Items.Add("i5-9500");
                listBox1.Items.Add("i7-9700");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 0 && radioButton4.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ryzen 3 4100");
                listBox1.Items.Add("Ryzen 5 4600g");
                listBox1.Items.Add("Ryzen 7 4700g");
            }
            if (com1boBox1.SelectedIndex == 1 && radioButton4.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-10100");
                listBox1.Items.Add("i5-10500");
                listBox1.Items.Add("i7-10700");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 0 && radioButton5.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Ryzen 3 5300g");
                listBox1.Items.Add("Ryzen 5 5600");
                listBox1.Items.Add("Ryzen 7 5800x");
            }
            if (com1boBox1.SelectedIndex == 1 && radioButton5.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-11100");
                listBox1.Items.Add("i5-11500");
                listBox1.Items.Add("i7-11700");
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            radiof();
            if (com1boBox1.SelectedIndex == 1 && radioButton6.Checked)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("i3-12100");
                listBox1.Items.Add("i5-12500");
                listBox1.Items.Add("i7-12700");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                if (listBox1.Text == "Ryzen 3 1200")
                {
                    label1.Text = "1930";

                }
                else if (listBox1.Text == "Ryzen 5 1600")
                {
                    label1.Text = "2070";
                }
                else if (listBox1.Text == "Ryzen 7 1700")
                {
                   label1.Text = "1999";
                }
                else if (listBox1.Text == "Ryzen 3 2200g")
                {
                    label1.Text = "2051";
                }
                else if (listBox1.Text == "Ryzen 5 2600")
                {
                    label1.Text = "2252";
                }
                else if (listBox1.Text == "Ryzen 7 2700")
                {
                    label1.Text = "2196";
                }
                else if (listBox1.Text == "Ryzen 3 3200g")
                {
                   label1.Text = "2208";
                }
                else if (listBox1.Text == "Ryzen 5 3600")
                {
                    label1.Text = "2571";
                }
                else if (listBox1.Text == "Ryzen 7 3700x")
                {
                   label1.Text = "2666";
                }
                else if (listBox1.Text == "Ryzen 3 4100")
                {
                    label1.Text = "2569";
                }
                else if (listBox1.Text == "Ryzen 5 4600g")
                {
                    label1.Text = "2657";
                }
                else if (listBox1.Text == "Ryzen 7 4700g")
                {
                    label1.Text = "2753";
                }
                else if (listBox1.Text == "Ryzen 3 5300g")
                {
                    label1.Text = "3017";
                }
                else if (listBox1.Text == "Ryzen 5 5600")
                {
                    label1.Text = "3228";
                }
                else if (listBox1.Text == "Ryzen 7 5800x")
                {
                    label1.Text = "3449";
                }
                else if (listBox1.Text == "i3-7100")
                {
                    label1.Text = "2341";
                }
                else if (listBox1.Text == "i3-8100")
                {
                    label1.Text = "2237";
                }
                else if (listBox1.Text == "i3-9100")
                {
                    label1.Text = "2514";
                }
                else if (listBox1.Text == "i3-10100")
                {
                    label1.Text = "2635";
                }
                else if (listBox1.Text == "i3-11100")
                {
                    label1.Text = "2912";
                }
                else if (listBox1.Text == "i3-12100")
                {
                    label1.Text = "3562";
                }
                else if (listBox1.Text == "i5-7500")
                {
                    label1.Text = "2283";
                }
                else if (listBox1.Text == "i5-8500")
                {
                    label1.Text = "2481";
                }
                else if (listBox1.Text == "i5-9500")
                {
                    label1.Text = "2574";
                }
                else if (listBox1.Text == "i5-10500")
                {
                    label1.Text = "2784";
                }
                else if (listBox1.Text == "i5-11500")
                {
                   label1.Text = "3155";
                }
                else if (listBox1.Text == "i5-12500")
                {
                    label1.Text = "3744";
                }
                else if (listBox1.Text == "i7-7700")
                {
                   label1.Text = "2473";
                }
                else if (listBox1.Text == "i7-8700")
                {
                    label1.Text = "2657";
                }
                else if (listBox1.Text == "i7-9700")
                {
                    label1.Text = "2780";
                }
                else if (listBox1.Text == "i7-10700")
                {
                    label1.Text = "2922";
                }
                else if (listBox1.Text == "i7-11700")
                {
                    label1.Text = "3152";
                }
                else if (listBox1.Text == "i7-12700")
                {
                    label1.Text = "31328";
                }
            }else if(checkBox1.Checked == false)
            {
                label1.Text = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (listBox1.Text == "Ryzen 3 1200")
                {
                    label2.Text = "6311";

                }
                else if (listBox1.Text == "Ryzen 5 1600")
                {
                    label2.Text = "12327";
                }
                else if (listBox1.Text == "Ryzen 7 1700")
                {
                    label2.Text = "14843";
                }
                else if (listBox1.Text == "Ryzen 3 2200g")
                {
                    label2.Text = "6704";
                }
                else if (listBox1.Text == "Ryzen 5 2600")
                {
                    label2.Text = "13253";
                }
                else if (listBox1.Text == "Ryzen 7 2700")
                {
                    label2.Text = "15814";
                }
                else if (listBox1.Text == "Ryzen 3 3200g")
                {
                    label2.Text = "6952";
                }
                else if (listBox1.Text == "Ryzen 5 3600")
                {
                    label2.Text = "17825";
                }
                else if (listBox1.Text == "Ryzen 7 3700x")
                {
                    label2.Text = "22720";
                }
                else if (listBox1.Text == "Ryzen 3 4100")
                {
                    label2.Text = "11276";
                }
                else if (listBox1.Text == "Ryzen 5 4600g")
                {
                    label2.Text = "15615";
                }
                else if (listBox1.Text == "Ryzen 7 4700g")
                {
                    label2.Text = "20223";
                }
                else if (listBox1.Text == "Ryzen 3 5300g")
                {
                    label2.Text = "12955";
                }
                else if (listBox1.Text == "Ryzen 5 5600")
                {
                    label2.Text = "21479";
                }
                else if (listBox1.Text == "Ryzen 7 5800x")
                {
                    label2.Text = "28159";
                }
                else if (listBox1.Text == "i3-7100")
                {
                    label2.Text = "4347";
                }
                else if (listBox1.Text == "i3-8100")
                {
                    label2.Text = "6168";
                }
                else if (listBox1.Text == "i3-9100")
                {
                    label2.Text = "6628";
                }
                else if (listBox1.Text == "i3-10100")
                {
                    label2.Text = "8775";
                }
                else if (listBox1.Text == "i3-11100")
                {
                    label2.Text = "11357";
                }
                else if (listBox1.Text == "i3-12100")
                {
                    label2.Text = "14476";
                }
                else if (listBox1.Text == "i5-7500")
                {
                    label2.Text = "6059";
                }
                else if (listBox1.Text == "i5-8500")
                {
                    label2.Text = "9574";
                }
                else if (listBox1.Text == "i5-9500")
                {
                    label2.Text = "9729";
                }
                else if (listBox1.Text == "i5-10500")
                {
                    label2.Text = "13031";
                }
                else if (listBox1.Text == "i5-11500")
                {
                    label2.Text = "17634";
                }
                else if (listBox1.Text == "i5-12500")
                {
                    label2.Text = "20417";
                }
                else if (listBox1.Text == "i7-7700")
                {
                    label2.Text = "8654";
                }
                else if (listBox1.Text == "i7-8700")
                {
                    label2.Text = "13012";
                }
                else if (listBox1.Text == "i7-9700")
                {
                    label2.Text = "13397";
                }
                else if (listBox1.Text == "i7-10700")
                {
                    label2.Text = "16835";
                }
                else if (listBox1.Text == "i7-11700")
                {
                    label2.Text = "20078";
                }
                else if (listBox1.Text == "i7-12700")
                {
                    label2.Text = "3941";
                }
            }
            else if (checkBox2.Checked == false)
            {
                label2.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            SystemSounds.Exclamation.Play();
            DialogResult SimNao = new DialogResult();
            SimNao = MessageBox.Show("Tem certeza que quer sair?", "Já?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult SimNao = new DialogResult();
            SimNao = MessageBox.Show("Tem certeza que quer sair?", "Já?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (SimNao == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}