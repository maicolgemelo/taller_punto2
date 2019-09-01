using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller_punto2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string producto = txtprecio.Text;
            string aumento = lblprecioiva.Text;
            string total = lblpreciototal.Text;

            float precio = float.Parse(txtprecio.Text);
            float iva = precio * 0.19F;
            float totalproducto = precio + iva;

            lblprecioiva.Text = iva.ToString();
            lblpreciototal.Text = totalproducto.ToString();
        }
    }
}
