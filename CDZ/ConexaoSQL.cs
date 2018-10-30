using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CDZ
{
    class ConexaoSQL
    {


        string conexaoBD = "Data Source=BRUNO-NTB\\SQLEXPRESS;Initial Catalog=cdz_bd;User ID=Teste;Password=pegasus ";
        SqlConnection connection;
        string sql = null;
        SqlDataReader dataReader;

        

        public void insertSql(List<string[]> listaDeEstrelas)
        {
            List<string> constelacoes = new List<string>();
            List<string> aglomerados = new List<string>();
            try
            {
                foreach (var estrela in listaDeEstrelas)
                {
                    if (estrela[29] != null && !constelacoes.Contains(estrela[29]))
                        constelacoes.Add(Convert.ToString(estrela[29]));
                    if (estrela[32] != null && !aglomerados.Contains(estrela[32]))
                        aglomerados.Add(estrela[32]);
                    //Conversao dos tipos de dados
                    int id = (estrela[0].Equals("")) ? 0 : Convert.ToInt32(estrela[0]);
                    string hip = (estrela[1]);
                    string hd = (estrela[2]);
                    string hr = (estrela[3]);
                    string gl = (estrela[4]);
                    string bf = estrela[5];
                    string ra = (estrela[6]);
                    string declinacao = (estrela[7]);
                    string proper = estrela[8];
                    string dist = (estrela[9]);
                    string pm_ra = (estrela[10]);
                    string pm_dec = (estrela[11]);
                    string rv = (estrela[12]);
                    string mag = (estrela[13]);
                    string absmag = (estrela[14]);
                    string spec = estrela[15];
                    string ci = estrela[16];
                    string x = (estrela[17]);
                    string y = (estrela[18]);
                    string z = (estrela[19]);
                    string vx = (estrela[20]);
                    string vy = (estrela[21]);
                    string vz = (estrela[22]);
                    string rarad = (estrela[23]);
                    string decrad = (estrela[24]);
                    string pmrarad = (estrela[25]);
                    string pmdecrad = (estrela[26]);
                    string bayer = estrela[27];
                    string flam = estrela[28];
                    string con = estrela[29];
                    string comp = (estrela[30]);
                    string comp_pri = (estrela[31]);
                    string Base = estrela[32];
                    string lum = (estrela[33]);
                    string var_ = estrela[34];
                    string var_min = (estrela[35]);
                    string var_max = (estrela[36]);

                    //connection = new SqlConnection(conexaoBD);
                    //string queryStar = "INSERT INTO estrelas ([Hip],[Hd],[Hr],[gl],[bf],ra,declinacao,proper,dist,pm_ra,pm_dec,rv,mag,absmag,spec,ci,x,y,z,vx,vy,vz" +
                    //                                   ",rarad,decrad,pmrarad,pmdecrad,bayer,flam,con,comp,comp_pri,base,lum,var_,var_min,var_max)" +
                    //                             "VALUES(@hip, @hd, @hr, @gl, @bf, @ra, @declinacao, @proper, @dist, @pm_ra, @pm_dec, @rv, @mag, @absmag, @spec, @ci" +
                    //                                    ", @x, @y, @z, @vx, @vy, @vz, @rarad, @decrad, @pmrarad, @pmdecrad, @bayer, @flam, @con, @comp, @comp_pri, @Base" +
                    //                                    ", @lum, @var_, @var_min, @var_max)";

                    //try
                    //{
                    //    connection.Open();

                    //    SqlCommand command = new SqlCommand(queryStar, connection);
                    //    //command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    //    command.Parameters.Add("@hip", SqlDbType.NVarChar).Value = hip;
                    //    command.Parameters.Add("@hd", SqlDbType.NVarChar).Value = hd;
                    //    command.Parameters.Add("@hr", SqlDbType.NVarChar).Value = hr;
                    //    command.Parameters.Add("@gl", SqlDbType.NVarChar).Value = gl;
                    //    command.Parameters.Add("@bf", SqlDbType.NVarChar).Value = bf;
                    //    command.Parameters.Add("@ra", SqlDbType.NVarChar).Value = ra;
                    //    command.Parameters.Add("@declinacao", SqlDbType.NVarChar).Value = declinacao;
                    //    command.Parameters.Add("@proper", SqlDbType.NVarChar).Value = proper;
                    //    command.Parameters.Add("@dist", SqlDbType.NVarChar).Value = dist;
                    //    command.Parameters.Add("@pm_ra", SqlDbType.NVarChar).Value = pm_ra;
                    //    command.Parameters.Add("@pm_dec", SqlDbType.NVarChar).Value = pm_dec;
                    //    command.Parameters.Add("@rv", SqlDbType.NVarChar).Value = rv;
                    //    command.Parameters.Add("@mag", SqlDbType.NVarChar).Value = mag;
                    //    command.Parameters.Add("@absmag", SqlDbType.NVarChar).Value = absmag;
                    //    command.Parameters.Add("@spec", SqlDbType.NVarChar).Value = spec;
                    //    command.Parameters.Add("@ci", SqlDbType.NVarChar).Value = ci;
                    //    command.Parameters.Add("@x", SqlDbType.NVarChar).Value = x;
                    //    command.Parameters.Add("@y", SqlDbType.NVarChar).Value = y;
                    //    command.Parameters.Add("@z", SqlDbType.NVarChar).Value = z;
                    //    command.Parameters.Add("@vx", SqlDbType.NVarChar).Value = vx;
                    //    command.Parameters.Add("@vy", SqlDbType.NVarChar).Value = vy;
                    //    command.Parameters.Add("@vz", SqlDbType.NVarChar).Value = vz;
                    //    command.Parameters.Add("@rarad", SqlDbType.NVarChar).Value = rarad;
                    //    command.Parameters.Add("@decrad", SqlDbType.NVarChar).Value = decrad;
                    //    command.Parameters.Add("@pmrarad", SqlDbType.NVarChar).Value = pmrarad;
                    //    command.Parameters.Add("@pmdecrad", SqlDbType.NVarChar).Value = pmdecrad;
                    //    command.Parameters.Add("@bayer", SqlDbType.NVarChar).Value = bayer;
                    //    command.Parameters.Add("@flam", SqlDbType.NVarChar).Value = flam;
                    //    command.Parameters.Add("@con", SqlDbType.NVarChar).Value = con;
                    //    command.Parameters.Add("@comp", SqlDbType.NVarChar).Value = comp;
                    //    command.Parameters.Add("@comp_pri", SqlDbType.NVarChar).Value = comp_pri;
                    //    command.Parameters.Add("@Base", SqlDbType.NVarChar).Value = Base;
                    //    command.Parameters.Add("@lum", SqlDbType.NVarChar).Value = lum;
                    //    command.Parameters.Add("@var_", SqlDbType.NVarChar).Value = var_;
                    //    command.Parameters.Add("@var_min", SqlDbType.NVarChar).Value = var_min;
                    //    command.Parameters.Add("@var_max", SqlDbType.NVarChar).Value = var_max;


                    //    command.CommandType = CommandType.Text;
                    //    command.ExecuteNonQuery();
                    //    command.Dispose();
                    //    connection.Close();

                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show("Deu erro!! \n" + ex);
                    //}
                }


                //foreach (string constelacao in constelacoes)
                //{
                //    try
                //    {
                //        connection = new SqlConnection(conexaoBD);
                //        string queryConst = (@"INSERT INTO constelacao (const) VALUES (@constelacao)");
                //        connection.Open();

                //        SqlCommand command = new SqlCommand(queryConst, connection);

                //        command.Parameters.Add("@constelacao", SqlDbType.NVarChar).Value = constelacao;
                //        command.CommandType = CommandType.Text;
                //        command.ExecuteNonQuery();
                //        command.Dispose();
                //        connection.Close();
                       
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Deu erro!! \n" + ex);
                //    }


                //}
                

                try
                {
                    foreach (string aglomerado in aglomerados)
                    {
                        connection = new SqlConnection(conexaoBD);
                        string queryAglo = (@"INSERT INTO aglomerado (base) VALUES (@aglomerado)");
                        connection.Open();
                        

                        SqlCommand command = new SqlCommand(queryAglo, connection);
                        command.Parameters.Add("@aglomerado", SqlDbType.NVarChar).Value = aglomerado;
                        command.CommandType = CommandType.Text;
                        command.ExecuteNonQuery();
                        command.Dispose();
                        connection.Close();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Deu erro!! \n" + ex);
                }
            }
            catch(Exception e)
            {
                    MessageBox.Show("Erro: \n"+ e);
            }
        }
    }
}
