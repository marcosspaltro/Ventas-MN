using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Ventas_MN
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Productos.txt"))
            {
                StreamWriter swProductos = new StreamWriter("Productos.txt");
                swProductos.WriteLine("");
                swProductos.Close();
            }
            else
            {
                TextReader lector = new StreamReader("Productos.txt");
                string[] leer = File.ReadAllLines("Productos.txt");
                foreach (string item in leer)
                {
                    lstProductos.Items.Add(item);
                }
                lector.Close();
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void nvalista()
        {
            TextWriter nvoarchivo = new StreamWriter("Productos.txt");
            foreach (object lista in lstProductos.Items)
                nvoarchivo.WriteLine(lista);
            nvoarchivo.Close();
        }

        private void lstProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtProductos.Text = "";
            btnEditar.Text = "Editar";
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (txtProductos.Text != "")
                lstProductos.Items.Add(lstProductos.Items.Count + 1 + ". " + txtProductos.Text);
            txtProductos.Text = "";
            nvalista();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (txtProductos.Text != "" & lstProductos.SelectedIndex != -1)
            {
                lstProductos.Items.Insert(lstProductos.SelectedIndex, txtProductos.Text);
                lstProductos.Items.RemoveAt(lstProductos.SelectedIndex);
                btnEditar.Text = "Editar";
                txtProductos.Text = "";
                nvalista();

            }
            else
            {
                btnEditar.Text = "Aceptar";
                txtProductos.Text = lstProductos.SelectedItem.ToString();
            }
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (lstProductos.SelectedIndex != -1)
                lstProductos.Items.RemoveAt(lstProductos.SelectedIndex);
            txtProductos.Text = "";
            nvalista();
        }

        private void txtProductos_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
