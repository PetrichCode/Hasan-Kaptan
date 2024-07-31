using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Hasan_Kaptan
{
    public partial class Form1 : Form
    {
        private int moveDistance = 606; // Toplam hareket mesafesi
        private int moveSpeed = 7; // Hýz (her tikte hareket ettirilecek birim sayýsý)
        private int moved = 0; // Toplam hareket edilen mesafe
        int secim1 = 0;
        int secim2 = 0;
        int skor = 0;
        int maxpuan = 40;
        int zorlk = 1;
        bool goLeft, goRight, boostbool;

        int speed = 8;
        int boost = 0;
        string facing = "right";


        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secim1 = rnd.Next(1, 8); // 1-7 arasý random seçim
            boostBar.Minimum = 0;
            boostBar.Maximum = 100;
            boostBar.Value = boost;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {


            dtnt1(secim1); // Ýlk TNT'yi hareket ettir
            if(captan.Bounds.IntersectsWith(tnt1.Bounds)||
                captan.Bounds.IntersectsWith(tnt2.Bounds) ||
                captan.Bounds.IntersectsWith(tnt3.Bounds) ||
                captan.Bounds.IntersectsWith(tnt4.Bounds) ||
                captan.Bounds.IntersectsWith(tnt5.Bounds) ||
                captan.Bounds.IntersectsWith(tnt6.Bounds) ||
                captan.Bounds.IntersectsWith(tnt7.Bounds) ) 
            {
                gameTimer.Stop();
                timer1.Stop();
                DialogResult again =MessageBox.Show("SKORUNUZ: " + skor+" Yeniden Baþla?","GAME OVER!" , MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if( again == DialogResult.Yes )
                {
                    RestartGame();

                }
                else
               {
                    this.Close();

                }

            }
        }
        private void RestartGame()
        {
            // Oyun durumunu sýfýrla
            skor = 0;
            moved = 0;
            secim1 = rnd.Next(1, 8);
            moveSpeed = 7;
            zorlk = 1;
            maxpuan = 40;

            // Görsel öðelerin baþlangýç konumuna getirilmesi
            tnt1.Top = 118;
            tnt2.Top = 118;
            tnt3.Top = 118;
            tnt4.Top = 118;
            tnt5.Top = 118;
            tnt6.Top = 118;
            tnt7.Top = 118;
            tnt1.Visible = false;
            tnt2.Visible = false;
            tnt3.Visible = false;
            tnt4.Visible = false;
            tnt5.Visible = false;
            tnt6.Visible = false;
            tnt7.Visible = false;

            // Captan pozisyonu sýfýrlama ve yön ayarý
            captan.Left = 803;
            captan.Image = Properties.Resources.sagKaptan1;
            facing = "right";

            // Bayraklarý sýfýrlama
            goLeft = false;
            goRight = false;
            boostbool = false;

            // Hýz ve güç ayarlarýný sýfýrlama
            speed = 8;
            boost = 0;
            boostBar.Value = boost;

            // Timer'ý yeniden baþlat
            gameTimer.Start();
            timer1.Start();

            // Skor ve zorluk bilgilerini güncelle
            score.Text = "SKOR: " + skor;
            zorluk.Text = "ZORLUK: " + zorlk;
        }
        private void dtnt1(int secim)
        {
            if (secim == 1)
            {
                if (moved < moveDistance)
                {
                    tnt1.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt1.Visible = true;
                }
                else
                {
                    ResetMovement(tnt1);
                    skor += 5;
                }
            }
            else if (secim == 2)
            {
                if (moved < moveDistance)
                {
                    tnt2.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt2.Visible = true;
                }
                else
                {
                    ResetMovement(tnt2);
                    skor += 5;
                }
            }
            else if (secim == 3)
            {
                if (moved < moveDistance)
                {
                    tnt3.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt3.Visible = true;
                }
                else
                {
                    ResetMovement(tnt3);
                    skor += 5;
                }
            }
            else if (secim == 4)
            {
                if (moved < moveDistance)
                {
                    tnt4.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt4.Visible = true;
                }
                else
                {
                    ResetMovement(tnt4);
                    skor += 5;
                }
            }
            else if (secim == 5)
            {
                if (moved < moveDistance)
                {
                    tnt5.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt5.Visible = true;
                }
                else
                {
                    ResetMovement(tnt5);
                    skor += 5;
                }
            }
            else if (secim == 6)
            {
                if (moved < moveDistance)
                {
                    tnt6.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt6.Visible = true;
                }
                else
                {
                    ResetMovement(tnt6);
                    skor += 5;
                }
            }
            else if (secim == 7)
            {
                if (moved < moveDistance)
                {
                    tnt7.Top += moveSpeed;
                    moved += moveSpeed;
                    tnt7.Visible = true;
                }
                else
                {
                    ResetMovement(tnt7);
                    skor += 5;
                }
            }
            score.Text = "SKOR: " + skor;
            if (skor > maxpuan)
            {
                moveSpeed += 5;
                maxpuan += 40;
                zorlk++;
                zorluk.Text = "ZORLUK: " + zorlk;
            }
        }

        private void ResetMovement(PictureBox tnt)
        {
            tnt.Top -= moveDistance; // Hareket tamamlandýðýnda baþa dön
            tnt.Visible = false;
            moved = 0; // Hareket edilen mesafeyi sýfýrla
            secim1 = rnd.Next(1, 8); // Ýlk TNT için yeni random seçim yap

        }

        private void tnt2_Click(object sender, EventArgs e)
        {
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                captan.Image = Properties.Resources.solKaptan1;

            }


            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "Right";
                captan.Image = Properties.Resources.sagKaptan1;
            }

            if (e.KeyCode == Keys.Space)
            {
                boostbool = true;
            }
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;


            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;

            }

            if (e.KeyCode == Keys.Space)
            {
                boostbool = false;
            }
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (goLeft == true && captan.Left > 0)
            {
                captan.Left -= speed;
            }

            if (goRight == true && captan.Left + captan.Width < this.ClientSize.Width)
            {
                captan.Left += speed;
            }

            if (boostbool == true && boost > 10)
            {
                speed = 12;
                if (boost > 4)
                    boost = boost - 5;

            }
            else
            {
                speed = 8;
                if (boost < 100)
                    boost = boost + 1;
            }
            boostBar.Value = boost;
        }

    }
}
