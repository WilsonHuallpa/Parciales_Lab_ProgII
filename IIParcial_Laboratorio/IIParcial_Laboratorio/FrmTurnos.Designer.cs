namespace IIParcial_Laboratorio
{
    partial class FrmTurnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurnos));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list_Preparacion = new System.Windows.Forms.ListBox();
            this.list_Entregados = new System.Windows.Forms.ListBox();
            this.lbPedidosActuales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnAgregar.Location = new System.Drawing.Point(337, 414);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(260, 42);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pedidos en Preparacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(586, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pedidos Entregados";
            // 
            // list_Preparacion
            // 
            this.list_Preparacion.BackColor = System.Drawing.Color.MistyRose;
            this.list_Preparacion.FormattingEnabled = true;
            this.list_Preparacion.Location = new System.Drawing.Point(72, 60);
            this.list_Preparacion.Name = "list_Preparacion";
            this.list_Preparacion.Size = new System.Drawing.Size(384, 303);
            this.list_Preparacion.TabIndex = 5;
            // 
            // list_Entregados
            // 
            this.list_Entregados.BackColor = System.Drawing.Color.MistyRose;
            this.list_Entregados.FormattingEnabled = true;
            this.list_Entregados.Location = new System.Drawing.Point(500, 60);
            this.list_Entregados.Name = "list_Entregados";
            this.list_Entregados.Size = new System.Drawing.Size(401, 303);
            this.list_Entregados.TabIndex = 6;
            // 
            // lbPedidosActuales
            // 
            this.lbPedidosActuales.AutoSize = true;
            this.lbPedidosActuales.BackColor = System.Drawing.Color.Goldenrod;
            this.lbPedidosActuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPedidosActuales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPedidosActuales.Location = new System.Drawing.Point(69, 366);
            this.lbPedidosActuales.Name = "lbPedidosActuales";
            this.lbPedidosActuales.Size = new System.Drawing.Size(0, 29);
            this.lbPedidosActuales.TabIndex = 7;
            // 
            // FrmTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(976, 496);
            this.Controls.Add(this.lbPedidosActuales);
            this.Controls.Add(this.list_Entregados);
            this.Controls.Add(this.list_Preparacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTurnos";
            this.Text = "Tablero de Pedidos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTurnos_FormClosing);
            this.Load += new System.EventHandler(this.FrmTurnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox list_Preparacion;
        private System.Windows.Forms.ListBox list_Entregados;
        private System.Windows.Forms.Label lbPedidosActuales;
    }
}

