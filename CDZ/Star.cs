using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDZ
{
    public class Star
    {

        string id { get; set; }
        string proper { get; set; }
        double mag { get; set; }
        double dist { get; set; }

        public Star()
        {

        }

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
