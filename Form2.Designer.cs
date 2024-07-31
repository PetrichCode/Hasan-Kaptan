namespace Hasan_Kaptan
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            start = new Button();
            close = new Button();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = SystemColors.ButtonFace;
            start.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            start.Location = new Point(307, 374);
            start.Name = "start";
            start.Size = new Size(149, 56);
            start.TabIndex = 0;
            start.Text = "BAŞLA";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // close
            // 
            close.BackColor = SystemColors.ButtonFace;
            close.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            close.Location = new Point(809, 374);
            close.Name = "close";
            close.Size = new Size(149, 56);
            close.TabIndex = 1;
            close.Text = "ÇIKIŞ";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1187, 590);
            Controls.Add(close);
            Controls.Add(start);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private Button close;
    }
}