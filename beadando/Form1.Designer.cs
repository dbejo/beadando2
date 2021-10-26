
namespace beadando
{
    partial class Form_Szoveg
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
            this.button1_Switch = new System.Windows.Forms.Button();
            this.button1_Szamol = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Ekezetek = new System.Windows.Forms.Label();
            this.lbl_Irasjel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_Switch
            // 
            this.button1_Switch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Switch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1_Switch.Location = new System.Drawing.Point(0, 0);
            this.button1_Switch.Name = "button1_Switch";
            this.button1_Switch.Size = new System.Drawing.Size(150, 50);
            this.button1_Switch.TabIndex = 0;
            this.button1_Switch.Text = "Mátrixok";
            this.button1_Switch.UseVisualStyleBackColor = false;
            this.button1_Switch.Click += new System.EventHandler(this.button1_Switch_Click);
            // 
            // button1_Szamol
            // 
            this.button1_Szamol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_Szamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Szamol.ForeColor = System.Drawing.Color.Firebrick;
            this.button1_Szamol.Location = new System.Drawing.Point(150, 0);
            this.button1_Szamol.Name = "button1_Szamol";
            this.button1_Szamol.Size = new System.Drawing.Size(150, 50);
            this.button1_Szamol.TabIndex = 1;
            this.button1_Szamol.Text = "Számol";
            this.button1_Szamol.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 57);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 300);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // lbl_Ekezetek
            // 
            this.lbl_Ekezetek.AutoSize = true;
            this.lbl_Ekezetek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Ekezetek.Location = new System.Drawing.Point(12, 360);
            this.lbl_Ekezetek.Name = "lbl_Ekezetek";
            this.lbl_Ekezetek.Size = new System.Drawing.Size(467, 29);
            this.lbl_Ekezetek.TabIndex = 3;
            this.lbl_Ekezetek.Text = "A szövegben 0 ékezetes karakter található.";
            // 
            // lbl_Irasjel
            // 
            this.lbl_Irasjel.AutoSize = true;
            this.lbl_Irasjel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Irasjel.Location = new System.Drawing.Point(12, 389);
            this.lbl_Irasjel.Name = "lbl_Irasjel";
            this.lbl_Irasjel.Size = new System.Drawing.Size(421, 29);
            this.lbl_Irasjel.TabIndex = 4;
            this.lbl_Irasjel.Text = "A szövegben nincs mondatvégi írásjel.";
            // 
            // Form_Szoveg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Irasjel);
            this.Controls.Add(this.lbl_Ekezetek);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1_Szamol);
            this.Controls.Add(this.button1_Switch);
            this.Name = "Form_Szoveg";
            this.Text = "Szöveg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Switch;
        private System.Windows.Forms.Button button1_Szamol;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Ekezetek;
        private System.Windows.Forms.Label lbl_Irasjel;
    }
}

