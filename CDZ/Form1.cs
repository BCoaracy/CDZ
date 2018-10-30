using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtSaida.Text = null;
            var csv = new CSVcontrole();
            //var star = new CSVcontrole.Star();
            List<Star> starsList = csv.DezMagnitudes();
            foreach(var s in starsList)
            {
                txtSaida.AppendText("id: " + s.getId() + " Magnitude: " + s.getMag() + " Nome: " + s.getNome() + "\n" );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSaida.Text = null;
            var csv = new CSVcontrole();
            csv.estrelasVisiveis();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSaida.Text = null;
            var csv = new CSVcontrole();
            List<Star> starsList = csv.maisProximas();

            for (int i = 0; i <= 10; i++)
            {
                var estrela = starsList.ElementAt(i);
                txtSaida.AppendText("Id: " + estrela.getId() + " Nome: " + estrela.getNome() + " Distância: " + estrela.getDist() + "\n");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            txtSaida.Text = null;
            var csv = new CSVcontrole();
            List<string[]> lista = new List<string[]>();
            lista = csv.pesquisaConstelacao(txtConst.Text);
            foreach (string[] s in lista)
            {
                i++;
                txtSaida.AppendText("id da estrela: " + s[0] + " | Nome : " + s[6] + " | Constelação: " + s[29] + "\n");
            }
            txtSaida.AppendText(Convert.ToString(i));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var csv = new CSVcontrole();
            var yoga = csv.agulhaEscarlate();
            txtSaida.Text="Estrela mais brilhante de escorpião: " + Convert.ToString(yoga[6]);
            Console.WriteLine(yoga[6]);
        }

        private void txtSaida_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            EditaEstrelas ed = new EditaEstrelas();            
                ed.Visible = true;
        }


    }
}
