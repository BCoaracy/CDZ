using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDZ
{
    class CSVcontrole
    {
        public List<Star> DezMagnitudes()
        {//10 maiores magnitudes
            StreamReader stream = new StreamReader(@"D:\\Facul\\Persistencia\\hypparcos\\hygdata\\hygdata_v3.csv");
            List<Star> listaEstrelas = new List<Star>();

            try
            {
                string linha = null;
                string[] coluna = null;
                stream.ReadLine();

                for (int i = 0; i <= 10; i++)
                {
                    linha = stream.ReadLine();
                    coluna = linha.Split(',');
                    Star star = new Star(coluna[0], coluna[6], Convert.ToDouble(coluna[13], CultureInfo.InvariantCulture));
                    listaEstrelas.Add(star);

                }

                listaEstrelas.RemoveAt(0);

                var listaOrdenada = listaEstrelas.OrderByDescending(m => m.getMag());

                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    Star estrela = listaOrdenada.ElementAt(i);

                    Console.WriteLine("id: " + estrela.getId() + " Magnitude: " + estrela.getMag() + " Nome: " + estrela.getNome());
                    
                }

                return listaOrdenada.ToList();

            }
            catch (IOException Ioe)
            {
                return null;
                MessageBox.Show("Erro!!" + Ioe);
            }
            finally
            {
                stream.Close();
            }

        }

        public void estrelasVisiveis()
        {
            StreamReader reader = new StreamReader(@"D:\\Facul\\Persistencia\\hypparcos\\hygdata\\hygdata_v3.csv");
            StreamWriter writer = new StreamWriter(@"C:\\Users\\Bruno\\Desktop\\EstralasVisiveis.csv");

            try
            {
                string linha = null;
                string[] coluna = null;
                reader.ReadLine();

                while (reader.ReadLine() != null)
                {
                    linha = reader.ReadLine();
                    coluna = linha.Split(',');
                    //var x = Convert.ToDouble(coluna[13], CultureInfo.InvariantCulture);


                    if (Convert.ToDouble(coluna[13], CultureInfo.InvariantCulture) < 6.5)
                    {
                        writer.WriteLine(coluna[0] + ", " + coluna[6] + ", " + coluna[13]);
                    }
                }

            }
            catch (Exception Ioe)
            {
                MessageBox.Show("Erro: " + Ioe);
            }
            finally
            {
                reader.Close();
                writer.Close();
            }

        }

        public List<Star> maisProximas()
        {
            StreamReader reader = new StreamReader(@"D:\\Facul\\Persistencia\\hypparcos\\hygdata\\hygdata_v3.csv");

            List<Star> listaEstrelas = new List<Star>();

            try
            {
                string linha = null;
                string[] coluna = null;
                reader.ReadLine();

                while (reader.ReadLine() != null)
                {
                    linha = reader.ReadLine();
                    coluna = linha.Split(',');
                    Star star = new Star(coluna[0], coluna[6], Convert.ToDouble(coluna[13], CultureInfo.InvariantCulture),
                        Convert.ToDouble(coluna[9], CultureInfo.InvariantCulture));
                    listaEstrelas.Add(star);

                }

                var listaDistantes = listaEstrelas.OrderByDescending(s => s.getDist());

                for (int i = 0; i <= 10; i++)
                {
                    var estrela = listaDistantes.ElementAt(i);
                    Console.WriteLine("Id: " + estrela.getId() + " Nome: " + estrela.getNome() + " Distância: " + estrela.getDist());
                }

                return listaDistantes.ToList();

            }

            catch (Exception Ioe)
            {
                return null;
                MessageBox.Show("Erro: " + Ioe);
            }
            finally
            {
                reader.Close();
            }

        }

        public List<string[]> pesquisaConstelacao(string constelacao)
        {
            StreamReader reader = new StreamReader(@"D:\\Facul\\Persistencia\\hypparcos\\hygdata\\hygdata_v3.csv");
            List<string[]> listaConstelacao = new List<string[]>();
            try
            {
                string linha = null;
                string[] coluna = null;

                reader.ReadLine();

                while (reader.ReadLine() != null)
                {
                    linha = reader.ReadLine();
                    coluna = linha.Split(',');
                    
                    if (coluna[29].Equals(constelacao))
                    {
                        listaConstelacao.Add(coluna);
                    }
                }

                return listaConstelacao;
            }
            catch (Exception Ioe)
            {
                MessageBox.Show("Erro: " + Ioe);
                return null;
            }
            finally
            {
                reader.Close();
                
            }
        }
        public string[] agulhaEscarlate()
        {
            List<string[]> listaSco = new List<string[]>();
            listaSco = pesquisaConstelacao("Sco");

           

            List<Star> starScoList = new List<Star>();
            foreach(var estrela in listaSco)
            {
                Star star = new Star(estrela[0], estrela[6], Convert.ToDouble(estrela[13], CultureInfo.InvariantCulture));
                starScoList.Add(star);
            }
            var listaScoOrdenada = starScoList.OrderBy(x => x.getMag());
            var id  = listaScoOrdenada.First().getId();
            foreach(var estrela in listaSco)
            {
                if (id.Equals(estrela[0]))
                {
                    return estrela;
                }
            }
            return null;
        }
        
        public void cvsParaSQL()
        {//10 maiores magnitudes
            StreamReader stream = new StreamReader(@"D:\\Facul\\Persistencia\\hypparcos\\hygdata\\hygdata_v3.csv");
            List<Star> listaEstrelas = new List<Star>();

            try
            {
                string linha = null;
                string[] coluna = null;
                stream.ReadLine();

                while (stream.ReadLine()!=null)
                {
                    linha = stream.ReadLine();
                    coluna = linha.Split(',');
                    Star star = new Star(coluna[0],coluna[1],coluna[2],coluna[3],coluna[4],coluna[5],coluna[6],coluna[7],coluna[8],coluna[9],coluna[10],coluna[11],coluna[12],coluna[13],coluna[14],coluna[15],coluna[16],coluna[17],coluna[18],coluna[19],coluna[20],coluna[21],coluna[22],coluna[23],coluna[24],coluna[25],coluna[26],coluna[27],coluna[28],coluna[29],coluna[30],coluna[31]);
                    listaEstrelas.Add(star)

                }

                

                var listaOrdenada = listaEstrelas.OrderByDescending(m => m.getMag());

                for (int i = 0; i < listaOrdenada.Count(); i++)
                {
                    Star estrela = listaOrdenada.ElementAt(i);

                    Console.WriteLine("id: " + estrela.getId() + " Magnitude: " + estrela.getMag() + " Nome: " + estrela.getNome());
                    
                }

                return listaOrdenada.ToList();

            }

    }

    class Star {

        string id { get; set; }
        string proper { get; set; }
        double mag { get; set; }
        double dist { get; set; }

        public Star(string i, string nome, double magnitude)
        {
            this.id = i;
            this.proper = nome;
            this.mag = magnitude;
        }

        public Star(string i, string nome, double magnitude, double distancia)
        {
            this.id = i;
            this.proper = nome;
            this.mag = magnitude;
            this.dist = distancia;
        }

        public double getMag()
        {
            return this.mag;
        }

        public string getNome()
        {
            return this.proper;
        }

        public string getId()
        {
            return this.id;
        }

        public double getDist()
            {
                return this.dist;
            }
    }

}
