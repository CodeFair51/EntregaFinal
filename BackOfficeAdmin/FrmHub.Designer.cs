namespace BackOfficeAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSinglePlayerMan = new System.Windows.Forms.Button();
            this.btnTeamPlayerMan = new System.Windows.Forms.Button();
            this.btnMatchChampionshipMan = new System.Windows.Forms.Button();
            this.btnTeamMan = new System.Windows.Forms.Button();
            this.btnSingleMatchMan = new System.Windows.Forms.Button();
            this.btnTeamMatchMan = new System.Windows.Forms.Button();
            this.btnChampionshipMan = new System.Windows.Forms.Button();
            this.btnBannerMan = new System.Windows.Forms.Button();
            this.btnClientMan = new System.Windows.Forms.Button();
            this.btnAdminMan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnSinglePlayerMan);
            this.panel1.Controls.Add(this.btnTeamPlayerMan);
            this.panel1.Controls.Add(this.btnMatchChampionshipMan);
            this.panel1.Controls.Add(this.btnTeamMan);
            this.panel1.Controls.Add(this.btnSingleMatchMan);
            this.panel1.Controls.Add(this.btnTeamMatchMan);
            this.panel1.Controls.Add(this.btnChampionshipMan);
            this.panel1.Controls.Add(this.btnBannerMan);
            this.panel1.Controls.Add(this.btnClientMan);
            this.panel1.Controls.Add(this.btnAdminMan);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 0;
            // 
            // btnSinglePlayerMan
            // 
            this.btnSinglePlayerMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayerMan.Location = new System.Drawing.Point(898, 0);
            this.btnSinglePlayerMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSinglePlayerMan.Name = "btnSinglePlayerMan";
            this.btnSinglePlayerMan.Size = new System.Drawing.Size(101, 50);
            this.btnSinglePlayerMan.TabIndex = 9;
            this.btnSinglePlayerMan.Text = "Gestion de Jugadores Individuales";
            this.btnSinglePlayerMan.UseVisualStyleBackColor = true;
            this.btnSinglePlayerMan.Click += new System.EventHandler(this.btnSinglePlayerMan_Click);
            // 
            // btnTeamPlayerMan
            // 
            this.btnTeamPlayerMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamPlayerMan.Location = new System.Drawing.Point(799, 0);
            this.btnTeamPlayerMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeamPlayerMan.Name = "btnTeamPlayerMan";
            this.btnTeamPlayerMan.Size = new System.Drawing.Size(100, 50);
            this.btnTeamPlayerMan.TabIndex = 8;
            this.btnTeamPlayerMan.Text = "Gestion de Jugadores Equipo";
            this.btnTeamPlayerMan.UseVisualStyleBackColor = true;
            this.btnTeamPlayerMan.Click += new System.EventHandler(this.btnTeamPlayerMan_Click);
            // 
            // btnMatchChampionshipMan
            // 
            this.btnMatchChampionshipMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchChampionshipMan.Location = new System.Drawing.Point(699, 0);
            this.btnMatchChampionshipMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnMatchChampionshipMan.Name = "btnMatchChampionshipMan";
            this.btnMatchChampionshipMan.Size = new System.Drawing.Size(101, 50);
            this.btnMatchChampionshipMan.TabIndex = 7;
            this.btnMatchChampionshipMan.Text = "Gestion de Partidos en Campeonato";
            this.btnMatchChampionshipMan.UseVisualStyleBackColor = true;
            this.btnMatchChampionshipMan.Click += new System.EventHandler(this.btnMatchChampionshipMan_Click);
            // 
            // btnTeamMan
            // 
            this.btnTeamMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamMan.Location = new System.Drawing.Point(599, 0);
            this.btnTeamMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeamMan.Name = "btnTeamMan";
            this.btnTeamMan.Size = new System.Drawing.Size(101, 50);
            this.btnTeamMan.TabIndex = 6;
            this.btnTeamMan.Text = "Gestion de Equipos";
            this.btnTeamMan.UseVisualStyleBackColor = true;
            this.btnTeamMan.Click += new System.EventHandler(this.btnTeamMan_Click);
            // 
            // btnSingleMatchMan
            // 
            this.btnSingleMatchMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingleMatchMan.Location = new System.Drawing.Point(499, 0);
            this.btnSingleMatchMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnSingleMatchMan.Name = "btnSingleMatchMan";
            this.btnSingleMatchMan.Size = new System.Drawing.Size(101, 50);
            this.btnSingleMatchMan.TabIndex = 5;
            this.btnSingleMatchMan.Text = "Gestion de Partidos Individuales";
            this.btnSingleMatchMan.UseVisualStyleBackColor = true;
            this.btnSingleMatchMan.Click += new System.EventHandler(this.btnSingleMatchMan_Click);
            // 
            // btnTeamMatchMan
            // 
            this.btnTeamMatchMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeamMatchMan.Location = new System.Drawing.Point(399, 0);
            this.btnTeamMatchMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeamMatchMan.Name = "btnTeamMatchMan";
            this.btnTeamMatchMan.Size = new System.Drawing.Size(101, 50);
            this.btnTeamMatchMan.TabIndex = 4;
            this.btnTeamMatchMan.Text = "Gestion de Partidos Equipo";
            this.btnTeamMatchMan.UseVisualStyleBackColor = true;
            this.btnTeamMatchMan.Click += new System.EventHandler(this.btnTeamMatchMan_Click);
            // 
            // btnChampionshipMan
            // 
            this.btnChampionshipMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChampionshipMan.Location = new System.Drawing.Point(299, 0);
            this.btnChampionshipMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnChampionshipMan.Name = "btnChampionshipMan";
            this.btnChampionshipMan.Size = new System.Drawing.Size(101, 50);
            this.btnChampionshipMan.TabIndex = 3;
            this.btnChampionshipMan.Text = "Gestion de Campeonatos";
            this.btnChampionshipMan.UseVisualStyleBackColor = true;
            this.btnChampionshipMan.Click += new System.EventHandler(this.btnChampionshipMan_Click);
            // 
            // btnBannerMan
            // 
            this.btnBannerMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBannerMan.Location = new System.Drawing.Point(199, 0);
            this.btnBannerMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnBannerMan.Name = "btnBannerMan";
            this.btnBannerMan.Size = new System.Drawing.Size(101, 50);
            this.btnBannerMan.TabIndex = 2;
            this.btnBannerMan.Text = "Gestion de Banners";
            this.btnBannerMan.UseVisualStyleBackColor = true;
            this.btnBannerMan.Click += new System.EventHandler(this.btnBannerMan_Click);
            // 
            // btnClientMan
            // 
            this.btnClientMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientMan.Location = new System.Drawing.Point(99, 0);
            this.btnClientMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientMan.Name = "btnClientMan";
            this.btnClientMan.Size = new System.Drawing.Size(101, 50);
            this.btnClientMan.TabIndex = 1;
            this.btnClientMan.Text = "Gestion de Clientes";
            this.btnClientMan.UseVisualStyleBackColor = true;
            this.btnClientMan.Click += new System.EventHandler(this.btnUserMan_Click);
            // 
            // btnAdminMan
            // 
            this.btnAdminMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMan.Location = new System.Drawing.Point(0, 0);
            this.btnAdminMan.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdminMan.Name = "btnAdminMan";
            this.btnAdminMan.Size = new System.Drawing.Size(100, 50);
            this.btnAdminMan.TabIndex = 0;
            this.btnAdminMan.Text = "Gestion de Admins";
            this.btnAdminMan.UseVisualStyleBackColor = true;
            this.btnAdminMan.Click += new System.EventHandler(this.btnAdminMan_Click);
            // 
            // FrmHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHub";
            this.Text = "FrmInicio";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminMan;
        private System.Windows.Forms.Button btnClientMan;
        private System.Windows.Forms.Button btnChampionshipMan;
        private System.Windows.Forms.Button btnBannerMan;
        private System.Windows.Forms.Button btnSingleMatchMan;
        private System.Windows.Forms.Button btnTeamMatchMan;
        private System.Windows.Forms.Button btnTeamMan;
        private System.Windows.Forms.Button btnMatchChampionshipMan;
        private System.Windows.Forms.Button btnTeamPlayerMan;
        private System.Windows.Forms.Button btnSinglePlayerMan;
    }
}