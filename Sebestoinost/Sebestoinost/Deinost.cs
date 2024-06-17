using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sebestoinost
{
    public abstract class Deinost
    {
        protected string code;
        protected string vidDeinost;

        public Deinost(string code,string vidDeinost)
        {
            this.code = code;
            this.vidDeinost = vidDeinost;
        }
        public Deinost()
        {
            
        }
        public void Print(Chovekodni chovekod)
        {
            Console.WriteLine($"Kod{code},  vid deinost{vidDeinost}, chovekochasove{chovekod.ChovekoChasove}, tarifa na chas{chovekod.TarifaChas}");
        }
        public abstract string Count(List<Chovekodni> chovekodnii);

        public static void IzvejdaneDanniZaDeynost(List<Deinost> deynosti, string zadadenKod)
        {
            var deynost = deynosti.FirstOrDefault(d => d.code == zadadenKod);
            if (deynost != null)
            {
                Console.WriteLine($"Код: {deynost.code}, Вид дейност: {deynost.vidDeinost}");
            }
            else
            {
                Console.WriteLine("Няма дейност с този код.");
            }
        }

        public static void IzvejdaneDanniZaDeynostSNaiVisokoZaplashtane(List<Deinost> deynosti, string zadadenVidDeynost)
        {
            var naiVisokoZaplashtaneDeynost = deynosti
                .Where(d => d.vidDeinost == zadadenVidDeynost)
                .OfType<Chovekodni>()
                .OrderByDescending(d => d.TarifaChas * d.ChovekoChasove)
                .FirstOrDefault();

            if (naiVisokoZaplashtaneDeynost != null)
            {
                Console.WriteLine($"Код: {naiVisokoZaplashtaneDeynost.code}, Вид дейност: {naiVisokoZaplashtaneDeynost.vidDeinost}, Заплащане: {naiVisokoZaplashtaneDeynost.TarifaChas * naiVisokoZaplashtaneDeynost.ChovekoChasove}");
            }
            else
            {
                Console.WriteLine("Няма дейност от този вид.");
            }
        }

        

    }
}
