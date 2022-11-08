namespace Login
{
    partial class FrmImportar
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
            this.dgvCSV = new System.Windows.Forms.DataGridView();
            this.btnImportarArchivo = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCSV
            // 
            this.dgvCSV.AllowUserToAddRows = false;
            this.dgvCSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSV.Location = new System.Drawing.Point(12, 12);
            this.dgvCSV.Name = "dgvCSV";
            this.dgvCSV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCSV.RowTemplate.Height = 25;
            this.dgvCSV.Size = new System.Drawing.Size(625, 426);
            this.dgvCSV.TabIndex = 0;
            // 
            // btnImportarArchivo
            // 
            this.btnImportarArchivo.Location = new System.Drawing.Point(643, 63);
            this.btnImportarArchivo.Name = "btnImportarArchivo";
            this.btnImportarArchivo.Size = new System.Drawing.Size(145, 23);
            this.btnImportarArchivo.TabIndex = 1;
            this.btnImportarArchivo.Text = "Importar Archivo CSV";
            this.btnImportarArchivo.UseVisualStyleBackColor = true;
            this.btnImportarArchivo.Click += new System.EventHandler(this.BtnImportarArchivo_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(674, 142);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnImportarArchivo);
            this.Controls.Add(this.dgvCSV);
            this.Name = "frmImportar";
            this.Text = "frmImportar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvCSV;
        private Button btnImportarArchivo;
        private Button btnExport;
    }
}