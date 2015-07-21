using System;
using System.Collections.Generic;
using System.IO;

namespace BRulesClientePostTextosSMS
{
    public class GuardaArchivo
    {
        public GuardaArchivo() { }

        public bool guardaArchivosYEstadisticas(string ubicaArchivo, string texto, List<int> estadisticas)
        {
            bool lbreturn = false;

            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    sw.WriteLine("-----------------------------------------");
                    string[] parrafos = texto.Split(',');
                    foreach (var item in parrafos)
                    {
                        sw.WriteLine(item);
                    }

                    sw.WriteLine("Las estadisticas del archivo analizado son las siguientes:");

                    sw.WriteLine("Palabras que terminan con la letra N: " + estadisticas[0].ToString());
                    sw.WriteLine("Oraciones dentro del archivo: " + estadisticas[1].ToString());
                    sw.WriteLine("Parrafos dentro del archivo: " + estadisticas[2].ToString());
                    sw.WriteLine("Caracteres dentro del archivo que no son N: " + estadisticas[3].ToString());

                    using (FileStream fs = new FileStream(ubicaArchivo, FileMode.Append, FileAccess.Write))
                    {
                        byte[] buffer = System.Text.Encoding.Default.GetBytes(sw.ToString());
                        fs.Write(buffer, 0, buffer.Length);
                        lbreturn = true;
                    }
                }
            }
            catch (Exception)
            {
                lbreturn = false;
            }

            return lbreturn;
        }
    }
}
