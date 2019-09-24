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
            this.key = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(169, 40);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(266, 22);
            this.key.TabIndex = 0;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(360, 106);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 1;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(12, 143);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(776, 305);
            this.hasil.TabIndex = 2;
            this.hasil.TabStop = false;
            this.hasil.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.key);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.GroupBox hasil;
    }
}

