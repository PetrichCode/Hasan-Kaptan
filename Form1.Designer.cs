namespace Hasan_Kaptan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tnt1 = new PictureBox();
            tnt2 = new PictureBox();
            tnt3 = new PictureBox();
            tnt4 = new PictureBox();
            tnt5 = new PictureBox();
            tnt6 = new PictureBox();
            tnt7 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            score = new Label();
            zorluk = new Label();
            pictureBox1 = new PictureBox();
            boostBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            captan = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tnt1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tnt7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)captan).BeginInit();
            SuspendLayout();
            // 
            // tnt1
            // 
            tnt1.BackColor = Color.Transparent;
            tnt1.Image = (Image)resources.GetObject("tnt1.Image");
            tnt1.Location = new Point(306, 12);
            tnt1.Name = "tnt1";
            tnt1.Size = new Size(137, 100);
            tnt1.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt1.TabIndex = 0;
            tnt1.TabStop = false;
            tnt1.Visible = false;
            // 
            // tnt2
            // 
            tnt2.BackColor = Color.Transparent;
            tnt2.Image = (Image)resources.GetObject("tnt2.Image");
            tnt2.Location = new Point(464, 12);
            tnt2.Name = "tnt2";
            tnt2.Size = new Size(137, 100);
            tnt2.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt2.TabIndex = 1;
            tnt2.TabStop = false;
            tnt2.Visible = false;
            tnt2.Click += tnt2_Click;
            // 
            // tnt3
            // 
            tnt3.BackColor = Color.Transparent;
            tnt3.Image = (Image)resources.GetObject("tnt3.Image");
            tnt3.Location = new Point(629, 12);
            tnt3.Name = "tnt3";
            tnt3.Size = new Size(137, 100);
            tnt3.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt3.TabIndex = 2;
            tnt3.TabStop = false;
            tnt3.Visible = false;
            // 
            // tnt4
            // 
            tnt4.BackColor = Color.Transparent;
            tnt4.Image = (Image)resources.GetObject("tnt4.Image");
            tnt4.Location = new Point(803, 12);
            tnt4.Name = "tnt4";
            tnt4.Size = new Size(137, 100);
            tnt4.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt4.TabIndex = 3;
            tnt4.TabStop = false;
            tnt4.Visible = false;
            // 
            // tnt5
            // 
            tnt5.BackColor = Color.Transparent;
            tnt5.Image = (Image)resources.GetObject("tnt5.Image");
            tnt5.Location = new Point(962, 12);
            tnt5.Name = "tnt5";
            tnt5.Size = new Size(137, 100);
            tnt5.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt5.TabIndex = 4;
            tnt5.TabStop = false;
            tnt5.Visible = false;
            // 
            // tnt6
            // 
            tnt6.BackColor = Color.Transparent;
            tnt6.Image = (Image)resources.GetObject("tnt6.Image");
            tnt6.Location = new Point(1128, 12);
            tnt6.Name = "tnt6";
            tnt6.Size = new Size(137, 100);
            tnt6.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt6.TabIndex = 5;
            tnt6.TabStop = false;
            tnt6.Visible = false;
            // 
            // tnt7
            // 
            tnt7.BackColor = Color.Transparent;
            tnt7.Image = (Image)resources.GetObject("tnt7.Image");
            tnt7.Location = new Point(1298, 12);
            tnt7.Name = "tnt7";
            tnt7.Size = new Size(137, 100);
            tnt7.SizeMode = PictureBoxSizeMode.StretchImage;
            tnt7.TabIndex = 6;
            tnt7.TabStop = false;
            tnt7.Visible = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.Font = new Font("Modern No. 20", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score.ForeColor = Color.White;
            score.Location = new Point(1, 0);
            score.Name = "score";
            score.Size = new Size(89, 22);
            score.TabIndex = 7;
            score.Text = "SKOR: 0";
            // 
            // zorluk
            // 
            zorluk.AutoSize = true;
            zorluk.BackColor = Color.Transparent;
            zorluk.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            zorluk.ForeColor = Color.White;
            zorluk.Location = new Point(1, 22);
            zorluk.Name = "zorluk";
            zorluk.Size = new Size(104, 20);
            zorluk.TabIndex = 8;
            zorluk.Text = "ZORLUK: 1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1449, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // boostBar
            // 
            boostBar.Location = new Point(1569, 55);
            boostBar.Name = "boostBar";
            boostBar.Size = new Size(125, 29);
            boostBar.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 20;
            timer1.Tick += MainTimerEvent;
            // 
            // captan
            // 
            captan.BackColor = Color.Transparent;
            captan.Image = Properties.Resources.sagKaptan1;
            captan.Location = new Point(803, 524);
            captan.Name = "captan";
            captan.Size = new Size(151, 222);
            captan.SizeMode = PictureBoxSizeMode.StretchImage;
            captan.TabIndex = 12;
            captan.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1750, 774);
            Controls.Add(tnt7);
            Controls.Add(tnt6);
            Controls.Add(tnt5);
            Controls.Add(tnt4);
            Controls.Add(tnt3);
            Controls.Add(tnt2);
            Controls.Add(tnt1);
            Controls.Add(captan);
            Controls.Add(boostBar);
            Controls.Add(pictureBox1);
            Controls.Add(zorluk);
            Controls.Add(score);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Hasan Kaptan";
            Load += Form1_Load;
            KeyDown += gamekeydown;
            KeyUp += gamekeyup;
            ((System.ComponentModel.ISupportInitialize)tnt1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt3).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt4).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt5).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt6).EndInit();
            ((System.ComponentModel.ISupportInitialize)tnt7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)captan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox tnt1;
        private PictureBox tnt2;
        private PictureBox tnt3;
        private PictureBox tnt4;
        private PictureBox tnt5;
        private PictureBox tnt6;
        private PictureBox tnt7;
        private System.Windows.Forms.Timer gameTimer;
        private Label score;
        private Label zorluk;
        private PictureBox pictureBox1;
        private ProgressBar boostBar;
        private System.Windows.Forms.Timer timer1;
        private PictureBox captan;
    }
}
