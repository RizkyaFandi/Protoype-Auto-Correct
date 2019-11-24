namespace Protoype_Auto_Correct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkoreksi = new System.Windows.Forms.Button();
            this.tboutput = new System.Windows.Forms.TextBox();
            this.tbinput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources.IClogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(94, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indonesia Correction";
            // 
            // btnkoreksi
            // 
            this.btnkoreksi.BackColor = System.Drawing.Color.MediumBlue;
            this.btnkoreksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkoreksi.FlatAppearance.BorderSize = 0;
            this.btnkoreksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkoreksi.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnkoreksi.ForeColor = System.Drawing.Color.White;
            this.btnkoreksi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnkoreksi.Location = new System.Drawing.Point(466, 305);
            this.btnkoreksi.Name = "btnkoreksi";
            this.btnkoreksi.Size = new System.Drawing.Size(123, 39);
            this.btnkoreksi.TabIndex = 8;
            this.btnkoreksi.Text = "Correction";
            this.btnkoreksi.UseVisualStyleBackColor = false;
            this.btnkoreksi.Click += new System.EventHandler(this.btnkoreksi_Click);
            // 
            // tboutput
            // 
            this.tboutput.BackColor = System.Drawing.Color.AliceBlue;
            this.tboutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tboutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tboutput.Location = new System.Drawing.Point(8, 365);
            this.tboutput.Multiline = true;
            this.tboutput.Name = "tboutput";
            this.tboutput.Size = new System.Drawing.Size(986, 185);
            this.tboutput.TabIndex = 7;
            // 
            // tbinput
            // 
            this.tbinput.BackColor = System.Drawing.Color.Cyan;
            this.tbinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbinput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbinput.Location = new System.Drawing.Point(8, 98);
            this.tbinput.Multiline = true;
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(986, 185);
            this.tbinput.TabIndex = 6;
            this.tbinput.Enter += new System.EventHandler(this.tbinput_Enter);
            this.tbinput.Leave += new System.EventHandler(this.tbinput_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources.closeAC;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(942, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources._8W3JfzOpJiNZBnDYXHpQ3TGSMiZSG782uNXuAsrA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1010, 557);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnkoreksi);
            this.Controls.Add(this.tboutput);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prototype Auto-Correct";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkoreksi;
        private System.Windows.Forms.TextBox tboutput;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

