
namespace userAutenticationForm
{
    partial class Logueo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecuperarContraseña = new System.Windows.Forms.LinkLabel();
            this.Acceder = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.passwdBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.by = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // RecuperarContraseña
            // 
            this.RecuperarContraseña.AutoSize = true;
            this.RecuperarContraseña.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecuperarContraseña.Location = new System.Drawing.Point(266, 105);
            this.RecuperarContraseña.Name = "RecuperarContraseña";
            this.RecuperarContraseña.Size = new System.Drawing.Size(171, 23);
            this.RecuperarContraseña.TabIndex = 3;
            this.RecuperarContraseña.TabStop = true;
            this.RecuperarContraseña.Text = "Recuperar Contraseña";
            this.RecuperarContraseña.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RecuperarContraseña_LinkClicked);
            // 
            // Acceder
            // 
            this.Acceder.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acceder.Location = new System.Drawing.Point(114, 247);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(89, 35);
            this.Acceder.TabIndex = 4;
            this.Acceder.Text = "Acceder";
            this.Acceder.UseVisualStyleBackColor = true;
            this.Acceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(287, 247);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(82, 37);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // usuarioBox
            // 
            this.usuarioBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioBox.Location = new System.Drawing.Point(6, 42);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(133, 26);
            this.usuarioBox.TabIndex = 6;
            // 
            // passwdBox
            // 
            this.passwdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdBox.Location = new System.Drawing.Point(6, 120);
            this.passwdBox.Name = "passwdBox";
            this.passwdBox.PasswordChar = '*';
            this.passwdBox.Size = new System.Drawing.Size(133, 31);
            this.passwdBox.TabIndex = 7;
            this.passwdBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usuarioBox);
            this.groupBox1.Controls.Add(this.passwdBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(64, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 167);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Autentificación";
            // 
            // by
            // 
            this.by.AutoSize = true;
            this.by.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.by.Location = new System.Drawing.Point(267, 149);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(190, 18);
            this.by.TabIndex = 10;
            this.by.Text = "Desarrollado por Manuel Urra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(267, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Para AIEP";
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 302);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.by);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Acceder);
            this.Controls.Add(this.RecuperarContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Logueo";
            this.Text = "Salud Area Desarrollo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel RecuperarContraseña;
        private System.Windows.Forms.Button Acceder;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.TextBox passwdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label by;
        private System.Windows.Forms.Label label4;
    }
}

