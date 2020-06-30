using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas_MN
{
    public partial class Ventas : Form
    {
        frmProductos frProductos = new frmProductos();
        frmStock frStock = new frmStock();
        
        public Ventas()
        {
            InitializeComponent();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frStock.MdiParent = this;
            frStock.Show();
            frStock.WindowState = FormWindowState.Minimized;
            frStock.WindowState = FormWindowState.Maximized;
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frProductos.MdiParent = this;
            frProductos.Show();
            frProductos.WindowState = FormWindowState.Minimized;
            frProductos.WindowState = FormWindowState.Maximized;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Productos.txt"))
            {
                StreamWriter swProductos = new StreamWriter("Productos.txt");
                swProductos.Close();
            }
            StreamReader srProductos = new StreamReader("Productos.txt");

            srProductos.Close();
        }
    }
}
