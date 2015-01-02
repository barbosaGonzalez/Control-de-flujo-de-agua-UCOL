using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail; //Directiva 1
using System.Net;  //Directiva 2
using System.Web; //Directiva 3

namespace Proyecto_integrador
{
    class EnviarEmail
    {
        public void Enviar(string sensor)
        {
            MailMessage mail = new MailMessage("torby@outlook.com", "torby@outlook.com", "Prueba sensor de flujo", "En el " + sensor + " se sobrepaso el limite");
            SmtpClient Cliente = new SmtpClient("smtp.live.com");
            Cliente.Port = 587;
            Cliente.Credentials = new System.Net.NetworkCredential("torby@outlook.com", "e.-94B:_41");
            Cliente.EnableSsl = true;
            Cliente.Send(mail);
        }
    }
}
