﻿namespace LoginAdrian
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Textusuario = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.TextBox();
            this.Contra = new System.Windows.Forms.TextBox();
            this.TextContraseña = new System.Windows.Forms.Label();
            this.TextSalir = new System.Windows.Forms.Button();
            this.TextAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Textusuario
            // 
            this.Textusuario.AutoSize = true;
            this.Textusuario.BackColor = System.Drawing.Color.Transparent;
            this.Textusuario.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textusuario.ForeColor = System.Drawing.Color.White;
            this.Textusuario.Location = new System.Drawing.Point(233, 276);
            this.Textusuario.Name = "Textusuario";
            this.Textusuario.Size = new System.Drawing.Size(132, 35);
            this.Textusuario.TabIndex = 11;
            this.Textusuario.Text = "Usuario";
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(362, 276);
            this.User.Multiline = true;
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(282, 47);
            this.User.TabIndex = 10;
            // 
            // Contra
            // 
            this.Contra.Location = new System.Drawing.Point(362, 329);
            this.Contra.Multiline = true;
            this.Contra.Name = "Contra";
            this.Contra.Size = new System.Drawing.Size(282, 46);
            this.Contra.TabIndex = 9;
            // 
            // TextContraseña
            // 
            this.TextContraseña.AutoSize = true;
            this.TextContraseña.BackColor = System.Drawing.Color.Transparent;
            this.TextContraseña.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextContraseña.ForeColor = System.Drawing.Color.White;
            this.TextContraseña.Location = new System.Drawing.Point(233, 329);
            this.TextContraseña.Name = "TextContraseña";
            this.TextContraseña.Size = new System.Drawing.Size(118, 35);
            this.TextContraseña.TabIndex = 8;
            this.TextContraseña.Text = "Contra";
            // 
            // TextSalir
            // 
            this.TextSalir.BackColor = System.Drawing.Color.Red;
            this.TextSalir.Location = new System.Drawing.Point(282, 485);
            this.TextSalir.Name = "TextSalir";
            this.TextSalir.Size = new System.Drawing.Size(137, 54);
            this.TextSalir.TabIndex = 7;
            this.TextSalir.Text = "Salir";
            this.TextSalir.UseVisualStyleBackColor = false;
            this.TextSalir.Click += new System.EventHandler(this.TextSalir_Click);
            // 
            // TextAceptar
            // 
            this.TextAceptar.BackColor = System.Drawing.Color.Lime;
            this.TextAceptar.Location = new System.Drawing.Point(462, 485);
            this.TextAceptar.Name = "TextAceptar";
            this.TextAceptar.Size = new System.Drawing.Size(138, 54);
            this.TextAceptar.TabIndex = 6;
            this.TextAceptar.Text = "Aceptar";
            this.TextAceptar.UseVisualStyleBackColor = false;
            this.TextAceptar.Click += new System.EventHandler(this.TextAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 605);
            this.Controls.Add(this.Textusuario);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Contra);
            this.Controls.Add(this.TextContraseña);
            this.Controls.Add(this.TextSalir);
            this.Controls.Add(this.TextAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Textusuario;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Contra;
        private System.Windows.Forms.Label TextContraseña;
        private System.Windows.Forms.Button TextSalir;
        private System.Windows.Forms.Button TextAceptar;
    }
}

