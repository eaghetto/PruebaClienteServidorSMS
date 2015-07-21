# PruebaClienteServidorSMS

/***SERVIDOR***/
La carpeta: ValidaREST_PostTextos contiene el Servidor de validaciones.

Abrir el proyecto desde el archivo: ValidaREST_PostTextos.sln

La solucion contiene dos proyectos: 

-> PostTextos.Service : Compilado con las validaciones que arrojan las estadisticas del post analizado. Arquitectura en capas.
-> ValidaREST_PostTextos : Servicio WCF configurado para retornar respuestas JSON.

El servicio levanta en localhost por el puerto: 3261
http://localhost:3261/

/***FIN COMENTARIOS SERVIDOR***/

/***CLIENTE***/
La carpeta: ClientePostTextosSMS contiene el Cliente que genera y guarda los Posts de texto.

Abrir el proyecto desde el archivo: ClientePostTextosSMS.sln

La solucion contiene dos proyectos: 

-> BRulesClientePostTextosSMS : Compilado con las reglas de negocio que genera aleatoriamente los posts y guarda los mismos junto con las estadisticas en un archivo de texto. Arquitectura en capas.
-> ClientePostTextosSMS : Aplicacion Web en Asp.Net invoca el servicio REST a traves de la libreria System.Net.Http (.nuget).

Ejecutar el boton, el cual genera 1000 post de texto y deja el resultado de las estadisticas en la ruta del path donde se corre el cliente.

/***FIN COMENTARIOS CLIENTE***/
