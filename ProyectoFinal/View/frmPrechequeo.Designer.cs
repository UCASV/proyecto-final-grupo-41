
namespace ProyectoFinal
{
    partial class frmPrechequeo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrechequeo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPaso2 = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnHacerCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(157, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO/A";
            // 
            // btnPaso2
            // 
            this.btnPaso2.Location = new System.Drawing.Point(52, 195);
            this.btnPaso2.Name = "btnPaso2";
            this.btnPaso2.Size = new System.Drawing.Size(114, 68);
            this.btnPaso2.TabIndex = 1;
            this.btnPaso2.Text = "Ya tengo una cita";
            this.btnPaso2.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(358, 195);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(114, 68);
            this.btnRegistrarse.TabIndex = 2;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnHacerCita
            // 
            this.btnHacerCita.Location = new System.Drawing.Point(205, 195);
            this.btnHacerCita.Name = "btnHacerCita";
            this.btnHacerCita.Size = new System.Drawing.Size(114, 68);
            this.btnHacerCita.TabIndex = 3;
            this.btnHacerCita.Text = "Agendar cita";
            this.btnHacerCita.UseVisualStyleBackColor = true;
            this.btnHacerCita.Click += new System.EventHandler(this.btnHacerCita_Click);
            // 
            // frmPrechequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(68)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(530, 375);
            this.Controls.Add(this.btnHacerCita);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnPaso2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrechequeo";
            this.Text = "Prechequeo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrechequeo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaso2;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnHacerCita;
    }
}

