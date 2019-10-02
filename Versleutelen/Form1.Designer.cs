namespace Versleutelen
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
            this.Bestand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Versleutel = new System.Windows.Forms.Button();
            this.Ontsleutel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bestand
            // 
            this.Bestand.Location = new System.Drawing.Point(12, 12);
            this.Bestand.Name = "Bestand";
            this.Bestand.Size = new System.Drawing.Size(67, 23);
            this.Bestand.TabIndex = 0;
            this.Bestand.Text = "Bestand";
            this.Bestand.UseVisualStyleBackColor = true;
            this.Bestand.Click += new System.EventHandler(this.Bestand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Versleutel
            // 
            this.Versleutel.Location = new System.Drawing.Point(12, 42);
            this.Versleutel.Name = "Versleutel";
            this.Versleutel.Size = new System.Drawing.Size(67, 23);
            this.Versleutel.TabIndex = 2;
            this.Versleutel.Text = "Versleutel";
            this.Versleutel.UseVisualStyleBackColor = true;
            this.Versleutel.Click += new System.EventHandler(this.Versleutel_Click);
            // 
            // Ontsleutel
            // 
            this.Ontsleutel.Location = new System.Drawing.Point(12, 72);
            this.Ontsleutel.Name = "Ontsleutel";
            this.Ontsleutel.Size = new System.Drawing.Size(67, 23);
            this.Ontsleutel.TabIndex = 3;
            this.Ontsleutel.Text = "Ontsleutel";
            this.Ontsleutel.UseVisualStyleBackColor = true;
            this.Ontsleutel.Click += new System.EventHandler(this.Ontsleutel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 116);
            this.Controls.Add(this.Ontsleutel);
            this.Controls.Add(this.Versleutel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bestand);
            this.Name = "Form1";
            this.Text = "Tekst Versleutelen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bestand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Versleutel;
        private System.Windows.Forms.Button Ontsleutel;
    }
}

