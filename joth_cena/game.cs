using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace slotmachine
{
    public partial class game : Form
    {

        
        public game()
        {
            InitializeComponent();   
        }

        int a, b, c, d, ez, f, g , h, likme =50 , sum = 200,sum2;
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            progressBar1.Maximum = progressBar2.Maximum
                = progressBar3.Maximum = progressBar4.Maximum
                = panel1.VerticalScroll.Maximum - (1 / 6 * VerticalScroll.Maximum);
            progressBar1.Value = progressBar2.Value
                = progressBar3.Value = progressBar4.Value = 0; 

            switch (b) ////////////////////////4switchi parada iepriekšejo griezienu
            {
                case 1:
                    pictureBox10.Image = pictureBox6.Image;
                    break;
                case 2:
                    pictureBox10.Image = pictureBox8.Image;
                    break;
                case 3:
                    pictureBox10.Image = pictureBox7.Image;
                    break;
                case 4:
                    pictureBox10.Image = pictureBox5.Image;
                    break;
                case 5:
                    pictureBox10.Image = pictureBox9.Image;
                    break;

            }
            switch (d)
            {
                case 1:
                    pictureBox11.Image = pictureBox6.Image;
                    break;
                case 2:
                    pictureBox11.Image = pictureBox8.Image;
                    break;
                case 3:
                    pictureBox11.Image = pictureBox7.Image;
                    break;
                case 4:
                    pictureBox11.Image = pictureBox5.Image;
                    break;
                case 5:
                    pictureBox11.Image = pictureBox9.Image;
                    break;

            }
            switch (f)
            {
                case 1:
                    pictureBox12.Image = pictureBox6.Image;
                    break;
                case 2:
                    pictureBox12.Image = pictureBox8.Image;
                    break;
                case 3:
                    pictureBox12.Image = pictureBox7.Image;
                    break;
                case 4:
                    pictureBox12.Image = pictureBox5.Image;
                    break;
                case 5:
                    pictureBox12.Image = pictureBox9.Image;
                    break;

            }
            switch (h)
            {
                case 1:
                    pictureBox13.Image = pictureBox6.Image;
                    break;
                case 2:
                    pictureBox13.Image = pictureBox8.Image;
                    break;
                case 3:
                    pictureBox13.Image = pictureBox7.Image;
                    break;
                case 4:
                    pictureBox13.Image = pictureBox5.Image;
                    break;
                case 5:
                    pictureBox13.Image = pictureBox9.Image;
                    break;

            }
            //lock sagaida lidz izgriežas
            if (checkBox1.Checked == true) button1.Enabled = false;
            else button1.Enabled = true;

            timer1.Enabled = false;
            Random rnd = new Random();
            a = 4; 
            b = rnd.Next(1, 6);     
            c = 6;      
            d = rnd.Next(1, 6);
            ez = 8;      
            f = rnd.Next(1, 6);
            g = 12;
            h = rnd.Next(1, 6);
           // b = d = f = h=4;
            label1.Text = b.ToString();
            label2.Text = d.ToString();
            label3.Text = f.ToString();
            label4.Text = h.ToString();

            timer1.Enabled = true;
            if (radioButton1.Checked == true) likme = 15;
            if (radioButton2.Checked == true) likme = 15*4;
            if (radioButton3.Checked == true) likme = 15*8;
           
            sum -= likme;
            sum2 = sum;

            button1.BackColor = Color.Red;
            button1.Text = sum.ToString();

            ////////////////////////////////////////////////izmaksas aprekins
            if ((b == d) && (f == h) && (h == b)) //// ja visi 4 vienadi
            {
                button1.BackColor = Color.Green;
                    
                    if(b==4)
                    (new SoundPlayer(Application.StartupPath +"\\cena2.wav")).Play();
                    else (new SoundPlayer(Application.StartupPath + "\\cena.wav")).Play();

                switch(b)
                {
                    case 1:
                        pictureBox6.Visible = true;
                        break;
                    case 2:
                        pictureBox8.Visible = true;
                        break;
                    case 3:
                        pictureBox7.Visible = true;
                        break;
                    case 4:
                        pictureBox5.Visible = true;
                        break;
                    case 5:
                        pictureBox9.Visible = true;
                        break;

                }
                    



                sum += ((100 * b * 2) * likme / 15); return;
            }
            else if ((h == d) && (f == h) || (b == d) && (f == b)) //// la no kreisas 3 vienadi
            {
                button1.BackColor = Color.Green;
                sum += ((10 * h) * likme / 15); return;
            }
            else if ((b == d) && (f == h)) //// ja  blakuspari  vienadi
            {
                button1.BackColor = Color.Green;
                sum += ((8 * b + 8 * f) * likme / 15); return;
            }
            else if ((b == d) || (f == h) ||(d==f)) //// ja  blakus  vienadi
            {
                button1.BackColor = Color.Green;
                sum += ((5 * b + 5 * f) * likme / 15); return;
            }
  
        }

        private void discControl_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
           
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            /*
            try
            {
                 (new SoundPlayer(@"C:\Users\Denz\Downloads\VK audio\cena.wav")).Play();
                 (new SoundPlayer(@"/joth_cena;component/sounds/pacman.wav")).Play();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
             */
            //m = m + 10;
            ////////////////////////////////////////////////////pirmais slots
            if ((a > 0))
            {
                if (panel1.VerticalScroll.Value < panel1.VerticalScroll.Maximum * 5 / 6)    
                {
                    panel1.VerticalScroll.Value += 60;
  
                }else
                {
                    panel1.VerticalScroll.Value = panel1.VerticalScroll.Minimum;       
                    a--;
                }
            }
             else
            {   
                    if (panel1.VerticalScroll.Value < panel1.VerticalScroll.Maximum * b / 6)
                    {
                        panel1.VerticalScroll.Value += 18;
                        progressBar1.Value = panel1.VerticalScroll.Value;
                    }
                    else label1.Visible = true;
            }
            //////////////////////////////////otrais slots
            if ((c > 0))
            {
                if (panel2.VerticalScroll.Value < panel2.VerticalScroll.Maximum * 5 / 6)
                {
                    panel2.VerticalScroll.Value += 60;
                }
                else
                {
                    panel2.VerticalScroll.Value = panel1.VerticalScroll.Minimum;
                    c--;
                }
            }
            else
            {
                if (panel2.VerticalScroll.Value < panel2.VerticalScroll.Maximum * d / 6)
                {
                    panel2.VerticalScroll.Value += 18;
                    progressBar2.Value = panel2.VerticalScroll.Value;
                }
                else label2.Visible = true;
            }
            ///////////////////////////////tresais slots
            if ((ez > 0))
            {
                if (panel3.VerticalScroll.Value < panel3.VerticalScroll.Maximum * 5 / 6)
                {
                    panel3.VerticalScroll.Value += 60;
                }
                else
                {
                    panel3.VerticalScroll.Value = panel3.VerticalScroll.Minimum;
                    ez--;
                }
            }
            else
            {
                if (panel3.VerticalScroll.Value < panel3.VerticalScroll.Maximum * f / 6)
                {
                    panel3.VerticalScroll.Value += 18;
                    progressBar3.Value = panel3.VerticalScroll.Value;
                }
                else label3.Visible = true;
            }
            // ///////////////////////////////////////////ceturtais
            if ((g > 0))
            {
                if (panel4.VerticalScroll.Value < panel4.VerticalScroll.Maximum * 5 / 6)
                {
                    panel4.VerticalScroll.Value += 60;
                }
                else
                {
                    panel4.VerticalScroll.Value = panel4.VerticalScroll.Minimum;
                    g--;
                }
            }
            else
            {
                if (panel4.VerticalScroll.Value < panel4.VerticalScroll.Maximum * h / 6)
                {
                    panel4.VerticalScroll.Value += 18;
                    progressBar4.Value = panel4.VerticalScroll.Value;
                    if (sum > sum2) {
                        button1.Text = sum2++.ToString();
                    }
                }
                else {
                    button1.Text = sum.ToString();
                    button1.Enabled = true;
                     label4.Visible = true;
                }
                    
                
                
            }

          
        

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            panel1.VerticalScroll.Value = panel1.VerticalScroll.Minimum;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Minimum;
            panel3.VerticalScroll.Value = panel3.VerticalScroll.Minimum;
            panel1.VerticalScroll.Value = panel1.VerticalScroll.Minimum;
            panel2.VerticalScroll.Value = panel2.VerticalScroll.Minimum;
            panel3.VerticalScroll.Value = panel3.VerticalScroll.Minimum;
            panel4.VerticalScroll.Value = panel2.VerticalScroll.Minimum;
            panel4.VerticalScroll.Value = panel3.VerticalScroll.Minimum;

            //timer1.Enabled = true;
                
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_MouseHover(object sender, EventArgs e)
        {

        }

        private void izietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void datubazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form db_pievienot = new db_rezult(button1.Text);
            
            db_pievienot.ShowDialog(this);
 
        }



        private void datubazeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           Form rezult =new Form1();
            rezult.ShowDialog(this);

   
        }

     
        // nodos db rezultatu

       

    }
}
