namespace BackOfficeAdmin.ManagementFrames
{
    partial class FrmTeamMan
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
            this.dgvIndex = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).BeginInit();
            this.SuspendLayout();
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
            this.dgvIndex.TabIndex = 48;
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
            this.btnCreate.TabIndex = 43;
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
            this.txtUpdate.TabIndex = 47;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(217, 152);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 30);
            this.btnUpdate.TabIndex = 44;
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
            this.txtDelete.TabIndex = 46;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(12, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre del equipo:";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(321, 55);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(120, 23);
            this.txtTeamName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(451, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pais:";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(500, 55);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(120, 23);
            this.txtCountry.TabIndex = 38;
            // 
            // FrmTeamMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvIndex);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTeamMan";
            this.Text = "FrmTeamMan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIndex;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountry;
    }
}