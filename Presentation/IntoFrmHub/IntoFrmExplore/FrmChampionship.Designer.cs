namespace Presentation.IntoFrmHub
{
    partial class FrmChampionship
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
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnMatchs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.lblChampionshipName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPositions
            // 
            this.btnPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositions.Location = new System.Drawing.Point(0, 150);
            this.btnPositions.Margin = new System.Windows.Forms.Padding(0);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(140, 130);
            this.btnPositions.TabIndex = 0;
            this.btnPositions.Text = "posiciones";
            this.btnPositions.UseVisualStyleBackColor = true;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // btnMatchs
            // 
            this.btnMatchs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchs.Location = new System.Drawing.Point(0, 20);
            this.btnMatchs.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatchs.Name = "btnMatchs";
            this.btnMatchs.Size = new System.Drawing.Size(140, 130);
            this.btnMatchs.TabIndex = 1;
            this.btnMatchs.Text = "partidos";
            this.btnMatchs.UseVisualStyleBackColor = true;
            this.btnMatchs.Click += new System.EventHandler(this.btnMatchs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMatchs);
            this.panel1.Controls.Add(this.btnPositions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 559);
            this.panel1.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(0, 459);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 100);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Volver";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDisplay.Location = new System.Drawing.Point(140, 50);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(960, 509);
            this.pnlDisplay.TabIndex = 3;
            // 
            // lblChampionshipName
            // 
            this.lblChampionshipName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChampionshipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChampionshipName.Location = new System.Drawing.Point(670, 8);
            this.lblChampionshipName.Name = "lblChampionshipName";
            this.lblChampionshipName.Size = new System.Drawing.Size(250, 35);
            this.lblChampionshipName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblChampionshipName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(140, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 50);
            this.panel2.TabIndex = 1;
            // 
            // FrmChampionship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChampionship";
            this.Text = "FrmChampionship";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnMatchs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblChampionshipName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
    }
}