
namespace userAutenticationForm
{
    partial class ListaRequerimientos
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
            this.PrioridadRequerimientoListBox = new System.Windows.Forms.Label();
            this.TipoRequerimientoListBox = new System.Windows.Forms.Label();
            this.tipoReqcomboBox1 = new System.Windows.Forms.ComboBox();
            this.PrioridadBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EliminarReqButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MarcarLeidoButton = new System.Windows.Forms.Button();
            this.buscarButton = new System.Windows.Forms.Button();
            this.pendienteRadioButton = new System.Windows.Forms.RadioButton();
            this.resueltosRadioButton2 = new System.Windows.Forms.RadioButton();
            this.salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Requerimientos";
            // 
            // PrioridadRequerimientoListBox
            // 
            this.PrioridadRequerimientoListBox.AutoSize = true;
            this.PrioridadRequerimientoListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioridadRequerimientoListBox.Location = new System.Drawing.Point(12, 148);
            this.PrioridadRequerimientoListBox.Name = "PrioridadRequerimientoListBox";
            this.PrioridadRequerimientoListBox.Size = new System.Drawing.Size(83, 23);
            this.PrioridadRequerimientoListBox.TabIndex = 1;
            this.PrioridadRequerimientoListBox.Text = "Prioridad:";
            // 
            // TipoRequerimientoListBox
            // 
            this.TipoRequerimientoListBox.AutoSize = true;
            this.TipoRequerimientoListBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoRequerimientoListBox.Location = new System.Drawing.Point(12, 85);
            this.TipoRequerimientoListBox.Name = "TipoRequerimientoListBox";
            this.TipoRequerimientoListBox.Size = new System.Drawing.Size(156, 23);
            this.TipoRequerimientoListBox.TabIndex = 2;
            this.TipoRequerimientoListBox.Text = "Tipo Requerimiento:";
            // 
            // tipoReqcomboBox1
            // 
            this.tipoReqcomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoReqcomboBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoReqcomboBox1.FormattingEnabled = true;
            this.tipoReqcomboBox1.Items.AddRange(new object[] {
            "Base De Datos",
            "Sistemas",
            "Servidores"});
            this.tipoReqcomboBox1.Location = new System.Drawing.Point(174, 85);
            this.tipoReqcomboBox1.Name = "tipoReqcomboBox1";
            this.tipoReqcomboBox1.Size = new System.Drawing.Size(121, 31);
            this.tipoReqcomboBox1.TabIndex = 5;
            // 
            // PrioridadBox2
            // 
            this.PrioridadBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrioridadBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrioridadBox2.FormattingEnabled = true;
            this.PrioridadBox2.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.PrioridadBox2.Location = new System.Drawing.Point(174, 148);
            this.PrioridadBox2.Name = "PrioridadBox2";
            this.PrioridadBox2.Size = new System.Drawing.Size(121, 31);
            this.PrioridadBox2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(600, 174);
            this.dataGridView1.TabIndex = 11;
            // 
            // EliminarReqButton
            // 
            this.EliminarReqButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarReqButton.Location = new System.Drawing.Point(496, 258);
            this.EliminarReqButton.Name = "EliminarReqButton";
            this.EliminarReqButton.Size = new System.Drawing.Size(123, 60);
            this.EliminarReqButton.TabIndex = 12;
            this.EliminarReqButton.Text = "Eliminar";
            this.EliminarReqButton.UseVisualStyleBackColor = true;
            this.EliminarReqButton.Click += new System.EventHandler(this.EliminarReqButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(625, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 60);
            this.button2.TabIndex = 13;
            this.button2.Text = "Agregar Nuevo Requerimiento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MarcarLeidoButton
            // 
            this.MarcarLeidoButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcarLeidoButton.Location = new System.Drawing.Point(338, 258);
            this.MarcarLeidoButton.Name = "MarcarLeidoButton";
            this.MarcarLeidoButton.Size = new System.Drawing.Size(152, 60);
            this.MarcarLeidoButton.TabIndex = 14;
            this.MarcarLeidoButton.Text = "Marcar Como Resuelto";
            this.MarcarLeidoButton.UseVisualStyleBackColor = true;
            this.MarcarLeidoButton.Click += new System.EventHandler(this.MarcarLeidoButton_Click);
            // 
            // buscarButton
            // 
            this.buscarButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarButton.Location = new System.Drawing.Point(45, 274);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(75, 33);
            this.buscarButton.TabIndex = 15;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // pendienteRadioButton
            // 
            this.pendienteRadioButton.AutoSize = true;
            this.pendienteRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendienteRadioButton.Location = new System.Drawing.Point(20, 198);
            this.pendienteRadioButton.Name = "pendienteRadioButton";
            this.pendienteRadioButton.Size = new System.Drawing.Size(97, 27);
            this.pendienteRadioButton.TabIndex = 16;
            this.pendienteRadioButton.TabStop = true;
            this.pendienteRadioButton.Text = "Pendiente";
            this.pendienteRadioButton.UseVisualStyleBackColor = true;
            // 
            // resueltosRadioButton2
            // 
            this.resueltosRadioButton2.AutoSize = true;
            this.resueltosRadioButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resueltosRadioButton2.Location = new System.Drawing.Point(20, 231);
            this.resueltosRadioButton2.Name = "resueltosRadioButton2";
            this.resueltosRadioButton2.Size = new System.Drawing.Size(97, 27);
            this.resueltosRadioButton2.TabIndex = 17;
            this.resueltosRadioButton2.TabStop = true;
            this.resueltosRadioButton2.Text = "Resueltos";
            this.resueltosRadioButton2.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(767, 258);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(136, 60);
            this.salir.TabIndex = 18;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 52);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cargar Todos los Registros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListaRequerimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.resueltosRadioButton2);
            this.Controls.Add(this.pendienteRadioButton);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.MarcarLeidoButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EliminarReqButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrioridadBox2);
            this.Controls.Add(this.tipoReqcomboBox1);
            this.Controls.Add(this.TipoRequerimientoListBox);
            this.Controls.Add(this.PrioridadRequerimientoListBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ListaRequerimientos";
            this.Text = "ListaRequerimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PrioridadRequerimientoListBox;
        private System.Windows.Forms.Label TipoRequerimientoListBox;
        private System.Windows.Forms.ComboBox tipoReqcomboBox1;
        private System.Windows.Forms.ComboBox PrioridadBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button EliminarReqButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MarcarLeidoButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.RadioButton pendienteRadioButton;
        private System.Windows.Forms.RadioButton resueltosRadioButton2;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button button1;
    }
}