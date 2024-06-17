using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebestoinost
{
    public class Chovekodni:Deinost
    {
        private double chovekoChasove;
        private double tarifaChas;

        public Chovekodni(string code,string vidDeinost,double chovekochasove,double tarifaChas)
        {
            this.ChovekoChasove = chovekoChasove;
            this.TarifaChas = tarifaChas;
        }
        public Chovekodni()
        {
            
        }
        
        public double ChovekoChasove
        {
            get { return chovekoChasove; }
            set {  chovekoChasove = value; }
            
        }
        
        public double TarifaChas
        {
            get { return tarifaChas; }
            set { tarifaChas = value; }
        }

        public override string Count(List<Chovekodni> chovekodnii)
        {
            int chovekoChasoveChovekodni = 0;

            int tarifaChasChovekodni = 0;

            chovekoChasoveChovekodni = chovekodnii.Count();

            foreach (var item in chovekodnii)
            {
                if (item.TarifaChas.("None") == false)
                {
                    tarifaChasChovekodni++;
                }
            }

            return $" : {chovekoChasoveChovekodni}\n" +
                $" : {tarifaChasChovekodni}";


        }

    }
}
