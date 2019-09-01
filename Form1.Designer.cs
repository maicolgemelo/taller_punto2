namespace taller_punto2
{
    partial class Form1
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
            this.lblprecio = new System.Windows.Forms.Label();
            this.btncalculo = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lbliva = new System.Windows.Forms.Label();
            this.lblprecioiva = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblpreciototal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(216, 79);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(120, 22);
            this.lblprecio.TabIndex = 0;
            this.lblprecio.Text = "precio producto: ";
            // 
            // btncalculo
            // 
            this.btncalculo.Location = new System.Drawing.Point(481, 79);
            this.btncalculo.Name = "btncalculo";
            this.btncalculo.Size = new System.Drawing.Size(75, 23);
            this.btncalculo.TabIndex = 1;
            this.btncalculo.Text = "Calculo";
            this.btncalculo.UseVisualStyleBackColor = true;
            this.btncalculo.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(342, 81);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(116, 20);
            this.txtprecio.TabIndex = 2;
            // 
            // lbliva
            // 
            this.lbliva.AutoSize = true;
            this.lbliva.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliva.Location = new System.Drawing.Point(251, 175);
            this.lbliva.Name = "lbliva";
            this.lbliva.Size = new System.Drawing.Size(36, 22);
            this.lbliva.TabIndex = 3;
            this.lbliva.Text = "Iva :";
            // 
            // lblprecioiva
            // 
            this.lblprecioiva.AutoSize = true;
            this.lblprecioiva.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecioiva.Location = new System.Drawing.Point(339, 175);
            this.lblprecioiva.Name = "lblprecioiva";
            this.lblprecioiva.Size = new System.Drawing.Size(68, 22);
            this.lblprecioiva.TabIndex = 4;
            this.lblprecioiva.Text = "precioiva";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(251, 255);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(54, 22);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total : ";
            // 
            // lblpreciototal
            // 
            this.lblpreciototal.AutoSize = true;
            this.lblpreciototal.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreciototal.Location = new System.Drawing.Point(339, 255);
            this.lblpreciototal.Name = "lblpreciototal";
            this.lblpreciototal.Size = new System.Drawing.Size(80, 22);
            this.lblpreciototal.TabIndex = 6;
            this.lblpreciototal.Text = "Preciototal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblpreciototal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblprecioiva);
            this.Controls.Add(this.lbliva);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.btncalculo);
            this.Controls.Add(this.lblprecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Button btncalculo;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lbliva;
        private System.Windows.Forms.Label lblprecioiva;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblpreciototal;
    }
}

