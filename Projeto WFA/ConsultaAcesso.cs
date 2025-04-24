using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_WFA
{
    public partial class ConsultaAcesso : Form
    {
        public ConsultaAcesso()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvConsultar.Rows.Count;
            int id= Convert.ToInt32(dgvConsultar.Rows[linha].Cells[0].Value);
            string nome = dgvConsultar.Rows[linha].Cells[1].Value.ToString();
            string cpf = dgvConsultar.Rows[linha].Cells[2].Value.ToString();
            string tipo = dgvConsultar.Rows[linha].Cells[3].Value.ToString();
            string senha = dgvConsultar.Rows[linha].Cells[4].Value.ToString();
        }
    }
}
