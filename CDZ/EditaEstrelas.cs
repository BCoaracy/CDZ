using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDZ
{
    public partial class EditaEstrelas : Form
    {
        public EditaEstrelas()
        {
            InitializeComponent();
            loadCmbConst();
            btnSave.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grpEdiEstrelas.Visible == false)
            {
                grpEdiEstrelas.Visible = true;
            }
            else
            {
                grpEdiEstrelas.Visible = false;
            }

            if (btnSave.Visible == false)
            {
                btnSave.Visible = true;
            }
            else
            {
                btnSave.Visible = false;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var csv = new CSVcontrole();

            csv.cvsParaSQL();

        }

        private void loadCmbConst()
        {

            String conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {
                
                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from constelacao";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();
            cmbConstelacao.DataSource = null;
            da.Fill(dtResultado);

            cmbConstelacao.DataSource = cmbConstEdit.DataSource = dtResultado;
            cmbConstelacao.ValueMember = cmbConstEdit.ValueMember = "const";
            cmbConstelacao.DisplayMember = cmbConstEdit.DisplayMember = "nome_const";
            cmbConstelacao.SelectedItem = cmbConstEdit.SelectedItem = "";
            cmbConstelacao.Refresh();

            //cmbConstEdit.DataSource = dtResultado;
            //cmbConstEdit.ValueMember = "const";
            //cmbConstEdit.DisplayMember = "nome_const";
            //cmbConstEdit.SelectedItem = "";
            //cmbConstEdit.Refresh();

        }

        

        private void btnGerarRel_Click(object sender, EventArgs e)
        {
            string constelacao = cmbConstelacao.SelectedValue.ToString();
            string conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {

                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            string scom = "select * from estrelas where con = '"+ constelacao + "'";
            //string scom = "select * from constelacao";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            List<string[]> lc = new List<string[]>();
            DataRow[] oDataRow = dt.Select();

            foreach (DataRow data in oDataRow)
            {
                string[] Estrela = { data[0].ToString(), data[8].ToString(), data[32].ToString() };

                lc.Add(Estrela);
            }
            
            foreach(var star in lc)
            {
                rtbRelatorio.AppendText("Id: " +star[0] +  " Nome: "+star[1]+ " Algo: "+star[2] + "\n" );
            }

            loadCmbConst();
        }

        private void cmbConst(object sender, EventArgs e)
        {
            string constelacao = cmbConstEdit.SelectedValue.ToString();
            String conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {

                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from estrelas where con = '" + constelacao + "'";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dt = new DataTable();
            dt.Clear();
            cmbConstelacao.DataSource = null;
            da.Fill(dt);
            cmbEstrelaEdit.DataSource = dt;
            cmbEstrelaEdit.ValueMember = "Id";
            cmbEstrelaEdit.DisplayMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = cmbEstrelaEdit.SelectedValue.ToString();
            string nome = txtNome.Text;
            string cons = txtCons.Text;
            string mag = txtMag.Text;
            string dist = txtDist.Text;
            string aglo = txtAglo.Text;

            string scom = "update estrelas set proper = '" + nome + "' , con = '" + cons + "' , mag = '" + 
                mag + "' , dist = '" + dist + "' , base = '"+ aglo + "' where Id = ' " +id+"'";

            string conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {

                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }

            SqlCommand cmd = new SqlCommand(scom, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        private void cmbConstEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constelacao = cmbConstEdit.SelectedValue.ToString();
            String conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {

                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from estrelas where con = '" + constelacao + "'";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dt = new DataTable();
            dt.Clear();
            cmbConstelacao.DataSource = null;
            da.Fill(dt);
            cmbEstrelaEdit.DataSource = dt;
            cmbEstrelaEdit.ValueMember = "Id";
            cmbEstrelaEdit.DisplayMember = "Id";
            cmbEstrelaEdit.Refresh();
            con.Close();
        }

        private void cmbConstEdit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string constelacao = cmbConstEdit.SelectedValue.ToString();
            String conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
            SqlConnection con = new SqlConnection(conexaoBD);
            try
            {

                con.Open();
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("Falha ao efetuar a conexão. Erro: " + sqle);
            }
            String scom = "select * from estrelas where con = '" + constelacao + "'";
            SqlDataAdapter da = new SqlDataAdapter(scom, con);
            DataTable dt = new DataTable();
            dt.Clear();
            cmbConstelacao.DataSource = null;
            da.Fill(dt);
            cmbEstrelaEdit.DataSource = dt;
            cmbEstrelaEdit.ValueMember = "Id";
            cmbEstrelaEdit.DisplayMember = "Id";
            cmbEstrelaEdit.Refresh();
            con.Close();
        }
    }
}
