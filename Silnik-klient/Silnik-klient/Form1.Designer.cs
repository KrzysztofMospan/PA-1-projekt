namespace Silnik_klient
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
            this.connect_butotn = new System.Windows.Forms.Button();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.port_textbox = new System.Windows.Forms.ComboBox();
            this.pStob = new System.Windows.Forms.Button();
            this.pDzib = new System.Windows.Forms.Button();
            this.mDzieb = new System.Windows.Forms.Button();
            this.mStob = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_butotn
            // 
            this.connect_butotn.Location = new System.Drawing.Point(277, 25);
            this.connect_butotn.Name = "connect_butotn";
            this.connect_butotn.Size = new System.Drawing.Size(75, 23);
            this.connect_butotn.TabIndex = 0;
            this.connect_butotn.Text = "Połącz";
            this.connect_butotn.UseVisualStyleBackColor = true;
            this.connect_butotn.Click += new System.EventHandler(this.connect_butotn_Click);
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(12, 28);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(100, 20);
            this.ip_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP serwera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port serwera";
            // 
            // message_textbox
            // 
            this.message_textbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.message_textbox.Location = new System.Drawing.Point(12, 108);
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.ReadOnly = true;
            this.message_textbox.Size = new System.Drawing.Size(224, 20);
            this.message_textbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Polecenie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Wyślij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Port klienta: 80";
            // 
            // port_textbox
            // 
            this.port_textbox.FormattingEnabled = true;
            this.port_textbox.Items.AddRange(new object[] {
            "81"});
            this.port_textbox.Location = new System.Drawing.Point(136, 28);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(75, 21);
            this.port_textbox.TabIndex = 9;
            this.port_textbox.SelectedIndexChanged += new System.EventHandler(this.port_textbox_SelectedIndexChanged);
            // 
            // pStob
            // 
            this.pStob.Location = new System.Drawing.Point(12, 155);
            this.pStob.Name = "pStob";
            this.pStob.Size = new System.Drawing.Size(39, 23);
            this.pStob.TabIndex = 10;
            this.pStob.Text = "+100";
            this.pStob.UseVisualStyleBackColor = true;
            this.pStob.Click += new System.EventHandler(this.pStob_Click);
            // 
            // pDzib
            // 
            this.pDzib.Location = new System.Drawing.Point(57, 155);
            this.pDzib.Name = "pDzib";
            this.pDzib.Size = new System.Drawing.Size(39, 23);
            this.pDzib.TabIndex = 11;
            this.pDzib.Text = "+10";
            this.pDzib.UseVisualStyleBackColor = true;
            this.pDzib.Click += new System.EventHandler(this.pDzib_Click);
            // 
            // mDzieb
            // 
            this.mDzieb.Location = new System.Drawing.Point(102, 155);
            this.mDzieb.Name = "mDzieb";
            this.mDzieb.Size = new System.Drawing.Size(39, 23);
            this.mDzieb.TabIndex = 12;
            this.mDzieb.Text = "-10";
            this.mDzieb.UseVisualStyleBackColor = true;
            this.mDzieb.Click += new System.EventHandler(this.mDzieb_Click);
            // 
            // mStob
            // 
            this.mStob.Location = new System.Drawing.Point(147, 155);
            this.mStob.Name = "mStob";
            this.mStob.Size = new System.Drawing.Size(39, 23);
            this.mStob.TabIndex = 13;
            this.mStob.Text = "-100";
            this.mStob.UseVisualStyleBackColor = true;
            this.mStob.Click += new System.EventHandler(this.mStob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 194);
            this.Controls.Add(this.mStob);
            this.Controls.Add(this.mDzieb);
            this.Controls.Add(this.pDzib);
            this.Controls.Add(this.pStob);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.connect_butotn);
            this.Name = "Form1";
            this.Text = "Sterowanie silnikami krokowmi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_butotn;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox port_textbox;
        private System.Windows.Forms.Button pStob;
        private System.Windows.Forms.Button pDzib;
        private System.Windows.Forms.Button mDzieb;
        private System.Windows.Forms.Button mStob;
    }
}

