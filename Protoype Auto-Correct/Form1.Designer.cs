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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnKoreksiTeks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(1045, 26);
            this.tbInput.TabIndex = 0;
            // 
            // btnGenerateJarak1
            // 
            this.btnGenerateJarak1.Location = new System.Drawing.Point(12, 48);
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
            this.btnGenerateJarak2.Location = new System.Drawing.Point(166, 48);
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
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1045, 536);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "Selamat datang di Prototype Auto-Correct.";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(318, 48);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Kandidat Koreksi";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnKoreksiTeks
            // 
            this.btnKoreksiTeks.Location = new System.Drawing.Point(469, 48);
            this.btnKoreksiTeks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKoreksiTeks.Name = "btnKoreksiTeks";
            this.btnKoreksiTeks.Size = new System.Drawing.Size(145, 29);
            this.btnKoreksiTeks.TabIndex = 5;
            this.btnKoreksiTeks.Text = "Koreksi Teks";
            this.btnKoreksiTeks.UseVisualStyleBackColor = true;
            this.btnKoreksiTeks.Click += new System.EventHandler(this.btnKoreksiTeks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 640);
            this.Controls.Add(this.btnKoreksiTeks);
            this.Controls.Add(this.btnSearch);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnKoreksiTeks;
    }
}

