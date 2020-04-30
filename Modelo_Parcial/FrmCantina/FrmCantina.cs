using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {

        public FrmCantina()
        {
            InitializeComponent();
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);

            if (radioAgua.Checked)
            {
                this.barra1.AgregarBotella(new Agua((int)numericCapacidad.Value, txtMarca.Text, (int)numericContenido.Value));
            } 
            else
            {
                this.barra1.AgregarBotella(new Cerveza((int)numericCapacidad.Value, txtMarca.Text, tipo, (int)numericContenido.Value));
            }
        }
    }
}
