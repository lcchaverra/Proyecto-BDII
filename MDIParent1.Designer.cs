namespace ProyectoBDII
{
    partial class FormularioPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.AdmonInventario = new System.Windows.Forms.Button();
            this.Factura = new System.Windows.Forms.Button();
            this.Adminclient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(878, 49);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 49);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(878, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bienvenid@";
            // 
            // AdmonInventario
            // 
            this.AdmonInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdmonInventario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmonInventario.Image = ((System.Drawing.Image)(resources.GetObject("AdmonInventario.Image")));
            this.AdmonInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdmonInventario.Location = new System.Drawing.Point(256, 9);
            this.AdmonInventario.Name = "AdmonInventario";
            this.AdmonInventario.Size = new System.Drawing.Size(196, 33);
            this.AdmonInventario.TabIndex = 12;
            this.AdmonInventario.Text = "Admon Inventario.";
            this.AdmonInventario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdmonInventario.UseVisualStyleBackColor = true;
            this.AdmonInventario.Click += new System.EventHandler(this.AdmonMedi_Click);
            // 
            // Factura
            // 
            this.Factura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Factura.Image = ((System.Drawing.Image)(resources.GetObject("Factura.Image")));
            this.Factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Factura.Location = new System.Drawing.Point(458, 9);
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(189, 33);
            this.Factura.TabIndex = 10;
            this.Factura.Text = "Generar Factura";
            this.Factura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Factura.UseVisualStyleBackColor = true;
            this.Factura.Click += new System.EventHandler(this.Factura_Click);
            // 
            // Adminclient
            // 
            this.Adminclient.BackColor = System.Drawing.SystemColors.Control;
            this.Adminclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Adminclient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminclient.Image = ((System.Drawing.Image)(resources.GetObject("Adminclient.Image")));
            this.Adminclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminclient.Location = new System.Drawing.Point(67, 9);
            this.Adminclient.Name = "Adminclient";
            this.Adminclient.Size = new System.Drawing.Size(183, 33);
            this.Adminclient.TabIndex = 4;
            this.Adminclient.Text = "Admon Cliente.";
            this.Adminclient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Adminclient.UseVisualStyleBackColor = false;
            this.Adminclient.Click += new System.EventHandler(this.Adminclient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(553, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(648, 519);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 539);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AdmonInventario);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Adminclient);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormularioPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Adminclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Factura;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button AdmonInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}



