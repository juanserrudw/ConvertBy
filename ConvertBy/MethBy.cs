using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertBy
{
    public class MethBy
    {
        public static void numBinario(List<int> binario, ref ValorBinario binaryI)
        {
            binario.Reverse();
            int i = 0;
            uint Valor = 0;
            foreach (int Binary in binario)
            {
                if (Binary == 1)
                {
                    Valor = Valor + binaryI.ValorBinario32bit[i];
                }
                i++;
            }
            Console.WriteLine(Valor);
        }

       public static List<int> validarCadenaBy(ref ValorBinario binaryI)
        {
            long rest = 0;
            List<int> valorBy = new List<int> { };
            string restUsuario = string.Empty;
            bool val;
            bool noBinario;
            bool masq32bit;
            do
            {
                do
                {
                    noBinario = false;
                    masq32bit = false;
                    valorBy.Clear();
                    restUsuario = Console.ReadLine();
                    val = Int64.TryParse(restUsuario, out rest);
                }
                while (!val || String.IsNullOrEmpty(restUsuario));
                while (rest > 0)
                {

                    valorBy.Add(Convert.ToInt32(rest % 10));
                    rest = rest / 10;
                }
                valorBy.Reverse();
                if (valorBy.Count() > binaryI.ValorBinario32bit.Count())
                {
                    masq32bit = true;
                }
                else
                {
                    foreach (int Binary in valorBy)
                    {
                        if (Binary < 0 || Binary > 1)
                        {
                            noBinario = true;
                        }
                    }
                }
            }
            while (noBinario || masq32bit);
            return valorBy;
        }

       public static void numeroBinario(int num)
        {
            List<int> valorBy = new List<int> { };
            int res = num;

            do
            {
                int recor = res % 2;
                valorBy.Add(recor);
                res = res / 2;

            } while (res > 0);
            valorBy.Reverse();
            foreach (int B in valorBy)
            {
                Console.Write(B);
            }

        }

       public static int entradaValidacion(int enuno, int endos)
        {
            int res = 0;
            string resusuario = string.Empty;
            bool val = false;
            do
            {
                resusuario = Console.ReadLine();
                val = Int32.TryParse(resusuario, out res);

            } while (!val || res < enuno || res > endos);
            return res;
        }
    }
}
