namespace oni_setup
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMini = new System.Windows.Forms.PictureBox();
            this.btClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSteam = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btCod = new System.Windows.Forms.Button();
            this.btOpera = new System.Windows.Forms.Button();
            this.btDiscord = new System.Windows.Forms.Button();
            this.btActivate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbClock = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCPU = new System.Windows.Forms.Label();
            this.lbGPU = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.lbRAM = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Controls.Add(this.label1);
            this.BarraTitulo.Controls.Add(this.btMini);
            this.BarraTitulo.Controls.Add(this.btClose);
            this.BarraTitulo.Location = new System.Drawing.Point(0, -4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1281, 33);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(46, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oni Setup v1.0.0";
            // 
            // btMini
            // 
            this.btMini.BackColor = System.Drawing.Color.Transparent;
            this.btMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMini.Image = ((System.Drawing.Image)(resources.GetObject("btMini.Image")));
            this.btMini.Location = new System.Drawing.Point(1229, 8);
            this.btMini.Name = "btMini";
            this.btMini.Size = new System.Drawing.Size(20, 20);
            this.btMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btMini.TabIndex = 1;
            this.btMini.TabStop = false;
            this.btMini.Click += new System.EventHandler(this.btMini_Click);
            this.btMini.MouseEnter += new System.EventHandler(this.btMini_MouseEnter);
            this.btMini.MouseLeave += new System.EventHandler(this.btMini_MouseLeave);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClose.Image = ((System.Drawing.Image)(resources.GetObject("btClose.Image")));
            this.btClose.Location = new System.Drawing.Point(1255, 8);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(20, 20);
            this.btClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btClose.TabIndex = 0;
            this.btClose.TabStop = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            this.btClose.MouseEnter += new System.EventHandler(this.btClose_MouseEnter);
            this.btClose.MouseLeave += new System.EventHandler(this.btClose_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
            this.panel1.Controls.Add(this.btSteam);
            this.panel1.Controls.Add(this.btAbout);
            this.panel1.Controls.Add(this.btCod);
            this.panel1.Controls.Add(this.btOpera);
            this.panel1.Controls.Add(this.btDiscord);
            this.panel1.Controls.Add(this.btActivate);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 720);
            this.panel1.TabIndex = 1;
            // 
            // btSteam
            // 
            this.btSteam.BackColor = System.Drawing.Color.Transparent;
            this.btSteam.FlatAppearance.BorderSize = 0;
            this.btSteam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btSteam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btSteam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSteam.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSteam.ForeColor = System.Drawing.Color.Transparent;
            this.btSteam.Image = ((System.Drawing.Image)(resources.GetObject("btSteam.Image")));
            this.btSteam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSteam.Location = new System.Drawing.Point(0, 373);
            this.btSteam.Name = "btSteam";
            this.btSteam.Size = new System.Drawing.Size(250, 53);
            this.btSteam.TabIndex = 6;
            this.btSteam.Text = "Steam";
            this.btSteam.UseVisualStyleBackColor = false;
            this.btSteam.Click += new System.EventHandler(this.btSteam_Click);
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.Transparent;
            this.btAbout.FlatAppearance.BorderSize = 0;
            this.btAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbout.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout.ForeColor = System.Drawing.Color.Transparent;
            this.btAbout.Image = ((System.Drawing.Image)(resources.GetObject("btAbout.Image")));
            this.btAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAbout.Location = new System.Drawing.Point(0, 590);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(250, 53);
            this.btAbout.TabIndex = 5;
            this.btAbout.Text = "About";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btCod
            // 
            this.btCod.BackColor = System.Drawing.Color.Transparent;
            this.btCod.FlatAppearance.BorderSize = 0;
            this.btCod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btCod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCod.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCod.ForeColor = System.Drawing.Color.Transparent;
            this.btCod.Image = ((System.Drawing.Image)(resources.GetObject("btCod.Image")));
            this.btCod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCod.Location = new System.Drawing.Point(0, 432);
            this.btCod.Name = "btCod";
            this.btCod.Size = new System.Drawing.Size(250, 53);
            this.btCod.TabIndex = 4;
            this.btCod.Text = "BOII Pluto";
            this.btCod.UseVisualStyleBackColor = false;
            this.btCod.Click += new System.EventHandler(this.btCod_Click);
            // 
            // btOpera
            // 
            this.btOpera.BackColor = System.Drawing.Color.Transparent;
            this.btOpera.FlatAppearance.BorderSize = 0;
            this.btOpera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btOpera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btOpera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpera.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpera.ForeColor = System.Drawing.Color.Transparent;
            this.btOpera.Image = ((System.Drawing.Image)(resources.GetObject("btOpera.Image")));
            this.btOpera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOpera.Location = new System.Drawing.Point(0, 314);
            this.btOpera.Name = "btOpera";
            this.btOpera.Size = new System.Drawing.Size(250, 53);
            this.btOpera.TabIndex = 3;
            this.btOpera.Text = "OperaGX";
            this.btOpera.UseVisualStyleBackColor = false;
            this.btOpera.Click += new System.EventHandler(this.btOpera_Click);
            // 
            // btDiscord
            // 
            this.btDiscord.BackColor = System.Drawing.Color.Transparent;
            this.btDiscord.FlatAppearance.BorderSize = 0;
            this.btDiscord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btDiscord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btDiscord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiscord.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiscord.ForeColor = System.Drawing.Color.Transparent;
            this.btDiscord.Image = ((System.Drawing.Image)(resources.GetObject("btDiscord.Image")));
            this.btDiscord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDiscord.Location = new System.Drawing.Point(0, 255);
            this.btDiscord.Name = "btDiscord";
            this.btDiscord.Size = new System.Drawing.Size(250, 53);
            this.btDiscord.TabIndex = 2;
            this.btDiscord.Text = "Discord";
            this.btDiscord.UseVisualStyleBackColor = false;
            this.btDiscord.Click += new System.EventHandler(this.btDiscord_Click);
            // 
            // btActivate
            // 
            this.btActivate.BackColor = System.Drawing.Color.Transparent;
            this.btActivate.FlatAppearance.BorderSize = 0;
            this.btActivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btActivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btActivate.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btActivate.ForeColor = System.Drawing.Color.Transparent;
            this.btActivate.Image = ((System.Drawing.Image)(resources.GetObject("btActivate.Image")));
            this.btActivate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActivate.Location = new System.Drawing.Point(0, 196);
            this.btActivate.Name = "btActivate";
            this.btActivate.Size = new System.Drawing.Size(250, 53);
            this.btActivate.TabIndex = 1;
            this.btActivate.Text = "AcWindows";
            this.btActivate.UseVisualStyleBackColor = false;
            this.btActivate.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(141, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(651, 482);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbClock
            // 
            this.lbClock.AutoSize = true;
            this.lbClock.BackColor = System.Drawing.Color.Transparent;
            this.lbClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbClock.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.lbClock.Location = new System.Drawing.Point(305, 435);
            this.lbClock.Name = "lbClock";
            this.lbClock.Size = new System.Drawing.Size(348, 66);
            this.lbClock.TabIndex = 1;
            this.lbClock.Text = "HH:MM:ss";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDate.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.lbDate.Location = new System.Drawing.Point(341, 496);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(270, 39);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "dd mmm yyyy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(86)))));
            this.label5.Location = new System.Drawing.Point(927, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "v1.0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(69)))), ((int)(((byte)(86)))));
            this.label6.Location = new System.Drawing.Point(3, 664);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Created by Lionx";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.BackColor = System.Drawing.Color.Transparent;
            this.lbCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCPU.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.lbCPU.Location = new System.Drawing.Point(725, 14);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(45, 20);
            this.lbCPU.TabIndex = 9;
            this.lbCPU.Text = "CPU";
            // 
            // lbGPU
            // 
            this.lbGPU.AutoSize = true;
            this.lbGPU.BackColor = System.Drawing.Color.Transparent;
            this.lbGPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbGPU.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.lbGPU.Location = new System.Drawing.Point(725, 80);
            this.lbGPU.Name = "lbGPU";
            this.lbGPU.Size = new System.Drawing.Size(45, 20);
            this.lbGPU.TabIndex = 10;
            this.lbGPU.Text = "GPU";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.panelChildForm.Controls.Add(this.lbRAM);
            this.panelChildForm.Controls.Add(this.lbGPU);
            this.panelChildForm.Controls.Add(this.lbCPU);
            this.panelChildForm.Controls.Add(this.label6);
            this.panelChildForm.Controls.Add(this.label5);
            this.panelChildForm.Controls.Add(this.lbDate);
            this.panelChildForm.Controls.Add(this.lbClock);
            this.panelChildForm.Controls.Add(this.pictureBox2);
            this.panelChildForm.Location = new System.Drawing.Point(247, 30);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1034, 690);
            this.panelChildForm.TabIndex = 2;
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.BackColor = System.Drawing.Color.Transparent;
            this.lbRAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRAM.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.lbRAM.Location = new System.Drawing.Point(725, 47);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(45, 20);
            this.lbRAM.TabIndex = 11;
            this.lbRAM.Text = "RAM";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oni Setup";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btClose)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            this.panelChildForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btClose;
        private System.Windows.Forms.PictureBox btMini;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btCod;
        private System.Windows.Forms.Button btOpera;
        private System.Windows.Forms.Button btDiscord;
        private System.Windows.Forms.Button btActivate;
        private System.Windows.Forms.Button btSteam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbClock;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCPU;
        private System.Windows.Forms.Label lbGPU;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label lbRAM;
    }
}