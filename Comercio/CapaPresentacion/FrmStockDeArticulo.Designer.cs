namespace CapaPresentacion
{
    partial class FrmStockDeArticulo
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
            this.dgvListaProducto = new System.Windows.Forms.DataGridView();
            this.btnListaProducto = new System.Windows.Forms.Button();
            this.btnMenorde10 = new System.Windows.Forms.Button();
            this.lbVolverMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProducto
            // 
            this.dgvListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProducto.Location = new System.Drawing.Point(36, 116);
            this.dgvListaProducto.Name = "dgvListaProducto";
            this.dgvListaProducto.ReadOnly = true;
            this.dgvListaProducto.Size = new System.Drawing.Size(865, 322);
            this.dgvListaProducto.TabIndex = 0;
            // 
            // btnListaProducto
            // 
            this.btnListaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaProducto.Location = new System.Drawing.Point(36, 63);
            this.btnListaProducto.Name = "btnListaProducto";
            this.btnListaProducto.Size = new System.Drawing.Size(262, 30);
            this.btnListaProducto.TabIndex = 1;
            this.btnListaProducto.Text = "Lista de Producto";
            this.btnListaProducto.UseVisualStyleBackColor = true;
            this.btnListaProducto.Click += new System.EventHandler(this.btnListaProducto_Click);
            // 
            // btnMenorde10
            // 
            this.btnMenorde10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorde10.Location = new System.Drawing.Point(639, 63);
            this.btnMenorde10.Name = "btnMenorde10";
            this.btnMenorde10.Size = new System.Drawing.Size(262, 30);
            this.btnMenorde10.TabIndex = 2;
            this.btnMenorde10.Text = "Menor de 10 Unidades";
            this.btnMenorde10.UseVisualStyleBackColor = true;
            this.btnMenorde10.Click += new System.EventHandler(this.btnMenorde10_Click);
            // 
            // lbVolverMenu
            // 
            this.lbVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVolverMenu.Location = new System.Drawing.Point(326, 468);
            this.lbVolverMenu.Name = "lbVolverMenu";
            this.lbVolverMenu.Size = new System.Drawing.Size(262, 30);
            this.lbVolverMenu.TabIndex = 3;
            this.lbVolverMenu.Text = "Volver al menu";
            this.lbVolverMenu.UseVisualStyleBackColor = true;
            this.lbVolverMenu.Click += new System.EventHandler(this.lbVolverMenu_Click);
            // 
            // FrmStockDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(946, 546);
            this.Controls.Add(this.lbVolverMenu);
            this.Controls.Add(this.btnMenorde10);
            this.Controls.Add(this.btnListaProducto);
            this.Controls.Add(this.dgvListaProducto);
            this.Name = "FrmStockDeArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProducto;
        private System.Windows.Forms.Button btnListaProducto;
        private System.Windows.Forms.Button btnMenorde10;
        private System.Windows.Forms.Button lbVolverMenu;
    }
}