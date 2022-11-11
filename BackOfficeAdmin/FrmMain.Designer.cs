namespace BackOfficeAdmin
{
    partial class FrmMain
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
            pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContainer.Location = new System.Drawing.Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new System.Drawing.Size(951, 505);
            pnlContainer.TabIndex = 6;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 505);
            this.Controls.Add(pnlContainer);
            this.MinimumSize = new System.Drawing.Size(967, 544);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackOffice";
            this.ResumeLayout(false);

        }

        #endregion

        private static System.Windows.Forms.Panel pnlContainer;
    }
}

