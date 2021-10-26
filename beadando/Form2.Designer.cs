
namespace beadando
{
    partial class Form_Matrix
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
            this.button2_Szamol = new System.Windows.Forms.Button();
            this.button2_Switch = new System.Windows.Forms.Button();
            this.lbl_Oszlopok = new System.Windows.Forms.Label();
            this.numericUpDown_oszlopok = new System.Windows.Forms.NumericUpDown();
            this.lbl_Oszlop1 = new System.Windows.Forms.Label();
            this.lbl_Oszlop2 = new System.Windows.Forms.Label();
            this.lbl_Oszlop3 = new System.Windows.Forms.Label();
            this.lbl_Oszlop4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_oszlopok)).BeginInit();
            this.SuspendLayout();
            // 
            // button2_Szamol
            // 
            this.button2_Szamol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_Szamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2_Szamol.ForeColor = System.Drawing.Color.Firebrick;
            this.button2_Szamol.Location = new System.Drawing.Point(150, 0);
            this.button2_Szamol.Name = "button2_Szamol";
            this.button2_Szamol.Size = new System.Drawing.Size(150, 50);
            this.button2_Szamol.TabIndex = 3;
            this.button2_Szamol.Text = "Számol";
            this.button2_Szamol.UseVisualStyleBackColor = false;
            this.button2_Szamol.Click += new System.EventHandler(this.button2_Szamol_Click);
            // 
            // button2_Switch
            // 
            this.button2_Switch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2_Switch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2_Switch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2_Switch.Location = new System.Drawing.Point(0, 0);
            this.button2_Switch.Name = "button2_Switch";
            this.button2_Switch.Size = new System.Drawing.Size(150, 50);
            this.button2_Switch.TabIndex = 2;
            this.button2_Switch.Text = "Szöveg";
            this.button2_Switch.UseVisualStyleBackColor = false;
            this.button2_Switch.Click += new System.EventHandler(this.button1_Switch_Click);
            // 
            // lbl_Oszlopok
            // 
            this.lbl_Oszlopok.AutoSize = true;
            this.lbl_Oszlopok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Oszlopok.Location = new System.Drawing.Point(13, 57);
            this.lbl_Oszlopok.Name = "lbl_Oszlopok";
            this.lbl_Oszlopok.Size = new System.Drawing.Size(190, 29);
            this.lbl_Oszlopok.TabIndex = 4;
            this.lbl_Oszlopok.Text = "Oszlopok száma";
            // 
            // numericUpDown_oszlopok
            // 
            this.numericUpDown_oszlopok.Location = new System.Drawing.Point(210, 59);
            this.numericUpDown_oszlopok.Name = "numericUpDown_oszlopok";
            this.numericUpDown_oszlopok.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_oszlopok.TabIndex = 5;
            // 
            // lbl_Oszlop1
            // 
            this.lbl_Oszlop1.AutoSize = true;
            this.lbl_Oszlop1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Oszlop1.Location = new System.Drawing.Point(13, 142);
            this.lbl_Oszlop1.Name = "lbl_Oszlop1";
            this.lbl_Oszlop1.Size = new System.Drawing.Size(124, 26);
            this.lbl_Oszlop1.TabIndex = 6;
            this.lbl_Oszlop1.Text = "Első oszlop";
            // 
            // lbl_Oszlop2
            // 
            this.lbl_Oszlop2.AutoSize = true;
            this.lbl_Oszlop2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Oszlop2.Location = new System.Drawing.Point(13, 217);
            this.lbl_Oszlop2.Name = "lbl_Oszlop2";
            this.lbl_Oszlop2.Size = new System.Drawing.Size(162, 26);
            this.lbl_Oszlop2.TabIndex = 7;
            this.lbl_Oszlop2.Text = "Második oszlop";
            // 
            // lbl_Oszlop3
            // 
            this.lbl_Oszlop3.AutoSize = true;
            this.lbl_Oszlop3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Oszlop3.Location = new System.Drawing.Point(13, 292);
            this.lbl_Oszlop3.Name = "lbl_Oszlop3";
            this.lbl_Oszlop3.Size = new System.Drawing.Size(175, 26);
            this.lbl_Oszlop3.TabIndex = 8;
            this.lbl_Oszlop3.Text = "Harmadik oszlop";
            // 
            // lbl_Oszlop4
            // 
            this.lbl_Oszlop4.AutoSize = true;
            this.lbl_Oszlop4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Oszlop4.Location = new System.Drawing.Point(13, 367);
            this.lbl_Oszlop4.Name = "lbl_Oszlop4";
            this.lbl_Oszlop4.Size = new System.Drawing.Size(172, 26);
            this.lbl_Oszlop4.TabIndex = 9;
            this.lbl_Oszlop4.Text = "Negyedik oszlop";
            // 
            // Form_Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Oszlop4);
            this.Controls.Add(this.lbl_Oszlop3);
            this.Controls.Add(this.lbl_Oszlop2);
            this.Controls.Add(this.lbl_Oszlop1);
            this.Controls.Add(this.numericUpDown_oszlopok);
            this.Controls.Add(this.lbl_Oszlopok);
            this.Controls.Add(this.button2_Szamol);
            this.Controls.Add(this.button2_Switch);
            this.Name = "Form_Matrix";
            this.Text = "Mátrixok";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_oszlopok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2_Szamol;
        private System.Windows.Forms.Button button2_Switch;
        private System.Windows.Forms.Label lbl_Oszlopok;
        private System.Windows.Forms.NumericUpDown numericUpDown_oszlopok;
        private System.Windows.Forms.Label lbl_Oszlop1;
        private System.Windows.Forms.Label lbl_Oszlop2;
        private System.Windows.Forms.Label lbl_Oszlop3;
        private System.Windows.Forms.Label lbl_Oszlop4;
    }
}