
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
            // Form_Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_Szamol);
            this.Controls.Add(this.button2_Switch);
            this.Name = "Form_Matrix";
            this.Text = "Mátrixok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2_Szamol;
        private System.Windows.Forms.Button button2_Switch;
    }
}