namespace Presentation.IntoFrmHub
{
    partial class FrmHub
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
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSoccer = new System.Windows.Forms.Button();
            this.pnlSelectDeport = new System.Windows.Forms.Panel();
            this.btnHandball = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnVolley = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFavorites
            // 
            this.btnFavorites.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFavorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorites.Location = new System.Drawing.Point(520, 0);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(200, 60);
            this.btnFavorites.TabIndex = 2;
            this.btnFavorites.Text = "Favoritos";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(260, 0);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 60);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Busqueda";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnExplore_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.label1);
            this.pnlTabs.Controls.Add(this.btnHome);
            this.pnlTabs.Controls.Add(this.btnFavorites);
            this.pnlTabs.Controls.Add(this.btnSearch);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1100, 60);
            this.pnlTabs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1009, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "btnConfig";
            // 
            // btnSoccer
            // 
            this.btnSoccer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoccer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoccer.Location = new System.Drawing.Point(0, 0);
            this.btnSoccer.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoccer.Name = "btnSoccer";
            this.btnSoccer.Size = new System.Drawing.Size(140, 33);
            this.btnSoccer.TabIndex = 5;
            this.btnSoccer.Text = "Soccer";
            this.btnSoccer.UseVisualStyleBackColor = true;
            this.btnSoccer.Click += new System.EventHandler(this.btnDeport_Click);
            // 
            // pnlSelectDeport
            // 
            this.pnlSelectDeport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectDeport.Location = new System.Drawing.Point(780, 16);
            this.pnlSelectDeport.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSelectDeport.Name = "pnlSelectDeport";
            this.pnlSelectDeport.Size = new System.Drawing.Size(140, 33);
            this.pnlSelectDeport.TabIndex = 4;
            // 
            // btnHandball
            // 
            this.btnHandball.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandball.Location = new System.Drawing.Point(0, 0);
            this.btnHandball.Margin = new System.Windows.Forms.Padding(0);
            this.btnHandball.Name = "btnHandball";
            this.btnHandball.Size = new System.Drawing.Size(140, 33);
            this.btnHandball.TabIndex = 9;
            this.btnHandball.Text = "Handball";
            this.btnHandball.UseVisualStyleBackColor = true;
            this.btnHandball.Click += new System.EventHandler(this.btnDeport_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasket.Location = new System.Drawing.Point(0, 0);
            this.btnBasket.Margin = new System.Windows.Forms.Padding(0);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(140, 33);
            this.btnBasket.TabIndex = 6;
            this.btnBasket.Text = "Basketball";
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnDeport_Click);
            // 
            // btnVolley
            // 
            this.btnVolley.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolley.Location = new System.Drawing.Point(0, 0);
            this.btnVolley.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolley.Name = "btnVolley";
            this.btnVolley.Size = new System.Drawing.Size(140, 33);
            this.btnVolley.TabIndex = 8;
            this.btnVolley.Text = "Volleyball";
            this.btnVolley.UseVisualStyleBackColor = true;
            this.btnVolley.Click += new System.EventHandler(this.btnDeport_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTennis.Location = new System.Drawing.Point(0, 0);
            this.btnTennis.Margin = new System.Windows.Forms.Padding(0);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(140, 33);
            this.btnTennis.TabIndex = 7;
            this.btnTennis.Text = "Tennis";
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnDeport_Click);
            // 
            // FrmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.pnlSelectDeport);
            this.Controls.Add(this.pnlTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHub";
            this.Text = "FrmHub";
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoccer;
        private System.Windows.Forms.Panel pnlSelectDeport;
        private System.Windows.Forms.Button btnBasket;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Button btnVolley;
        private System.Windows.Forms.Button btnHandball;
    }
}