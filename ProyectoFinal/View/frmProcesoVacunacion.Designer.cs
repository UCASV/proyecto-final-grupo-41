
namespace ProyectoFinal.View
{
    partial class frmProcesoVacunacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesoVacunacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFechaEspera = new System.Windows.Forms.TextBox();
            this.txtHoraEspera = new System.Windows.Forms.TextBox();
            this.txtFechaVacunacion = new System.Windows.Forms.TextBox();
            this.txtHoraVacunacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbVacunador = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEfecto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de espera:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de espera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de vacunacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora de vacunacion:";
            // 
            // txtFechaEspera
            // 
            this.txtFechaEspera.Location = new System.Drawing.Point(218, 68);
            this.txtFechaEspera.Name = "txtFechaEspera";
            this.txtFechaEspera.Size = new System.Drawing.Size(203, 23);
            this.txtFechaEspera.TabIndex = 4;
            // 
            // txtHoraEspera
            // 
            this.txtHoraEspera.Location = new System.Drawing.Point(218, 106);
            this.txtHoraEspera.Name = "txtHoraEspera";
            this.txtHoraEspera.Size = new System.Drawing.Size(203, 23);
            this.txtHoraEspera.TabIndex = 5;
            // 
            // txtFechaVacunacion
            // 
            this.txtFechaVacunacion.Location = new System.Drawing.Point(218, 140);
            this.txtFechaVacunacion.Name = "txtFechaVacunacion";
            this.txtFechaVacunacion.Size = new System.Drawing.Size(203, 23);
            this.txtFechaVacunacion.TabIndex = 6;
            // 
            // txtHoraVacunacion
            // 
            this.txtHoraVacunacion.Location = new System.Drawing.Point(218, 174);
            this.txtHoraVacunacion.Name = "txtHoraVacunacion";
            this.txtHoraVacunacion.Size = new System.Drawing.Size(203, 23);
            this.txtHoraVacunacion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "DUI:";
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(218, 34);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(203, 23);
            this.txtDUI.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(255, 301);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 50);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(102, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(105, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Vacunador:";
            // 
            // cmbVacunador
            // 
            this.cmbVacunador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacunador.FormattingEnabled = true;
            this.cmbVacunador.Location = new System.Drawing.Point(218, 209);
            this.cmbVacunador.Name = "cmbVacunador";
            this.cmbVacunador.Size = new System.Drawing.Size(203, 23);
            this.cmbVacunador.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(46, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Efecto secundario:";
            // 
            // cmbEfecto
            // 
            this.cmbEfecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEfecto.FormattingEnabled = true;
            this.cmbEfecto.Location = new System.Drawing.Point(218, 243);
            this.cmbEfecto.Name = "cmbEfecto";
            this.cmbEfecto.Size = new System.Drawing.Size(203, 23);
            this.cmbEfecto.TabIndex = 15;
            // 
            // frmProcesoVacunacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(457, 382);
            this.Controls.Add(this.cmbEfecto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVacunador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoraVacunacion);
            this.Controls.Add(this.txtFechaVacunacion);
            this.Controls.Add(this.txtHoraEspera);
            this.Controls.Add(this.txtFechaEspera);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProcesoVacunacion";
            this.Text = "Proceso de vacunacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProcesoVacunacion_FormClosing);
            this.Load += new System.EventHandler(this.frmProcesoVacunacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFechaEspera;
        private System.Windows.Forms.TextBox txtHoraEspera;
        private System.Windows.Forms.TextBox txtFechaVacunacion;
        private System.Windows.Forms.TextBox txtHoraVacunacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVacunador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEfecto;
    }
}