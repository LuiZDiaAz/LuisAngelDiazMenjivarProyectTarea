namespace ProyectNotas2.Vista
{
    partial class frmVisualizarFormularios
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
            this.bttnCargarFormularios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnCargarFormularios
            // 
            this.bttnCargarFormularios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCargarFormularios.Location = new System.Drawing.Point(12, 12);
            this.bttnCargarFormularios.Name = "bttnCargarFormularios";
            this.bttnCargarFormularios.Size = new System.Drawing.Size(248, 32);
            this.bttnCargarFormularios.TabIndex = 16;
            this.bttnCargarFormularios.Text = "Cargar Formularios";
            this.bttnCargarFormularios.UseVisualStyleBackColor = true;
            this.bttnCargarFormularios.Click += new System.EventHandler(this.bttnCargarFormularios_Click);
            // 
            // frmVisualizarFormularios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnCargarFormularios);
            this.IsMdiContainer = true;
            this.Name = "frmVisualizarFormularios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisualizarFormularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnCargarFormularios;
    }
}