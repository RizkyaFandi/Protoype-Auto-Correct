﻿namespace Protoype_Auto_Correct
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
            this.tbinput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tboutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources.IClogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Freestyle Script", 24F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(106, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Indonesian Correction";
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
            this.btnkoreksi.Location = new System.Drawing.Point(495, 378);
            this.btnkoreksi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkoreksi.Name = "btnkoreksi";
            this.btnkoreksi.Size = new System.Drawing.Size(163, 49);
            this.btnkoreksi.TabIndex = 8;
            this.btnkoreksi.Text = "Correction";
            this.btnkoreksi.UseVisualStyleBackColor = false;
            this.btnkoreksi.Click += new System.EventHandler(this.btnkoreksi_Click);
            // 
            // tbinput
            // 
            this.tbinput.BackColor = System.Drawing.Color.Cyan;
            this.tbinput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbinput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbinput.Location = new System.Drawing.Point(15, 122);
            this.tbinput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbinput.Multiline = true;
            this.tbinput.Name = "tbinput";
            this.tbinput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbinput.Size = new System.Drawing.Size(1109, 231);
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
            this.pictureBox2.Location = new System.Drawing.Point(1060, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 70);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // tboutput
            // 
            this.tboutput.BackColor = System.Drawing.Color.LightCyan;
            this.tboutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tboutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tboutput.Location = new System.Drawing.Point(14, 450);
            this.tboutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboutput.Multiline = true;
            this.tboutput.Name = "tboutput";
            this.tboutput.ReadOnly = true;
            this.tboutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboutput.Size = new System.Drawing.Size(1109, 231);
            this.tboutput.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Protoype_Auto_Correct.Properties.Resources._8W3JfzOpJiNZBnDYXHpQ3TGSMiZSG782uNXuAsrA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1136, 696);
            this.Controls.Add(this.tboutput);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnkoreksi);
            this.Controls.Add(this.tbinput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prototype Auto-Correct";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkoreksi;
        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tboutput;
    }
}

