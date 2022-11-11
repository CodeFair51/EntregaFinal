namespace BackOfficeAdmin.ManagementFrames
{
    partial class FrmChampionshipMan
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
            this.cmbAtributesModality = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFirstAndSecondLeg = new System.Windows.Forms.CheckBox();
            this.cmbModality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantityDates = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChampionshipName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeportName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvIndex = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbAtributesModality);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chkFirstAndSecondLeg);
            this.panel1.Controls.Add(this.cmbModality);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQuantityDates);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtChampionshipName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRegion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDeportName);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.txtUpdate);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtDelete);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 182);
            this.panel1.TabIndex = 0;
            // 
            // cmbAtributesModality
            // 
            this.cmbAtributesModality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAtributesModality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtributesModality.FormattingEnabled = true;
            this.cmbAtributesModality.Items.AddRange(new object[] {
            "Sin atributos extra",
            "Grupos y eliminacion"});
            this.cmbAtributesModality.Location = new System.Drawing.Point(454, 147);
            this.cmbAtributesModality.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cmbAtributesModality.Name = "cmbAtributesModality";
            this.cmbAtributesModality.Size = new System.Drawing.Size(170, 24);
            this.cmbAtributesModality.TabIndex = 37;
            this.cmbAtributesModality.SelectedIndexChanged += new System.EventHandler(this.cmbAtributesModality_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(452, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Atributos de modalidad";
            // 
            // chkFirstAndSecondLeg
            // 
            this.chkFirstAndSecondLeg.AutoSize = true;
            this.chkFirstAndSecondLeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstAndSecondLeg.Location = new System.Drawing.Point(621, 84);
            this.chkFirstAndSecondLeg.Name = "chkFirstAndSecondLeg";
            this.chkFirstAndSecondLeg.Size = new System.Drawing.Size(167, 21);
            this.chkFirstAndSecondLeg.TabIndex = 35;
            this.chkFirstAndSecondLeg.Text = "Ida y vuelta en grupos";
            this.chkFirstAndSecondLeg.UseVisualStyleBackColor = true;
            this.chkFirstAndSecondLeg.Visible = false;
            // 
            // cmbModality
            // 
            this.cmbModality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbModality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModality.FormattingEnabled = true;
            this.cmbModality.Items.AddRange(new object[] {
            "Liga",
            "Grupos y eliminacion"});
            this.cmbModality.Location = new System.Drawing.Point(607, 54);
            this.cmbModality.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.cmbModality.Name = "cmbModality";
            this.cmbModality.Size = new System.Drawing.Size(170, 24);
            this.cmbModality.TabIndex = 34;
            this.cmbModality.SelectedIndexChanged += new System.EventHandler(this.cmbModality_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Modalidad:";
            // 
            // txtQuantityDates
            // 
            this.txtQuantityDates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityDates.Location = new System.Drawing.Point(385, 54);
            this.txtQuantityDates.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtQuantityDates.Name = "txtQuantityDates";
            this.txtQuantityDates.Size = new System.Drawing.Size(120, 23);
            this.txtQuantityDates.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nombre del deporte:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombre del campeonato:";
            // 
            // txtChampionshipName
            // 
            this.txtChampionshipName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtChampionshipName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChampionshipName.Location = new System.Drawing.Point(267, 18);
            this.txtChampionshipName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtChampionshipName.Name = "txtChampionshipName";
            this.txtChampionshipName.Size = new System.Drawing.Size(120, 23);
            this.txtChampionshipName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Region:";
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(98, 54);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(120, 23);
            this.txtRegion.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cantidad de fechas:";
            // 
            // txtDeportName
            // 
            this.txtDeportName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDeportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeportName.Location = new System.Drawing.Point(554, 18);
            this.txtDeportName.Name = "txtDeportName";
            this.txtDeportName.Size = new System.Drawing.Size(120, 23);
            this.txtDeportName.TabIndex = 28;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(670, 141);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.Location = new System.Drawing.Point(303, 147);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(113, 21);
            this.txtUpdate.TabIndex = 22;
            this.txtUpdate.Enter += new System.EventHandler(this.txtUpdate_Enter);
            this.txtUpdate.Leave += new System.EventHandler(this.txtUpdate_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(217, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(98, 147);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(113, 21);
            this.txtDelete.TabIndex = 21;
            this.txtDelete.Enter += new System.EventHandler(this.txtDelete_Enter);
            this.txtDelete.Leave += new System.EventHandler(this.txtDelete_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvIndex
            // 
            this.dgvIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIndex.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIndex.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIndex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit});
            this.dgvIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvIndex.Location = new System.Drawing.Point(12, 188);
            this.dgvIndex.Name = "dgvIndex";
            this.dgvIndex.Size = new System.Drawing.Size(776, 250);
            this.dgvIndex.TabIndex = 1;
            this.dgvIndex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIndex_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.Width = 52;
            // 
            // FrmChampionshipMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIndex);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChampionshipMan";
            this.Text = "FrmChampionshipMan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvIndex;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChampionshipName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeportName;
        private System.Windows.Forms.TextBox txtQuantityDates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbModality;
        private System.Windows.Forms.CheckBox chkFirstAndSecondLeg;
        private System.Windows.Forms.ComboBox cmbAtributesModality;
        private System.Windows.Forms.Label label6;
    }
}