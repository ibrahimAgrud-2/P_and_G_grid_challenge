namespace P___G_Grid_Game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnImage = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlImages = new System.Windows.Forms.Panel();
            this.BtnNo = new Guna.UI2.WinForms.Guna2Button();
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.pnlImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1135, 47);
            this.panel2.TabIndex = 8;
            // 
            // btnHelp
            // 
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.White;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHelp.Location = new System.Drawing.Point(1021, 7);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHelp.Size = new System.Drawing.Size(31, 32);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnClose.Location = new System.Drawing.Point(1086, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grid Challenge";
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlCheckBoxes.Location = new System.Drawing.Point(-1, 120);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(1162, 446);
            this.pnlCheckBoxes.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 17;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(12, 77);
            this.guna2ProgressBar1.Maximum = 50;
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.DeepSkyBlue;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(1138, 24);
            this.guna2ProgressBar1.TabIndex = 9;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnImage
            // 
            this.btnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImage.ImageList = this.imageList1;
            this.btnImage.Location = new System.Drawing.Point(246, 21);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(635, 302);
            this.btnImage.TabIndex = 2;
            this.btnImage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0");
            this.imageList1.Images.SetKeyName(1, "0");
            this.imageList1.Images.SetKeyName(2, "0");
            this.imageList1.Images.SetKeyName(3, "0");
            this.imageList1.Images.SetKeyName(4, "0");
            this.imageList1.Images.SetKeyName(5, "0");
            this.imageList1.Images.SetKeyName(6, "0");
            this.imageList1.Images.SetKeyName(7, "1");
            this.imageList1.Images.SetKeyName(8, "1");
            this.imageList1.Images.SetKeyName(9, "1");
            // 
            // pnlImages
            // 
            this.pnlImages.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlImages.Controls.Add(this.btnImage);
            this.pnlImages.Controls.Add(this.BtnNo);
            this.pnlImages.Controls.Add(this.btnYes);
            this.pnlImages.Location = new System.Drawing.Point(-1, 123);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Size = new System.Drawing.Size(1162, 443);
            this.pnlImages.TabIndex = 4;
            this.pnlImages.Visible = false;
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.MediumVioletRed;
            this.BtnNo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNo.FillColor = System.Drawing.Color.MediumVioletRed;
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BtnNo.ForeColor = System.Drawing.Color.White;
            this.BtnNo.Location = new System.Drawing.Point(572, 346);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(170, 54);
            this.BtnNo.TabIndex = 1;
            this.BtnNo.Text = "No";
            this.BtnNo.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.MediumVioletRed;
            this.btnYes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYes.FillColor = System.Drawing.Color.MediumVioletRed;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Location = new System.Drawing.Point(332, 346);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(170, 54);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Yes";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 721);
            this.Controls.Add(this.pnlImages);
            this.Controls.Add(this.guna2ProgressBar1);
            this.Controls.Add(this.pnlCheckBoxes);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlImages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnHelp;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Panel pnlImages;
        private Guna.UI2.WinForms.Guna2Button BtnNo;
        private Guna.UI2.WinForms.Guna2Button btnYes;
        private System.Windows.Forms.ImageList imageList1;
    }
}

