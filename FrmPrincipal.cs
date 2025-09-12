using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
    public partial class FrmPrincipal: Form
    {
        Interfaces aInter=new Interfaces();
        Paises opais=new Paises();
        Paises opais1=new Paises();
        Estados oEstado=new Estados();
        Controller aCtrl=new Controller();
        Cidades ocidade = new Cidades();
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(opais, aCtrl);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado, aCtrl);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades(ocidade, aCtrl);
        }
    }
}
