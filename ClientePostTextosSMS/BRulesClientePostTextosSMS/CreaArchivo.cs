using System;

namespace BRulesClientePostTextosSMS
{
    public class CreaArchivo
    {
        public CreaArchivo() { }

        public string postCreado()
        {
            Random obj = new Random();
            Random longPalabra = new Random();
            Random puntoOracion = new Random();
            Random noPalabrasxParrafo = new Random();
            Random noParrafos = new Random();

            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

            int longitud = posibles.Length;

            char letra;

            int numParrafos = longPalabra.Next(3, 6);

            string nuevoTexto = string.Empty;
            string palabra = string.Empty;
            string parrafo = string.Empty;


            for (int i = 0; i < numParrafos; i++)
            {
                int numPalabrasParrafo = noPalabrasxParrafo.Next(20, 50);
                int noPalabraFinalOracion = puntoOracion.Next(numPalabrasParrafo - 2);

                for (int j = 0; j < numPalabrasParrafo; j++)
                {
                    int longitudNuevaPalabra = longPalabra.Next(1, 3);

                    for (int k = 0; k < longitudNuevaPalabra; k++)
                    {
                        letra = posibles[obj.Next(longitud)];
                        palabra += letra.ToString();
                    }

                    if (j == noPalabraFinalOracion)
                        parrafo += string.Format(palabra + "{0}", ". ");
                    else if (j + 1 == numPalabrasParrafo)
                        parrafo += string.Format(palabra + "{0}", ".");
                    else
                        parrafo += string.Format(palabra + "{0}", " ");

                    palabra = string.Empty;
                }

                nuevoTexto += string.Format(parrafo + "{0}", ", ");
                parrafo = string.Empty;

            }

            if (nuevoTexto.Length > 260)
                return nuevoTexto.Substring(0, 258) + ".,";
            else
                return nuevoTexto;
        }
    }
}
