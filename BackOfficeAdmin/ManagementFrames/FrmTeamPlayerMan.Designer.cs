namespace BackOfficeAdmin.ManagementFrames
{
    partial class FrmTeamPlayerMan
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
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvIndex = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(526, 76);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(120, 23);
            this.txtScore.TabIndex = 76;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 75;
            this.label4.Text = "Anotaciones:";
            // 
            // txtNationality
            // 
            this.txtNationality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationality.Location = new System.Drawing.Point(288, 76);
            this.txtNationality.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(120, 23);
            this.txtNationality.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Nacionalidad:";
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
            this.dgvIndex.TabIndex = 72;
            this.dgvIndex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIndex_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.Width = 52;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(708, 152);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 30);
            this.btnCreate.TabIndex = 67;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdate.Location = new System.Drawing.Point(303, 156);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(113, 21);
            this.txtUpdate.TabIndex = 71;
            this.txtUpdate.Enter += new System.EventHandler(this.txtUpdate_Enter);
            this.txtUpdate.Leave += new System.EventHandler(this.txtUpdate_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(217, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelete.Location = new System.Drawing.Point(98, 156);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(113, 21);
            this.txtDelete.TabIndex = 70;
            this.txtDelete.Enter += new System.EventHandler(this.txtDelete_Enter);
            this.txtDelete.Leave += new System.EventHandler(this.txtDelete_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 69;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(288, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(493, 32);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 23);
            this.txtLastName.TabIndex = 66;
            // 
            // FrmTeamPlayersMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvIndex);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTeamPlayerMan";
            this.Text = "FrmTeamPlayerMan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvIndex;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
    }
}