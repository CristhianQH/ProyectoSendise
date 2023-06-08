using MySqlConnector;
using ProyectoSen.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        //layout

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWithEllipse,
            int nHeightEllipse

            );
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
        //layout





        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = txtUsuario.Text;
            contraseña = txtContra.Text;
            CConexion objetoConexion = new CConexion();
            
            String query= "Select Usuario,Contraseña from login where Usuario = '" + usuario + "' AND Contraseña = '" + contraseña + "' ";

            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                if(usuario == "ADMIN@PERUSIS.COM" && contraseña == "perusis2023")
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido "+  " \n ADMIN \n" + usuario);
                    InicioAdmin admin = new InicioAdmin();
                    admin.ShowDialog();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + usuario);
                    InicioUsuario formularioP = new InicioUsuario();
                    formularioP.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("No existe ese usuario "+  usuario);
            }
            objetoConexion.cerrarConexion();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)

        {
            //this is for login load
            panel2.Location = new Point(
                this.ClientSize.Width /2 - panel2.Size.Width/2,
                this.ClientSize.Width /2 - panel2.Size.Width/2

                );
            panel2.Anchor = AnchorStyles.None;
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 
            panel2.Width, panel2.Height, 30, 30));

            IntPtr region = CreateRoundRectRgn(0, 0, btnIngresar.Width, btnIngresar.Height, 30, 30);
            SetWindowRgn(btnIngresar.Handle, region, true);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           //
            Application.Exit();
           
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
