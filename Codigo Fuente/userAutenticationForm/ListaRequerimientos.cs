using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userAutenticationForm.Clases;
using MySql.Data.MySqlClient;


namespace userAutenticationForm
{
    public partial class ListaRequerimientos : Form
    {
        public ListaRequerimientos()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            RegistroRequerimientosForm RegReqForm = new RegistroRequerimientosForm();

            RegReqForm.ShowDialog();


        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            Requerimiento ver_requerimientos = new Requerimiento();
            string tipo, prioridad;
            bool estadoPendiente, estadoResuelto;

            tipo = tipoReqcomboBox1.Text;
            prioridad = PrioridadBox2.Text;
            estadoPendiente = pendienteRadioButton.Checked;
            estadoResuelto = resueltosRadioButton2.Checked;


            if (tipo == "" || prioridad == "")
            {
                MessageBox.Show("POR FAVOR RELLENA LOS CAMPOS");
            }
            else if (estadoPendiente)
            {
                dataGridView1.DataSource = ver_requerimientos.getRequerimiento(tipo, prioridad, "Pendiente");
            }

            else if (estadoResuelto)
            {
                dataGridView1.DataSource = ver_requerimientos.getRequerimiento(tipo, prioridad, "Resuelto");
            }

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarcarLeidoButton_Click(object sender, EventArgs e)
        {
            Requerimiento editarEstado = new Requerimiento();

            try
            {
                var cursorSeleccion = dataGridView1.CurrentRow.Index;
                

                var columnaID = dataGridView1.Rows[cursorSeleccion].Cells[0].Value;

                int idReq = Convert.ToInt32(columnaID);

                editarEstado.editRequerimiento(idReq);

                MessageBox.Show("Estado cambiado a Resuelto\nFavor de recargar la grilla");
            }

            catch
            {
                
                MessageBox.Show("Carga los datos campeón");
            }
        }

        private void EliminarReqButton_Click(object sender, EventArgs e)
        {
            Requerimiento eliminarReq = new Requerimiento();
            var cursorSeleccion = dataGridView1.CurrentRow.Index;
            var columnaID = dataGridView1.Rows[cursorSeleccion].Cells[0].Value;
            int idReq = Convert.ToInt32(columnaID);

            try
            {

                eliminarReq.delReq(idReq);
                MessageBox.Show("El Requerimiento fue borrado con éxito");
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }

            catch
            {
                MessageBox.Show("Carga los datos campeón");
            }
      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Requerimiento superload = new Requerimiento();
            dataGridView1.DataSource = superload.getRequerimientoAll();
            
        }
    }
}
