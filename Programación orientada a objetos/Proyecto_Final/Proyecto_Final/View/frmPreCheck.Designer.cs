
namespace Proyecto_Final.View
{
    partial class frmPreCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreCheck));
            this.btnStartVaccProc = new System.Windows.Forms.Button();
            this.btnContinueVaccProcc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinishVaccProcc = new System.Windows.Forms.Button();
            this.tbcPreCheck = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCitizen = new System.Windows.Forms.TextBox();
            this.dgvSingleSearch = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tbcPreCheck.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleSearch)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartVaccProc
            // 
            this.btnStartVaccProc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartVaccProc.Location = new System.Drawing.Point(6, 6);
            this.btnStartVaccProc.Name = "btnStartVaccProc";
            this.btnStartVaccProc.Size = new System.Drawing.Size(146, 68);
            this.btnStartVaccProc.TabIndex = 0;
            this.btnStartVaccProc.Text = "Iniciar proceso de vacunacion";
            this.btnStartVaccProc.UseVisualStyleBackColor = true;
            this.btnStartVaccProc.Click += new System.EventHandler(this.btnStartVaccProc_Click);
            // 
            // btnContinueVaccProcc
            // 
            this.btnContinueVaccProcc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinueVaccProcc.Location = new System.Drawing.Point(6, 101);
            this.btnContinueVaccProcc.Name = "btnContinueVaccProcc";
            this.btnContinueVaccProcc.Size = new System.Drawing.Size(146, 68);
            this.btnContinueVaccProcc.TabIndex = 1;
            this.btnContinueVaccProcc.Text = "Continuar a primera dosis ";
            this.btnContinueVaccProcc.UseVisualStyleBackColor = true;
            this.btnContinueVaccProcc.Click += new System.EventHandler(this.btnContinueVaccProcc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // btnFinishVaccProcc
            // 
            this.btnFinishVaccProcc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinishVaccProcc.Location = new System.Drawing.Point(6, 193);
            this.btnFinishVaccProcc.Name = "btnFinishVaccProcc";
            this.btnFinishVaccProcc.Size = new System.Drawing.Size(146, 68);
            this.btnFinishVaccProcc.TabIndex = 3;
            this.btnFinishVaccProcc.Text = "Continuar a segunda dosis ";
            this.btnFinishVaccProcc.UseVisualStyleBackColor = true;
            this.btnFinishVaccProcc.Click += new System.EventHandler(this.btnFinishVaccProcc_Click);
            // 
            // tbcPreCheck
            // 
            this.tbcPreCheck.Controls.Add(this.tabPage1);
            this.tbcPreCheck.Controls.Add(this.tabPage2);
            this.tbcPreCheck.Controls.Add(this.tabPage3);
            this.tbcPreCheck.Location = new System.Drawing.Point(12, 37);
            this.tbcPreCheck.Name = "tbcPreCheck";
            this.tbcPreCheck.SelectedIndex = 0;
            this.tbcPreCheck.Size = new System.Drawing.Size(446, 295);
            this.tbcPreCheck.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Proyecto_Final.Properties.Resources.covid_19_vaccination_allocation_820x440;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.btnStartVaccProc);
            this.tabPage1.Controls.Add(this.btnFinishVaccProcc);
            this.tabPage1.Controls.Add(this.btnContinueVaccProcc);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvQueue);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQueue.Location = new System.Drawing.Point(3, 3);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.RowTemplate.Height = 25;
            this.dgvQueue.Size = new System.Drawing.Size(432, 261);
            this.dgvQueue.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSearch);
            this.tabPage3.Controls.Add(this.txtSearchCitizen);
            this.tabPage3.Controls.Add(this.dgvSingleSearch);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(438, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(357, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // txtSearchCitizen
            // 
            this.txtSearchCitizen.Location = new System.Drawing.Point(3, 6);
            this.txtSearchCitizen.Name = "txtSearchCitizen";
            this.txtSearchCitizen.PlaceholderText = "DUI de ciudadano";
            this.txtSearchCitizen.Size = new System.Drawing.Size(100, 23);
            this.txtSearchCitizen.TabIndex = 1;
            // 
            // dgvSingleSearch
            // 
            this.dgvSingleSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingleSearch.Location = new System.Drawing.Point(3, 35);
            this.dgvSingleSearch.Name = "dgvSingleSearch";
            this.dgvSingleSearch.RowTemplate.Height = 25;
            this.dgvSingleSearch.Size = new System.Drawing.Size(432, 229);
            this.dgvSingleSearch.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(121, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(341, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Proyecto_Final.Properties.Resources.table_chart_594428_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(106, 22);
            this.toolStripButton1.Text = "Ver estadisticas";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::Proyecto_Final.Properties.Resources._2048px_User_icon_2_svg;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(137, 22);
            this.toolStripButton2.Text = "Seguimiento de citas";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::Proyecto_Final.Properties.Resources.download;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(95, 22);
            this.toolStripButton3.Text = "Cerrar sesión";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // frmPreCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 344);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbcPreCheck);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreCheck";
            this.Text = "frmPreCheck";
            this.Load += new System.EventHandler(this.frmPreCheck_Load);
            this.tbcPreCheck.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingleSearch)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartVaccProc;
        private System.Windows.Forms.Button btnContinueVaccProcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinishVaccProcc;
        private System.Windows.Forms.TabControl tbcPreCheck;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCitizen;
        private System.Windows.Forms.DataGridView dgvSingleSearch;
    }
}