namespace ProyectNotas2.Vista
{
    partial class frmDatosMateria
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdmateria = new System.Windows.Forms.TextBox();
            this.txtNombremateria = new System.Windows.Forms.TextBox();
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.bttnCargar = new System.Windows.Forms.Button();
            this.bttnActualizar = new System.Windows.Forms.Button();
            this.bttnGuardar = new System.Windows.Forms.Button();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Materia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Materia";
            // 
            // txtIdmateria
            // 
            this.txtIdmateria.Location = new System.Drawing.Point(220, 58);
            this.txtIdmateria.Name = "txtIdmateria";
            this.txtIdmateria.Size = new System.Drawing.Size(319, 22);
            this.txtIdmateria.TabIndex = 10;
            // 
            // txtNombremateria
            // 
            this.txtNombremateria.Location = new System.Drawing.Point(278, 132);
            this.txtNombremateria.Name = "txtNombremateria";
            this.txtNombremateria.Size = new System.Drawing.Size(319, 22);
            this.txtNombremateria.TabIndex = 11;
            // 
            // dgvMateria
            // 
            this.dgvMateria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_materia,
            this.nombre_materia});
            this.dgvMateria.Location = new System.Drawing.Point(77, 229);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.RowHeadersWidth = 51;
            this.dgvMateria.RowTemplate.Height = 24;
            this.dgvMateria.Size = new System.Drawing.Size(462, 192);
            this.dgvMateria.TabIndex = 12;
            // 
            // bttnCargar
            // 
            this.bttnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCargar.Location = new System.Drawing.Point(661, 242);
            this.bttnCargar.Name = "bttnCargar";
            this.bttnCargar.Size = new System.Drawing.Size(127, 32);
            this.bttnCargar.TabIndex = 15;
            this.bttnCargar.Text = "Cargar";
            this.bttnCargar.UseVisualStyleBackColor = true;
            this.bttnCargar.Click += new System.EventHandler(this.bttnCargar_Click);
            // 
            // bttnActualizar
            // 
            this.bttnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnActualizar.Location = new System.Drawing.Point(661, 389);
            this.bttnActualizar.Name = "bttnActualizar";
            this.bttnActualizar.Size = new System.Drawing.Size(127, 32);
            this.bttnActualizar.TabIndex = 16;
            this.bttnActualizar.Text = "Actualizar";
            this.bttnActualizar.UseVisualStyleBackColor = true;
            this.bttnActualizar.Click += new System.EventHandler(this.bttnActualizar_Click);
            // 
            // bttnGuardar
            // 
            this.bttnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnGuardar.Location = new System.Drawing.Point(661, 314);
            this.bttnGuardar.Name = "bttnGuardar";
            this.bttnGuardar.Size = new System.Drawing.Size(127, 32);
            this.bttnGuardar.TabIndex = 17;
            this.bttnGuardar.Text = "Guardar";
            this.bttnGuardar.UseVisualStyleBackColor = true;
            this.bttnGuardar.Click += new System.EventHandler(this.bttnGuardar_Click);
            // 
            // id_materia
            // 
            this.id_materia.HeaderText = "id_materia";
            this.id_materia.MinimumWidth = 6;
            this.id_materia.Name = "id_materia";
            // 
            // nombre_materia
            // 
            this.nombre_materia.HeaderText = "nombre_materia";
            this.nombre_materia.MinimumWidth = 6;
            this.nombre_materia.Name = "nombre_materia";
            // 
            // frmDatosMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnGuardar);
            this.Controls.Add(this.bttnActualizar);
            this.Controls.Add(this.bttnCargar);
            this.Controls.Add(this.dgvMateria);
            this.Controls.Add(this.txtNombremateria);
            this.Controls.Add(this.txtIdmateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatosMateria";
            this.Text = "frmDatosMateria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdmateria;
        private System.Windows.Forms.TextBox txtNombremateria;
        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Button bttnCargar;
        private System.Windows.Forms.Button bttnActualizar;
        private System.Windows.Forms.Button bttnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_materia;
    }
}