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

namespace userAutenticationForm
{
    public partial class Logueo : Form
    {
        public Logueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userLogin, passwdLogin;
            Usuario checkthisbro = new Usuario();
          
            userLogin = Convert.ToString(usuarioBox.Text);
            passwdLogin = Convert.ToString(passwdBox.Text);
            
             if(checkthisbro.check_user(userLogin,passwdLogin))
              {
                  ListaRequerimientos ListReqForm = new ListaRequerimientos();
                  ListReqForm.Show();
                  this.Hide();

              }

              else
              {
                  MessageBox.Show("Contraseña incorrecta");
              }





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* codigo para futuras versiones */
            RegistroUsuario regUser = new RegistroUsuario();
            MessageBox.Show("Necesita ser administrador \n para agregar un nuevo usuario");
        }

        private void RecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Próximamente");
        }
    }
}
