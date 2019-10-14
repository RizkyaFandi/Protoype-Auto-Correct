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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnGenerateJarak1 = new System.Windows.Forms.Button();
            this.btnGenerateJarak2 = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 13);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(299, 26);
            this.tbInput.TabIndex = 0;
            // 
            // btnGenerateJarak1
            // 
            this.btnGenerateJarak1.Location = new System.Drawing.Point(12, 47);
            this.btnGenerateJarak1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateJarak1.Name = "btnGenerateJarak1";
            this.btnGenerateJarak1.Size = new System.Drawing.Size(145, 29);
            this.btnGenerateJarak1.TabIndex = 1;
            this.btnGenerateJarak1.Text = "Generate Jarak 1";
            this.btnGenerateJarak1.UseVisualStyleBackColor = true;
            this.btnGenerateJarak1.Click += new System.EventHandler(this.btnGenerateJarak1_Click);
            // 
            // btnGenerateJarak2
            // 
            this.btnGenerateJarak2.Location = new System.Drawing.Point(166, 47);
            this.btnGenerateJarak2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateJarak2.Name = "btnGenerateJarak2";
            this.btnGenerateJarak2.Size = new System.Drawing.Size(145, 29);
            this.btnGenerateJarak2.TabIndex = 3;
            this.btnGenerateJarak2.Text = "Generate Jarak 2";
            this.btnGenerateJarak2.UseVisualStyleBackColor = true;
            this.btnGenerateJarak2.Click += new System.EventHandler(this.btnGenerateJarak2_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 92);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1045, 536);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "Selamat datang di Prototype Auto-Correct.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 640);
            this.Controls.Add(this.btnGenerateJarak2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnGenerateJarak1);
            this.Controls.Add(this.tbInput);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Prototype Auto-Correct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnGenerateJarak1;
        private System.Windows.Forms.Button btnGenerateJarak2;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}

