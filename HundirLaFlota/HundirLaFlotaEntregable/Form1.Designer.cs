namespace HundirLaFlotaEntregable
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.BotonCerrar = new System.Windows.Forms.Button();
            this.ResetGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(55, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hundir la flota";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoLabel.Location = new System.Drawing.Point(50, 520);
            this.estadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(300, 20);
            this.estadoLabel.TabIndex = 1;
            this.estadoLabel.Text = "Nuevo Juego: Disparos: 0, Barcos: 8";
            this.estadoLabel.Click += new System.EventHandler(this.estadoLabel_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Location = new System.Drawing.Point(275, 569);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(75, 23);
            this.BotonCerrar.TabIndex = 2;
            this.BotonCerrar.Text = "Cerrar";
            this.BotonCerrar.UseVisualStyleBackColor = true;
            this.BotonCerrar.Visible = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // ResetGame
            // 
            this.ResetGame.Location = new System.Drawing.Point(64, 569);
            this.ResetGame.Name = "ResetGame";
            this.ResetGame.Size = new System.Drawing.Size(99, 23);
            this.ResetGame.TabIndex = 3;
            this.ResetGame.Text = "Volver a jugar";
            this.ResetGame.UseVisualStyleBackColor = true;
            this.ResetGame.Visible = false;
            this.ResetGame.Click += new System.EventHandler(this.ResetGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(426, 604);
            this.Controls.Add(this.ResetGame);
            this.Controls.Add(this.BotonCerrar);
            this.Controls.Add(this.estadoLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Button BotonCerrar;
        private System.Windows.Forms.Button ResetGame;
    }
}

