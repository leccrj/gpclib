using System;
//using System.Collections.Generic;
//using System.Text;

namespace gpclib
{
    class Ai
    {
        public static string NumeroFormatado(string numero)
        {

            //Retorna o número formatado do Auto de Infração.

            //xxxxx.xxxxx.xxxx.xxxxxx
            //12345.67890.1234.567890

            decimal numeroValido = 0;

            string retorno = numero;

            if (decimal.TryParse(numero, out numeroValido))
            {

                string preNumero;

                if (numeroValido.ToString().Length >= 20)
                {
                    preNumero = numeroValido.ToString();
                }
                else
                {
                    preNumero = numeroValido.ToString().PadLeft(20, '0');
                }

                retorno = preNumero.Substring(0, 5);
                retorno = retorno + "." + preNumero.Substring(5, 5);
                retorno = retorno + "." + preNumero.Substring(10, 4);
                retorno = retorno + "." + preNumero.Substring(14, 6);

            }

            return retorno;

        }

        public static void Main()
        {
            Console.WriteLine(NumeroFormatado("987654"));
            Console.ReadLine();
        }
    }
}