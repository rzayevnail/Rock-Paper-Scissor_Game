using System;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string bizimSecdiyimiz = "";
        string[] images = { "C:\\Users\\nailr\\Downloads\\rock.jpg", "C:\\Users\\nailr\\Downloads\\paper.jpg", "C:\\Users\\nailr\\Downloads\\scissors.jpg" };
        string defaultImage = "C:\\Users\\nailr\\Downloads\\qq.jpg";
        private void button1_Click(object sender, EventArgs e)
        {
            PicturePlayer1.Image = System.Drawing.Image.FromFile(images[0]);
            bizimSecdiyimiz = images[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PicturePlayer1.Image = System.Drawing.Image.FromFile(images[1]);
            bizimSecdiyimiz = images[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PicturePlayer1.Image = System.Drawing.Image.FromFile(images[2]);
            bizimSecdiyimiz = images[2];
        }
        public int timer = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer--;
            if (timer == 0)
            {
                timer3.Start();
                Random random = new Random();
                int randomIndex1 = random.Next(images.Length);
                string randomImage = images[randomIndex1];
                PictureBoxPlayer2.Image = System.Drawing.Image.FromFile(randomImage);
                if ((bizimSecdiyimiz == images[0] && randomImage == images[2]) || (bizimSecdiyimiz == images[2] && randomImage == images[0]))
                {
                    if (bizimSecdiyimiz == images[0])
                    {
                        player1++;
                    }
                    if (randomImage == images[0])
                    {
                        player2++;
                    }
                }
                if ((bizimSecdiyimiz == images[0] && randomImage == images[1]) || (bizimSecdiyimiz == images[1] && randomImage == images[0]))
                {
                    if (bizimSecdiyimiz == images[1])
                    {
                        player1++;
                    }
                    if (randomImage == images[1])
                    {
                        player2++;
                    }
                }
                if ((bizimSecdiyimiz == images[1] && randomImage == images[2]) || (bizimSecdiyimiz == images[2] && randomImage == images[1]))
                {
                    if (bizimSecdiyimiz == images[2])
                    {
                        player1++;
                    }
                    if (randomImage == images[2])
                    {
                        player2++;
                    }
                }
            }
            if (timer == 0)
            {
                timer1.Stop();
            }
            label5.Text = player1.ToString();
            label4.Text = player2.ToString();
            label10.Text = timer.ToString();//time
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (timer == 0)
            {
                PicturePlayer1.Image = System.Drawing.Image.FromFile(defaultImage);
                PictureBoxPlayer2.Image = System.Drawing.Image.FromFile(defaultImage);
                timer = 6;
            }
        }
        public int player1 = 0;
        public int player2 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "0";
            label5.Text = "0";
        }
    }
}
