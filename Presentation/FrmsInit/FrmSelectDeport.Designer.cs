namespace Presentation.FrmsInit
{
    partial class FrmSelectDeport
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
            this.btnSoccer = new System.Windows.Forms.Button();
            this.btnBasket = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.btnVolley = new System.Windows.Forms.Button();
            this.btnHandball = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHandball);
            this.panel1.Controls.Add(this.btnVolley);
            this.panel1.Controls.Add(this.btnTennis);
            this.panel1.Controls.Add(this.btnBasket);
            this.panel1.Controls.Add(this.btnSoccer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 619);
            this.panel1.TabIndex = 0;
            // 
            // btnSoccer
            // 
            this.btnSoccer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoccer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoccer.Location = new System.Drawing.Point(298, 12);
            this.btnSoccer.Margin = new System.Windows.Forms.Padding(0);
            this.btnSoccer.Name = "btnSoccer";
            this.btnSoccer.Size = new System.Drawing.Size(500, 110);
            this.btnSoccer.TabIndex = 0;
            this.btnSoccer.Text = "Futbol";
            this.btnSoccer.UseVisualStyleBackColor = true;
            this.btnSoccer.Click += new System.EventHandler(this.btnSoccer_Click);
            // 
            // btnBasket
            // 
            this.btnBasket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasket.Location = new System.Drawing.Point(298, 122);
            this.btnBasket.Margin = new System.Windows.Forms.Padding(0);
            this.btnBasket.Name = "btnBasket";
            this.btnBasket.Size = new System.Drawing.Size(500, 110);
            this.btnBasket.TabIndex = 1;
            this.btnBasket.Text = "Basketball";
            this.btnBasket.UseVisualStyleBackColor = true;
            this.btnBasket.Click += new System.EventHandler(this.btnBasket_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTennis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTennis.Location = new System.Drawing.Point(298, 232);
            this.btnTennis.Margin = new System.Windows.Forms.Padding(0);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(500, 110);
            this.btnTennis.TabIndex = 2;
            this.btnTennis.Text = "Tennis";
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // btnVolley
            // 
            this.btnVolley.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolley.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolley.Location = new System.Drawing.Point(298, 342);
            this.btnVolley.Margin = new System.Windows.Forms.Padding(0);
            this.btnVolley.Name = "btnVolley";
            this.btnVolley.Size = new System.Drawing.Size(500, 110);
            this.btnVolley.TabIndex = 3;
            this.btnVolley.Text = "Volleyball";
            this.btnVolley.UseVisualStyleBackColor = true;
            this.btnVolley.Click += new System.EventHandler(this.btnVolley_Click);
            // 
            // btnHandball
            // 
            this.btnHandball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHandball.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHandball.Location = new System.Drawing.Point(298, 452);
            this.btnHandball.Margin = new System.Windows.Forms.Padding(0);
            this.btnHandball.Name = "btnHandball";
            this.btnHandball.Size = new System.Drawing.Size(500, 110);
            this.btnHandball.TabIndex = 4;
            this.btnHandball.Text = "Handball";
            this.btnHandball.UseVisualStyleBackColor = true;
            this.btnHandball.Click += new System.EventHandler(this.btnHandball_Click);
            // 
            // FrmSelectDeport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSelectDeport";
            this.Text = "FrmSelectDeport";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSoccer;
        private System.Windows.Forms.Button btnHandball;
        private System.Windows.Forms.Button btnVolley;
        private System.Windows.Forms.Button btnTennis;
        private System.Windows.Forms.Button btnBasket;
    }
}