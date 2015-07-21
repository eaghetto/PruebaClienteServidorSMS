using BRulesClientePostTextosSMS;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.UI;

namespace ClientePostTextosSMS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblTemporarl.Text = "Haga Click en el boton para Generar los Posts.";
            }
        }

        protected void btnGenerarPost_Click(object sender, EventArgs e)
        {
            try
            {
                string pathArchivos = Request.PhysicalApplicationPath + @"\Archivos\ValidaEstadisticas.txt";
                List<int> lstEstadisticas = new List<int>();
                string texto = string.Empty;
                LblRutaArchivo.Text = string.Empty;

                CreaArchivo ca = new CreaArchivo();
                GuardaArchivo ga = new GuardaArchivo();

                for (int i = 0; i < 1000; i++)
                {
                    texto = ca.postCreado();

                    HttpClient client = new HttpClient();
                    HttpResponseMessage wcfResponse = client.GetAsync("http://localhost:3261/ServicePostTextos.svc/ValidaEstadisticasPostTexto/" + texto).Result;
                    HttpContent stream = wcfResponse.Content;
                    var data = stream.ReadAsStringAsync();

                    string[] resultado = data.Result.Split(',');

                    lstEstadisticas.Add(Convert.ToInt32(resultado[0].ToString().Replace("[", "").Replace("]", "")));
                    lstEstadisticas.Add(Convert.ToInt32(resultado[1].ToString()));
                    lstEstadisticas.Add(Convert.ToInt32(resultado[2].ToString()));
                    lstEstadisticas.Add(Convert.ToInt32(resultado[3].ToString().Replace("[", "").Replace("]", "")));

                    ga.guardaArchivosYEstadisticas(pathArchivos, texto, lstEstadisticas);

                    texto = string.Empty;
                    lstEstadisticas.Clear();
                }

                LblRutaArchivo.Text = "Consulte el archivo de resultados en la siguiente ruta: " + pathArchivos;
            }
            catch (Exception ex)
            {
                MostrarMensaje("A ocurrido el siguiente error: " + ex.Message);
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this.Page, typeof(Page), "ALERTA", "alert(\"" + mensaje + "\");\n", true);
        }
    }
}