using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using MODELO.seguridad;


namespace Servicios
{
    public static class ServiciosUsuario
    {
       
            public static  bool SendMail(Usuario usuario, string claveNueva)
            {

                string Body = $@"
                 <h1 style=""color: dodgerblue;"">¡Bienvenido a Nuestro Servicio!</h1>
                 <h1 style=""color: darkorange;"">Sistema de estacionamiento</h1>
                 <h2 style=""color: dodgerblue;"">Su contraseña de ingreso es: {claveNueva}</h2>
                 <h2 style=""color: dodgerblue;"">Gracias por unirte a nuestra comunidad.</h2>";

                string from = "softwareestacionamiento@gmail.com";
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(from);
                    mail.To.Add(usuario.USU_MAIL);

                    mail.Subject = "Hola " + usuario.PER_NOMBRE;
                    mail.Body = Body;
                    mail.IsBodyHtml = true;

                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(from, "ulax yede mayq zzfi");
                    client.Send(mail);
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                return true;
            }
        public static string GenerarPassword()
        {
            var random = new Random();
            return string.Concat(Enumerable.Range(0, 5).Select(_ => random.Next(0, 9).ToString()));
        }
        public static string EncriptarClave(string clave)
            {
                StringBuilder sb = new StringBuilder();
                using (SHA256 sha256 = SHA256.Create())
                {
                    Encoding enc = Encoding.UTF8;
                    if (!String.IsNullOrEmpty(clave))
                    {
                        byte[] resoult = sha256.ComputeHash(enc.GetBytes(clave));
                        foreach (byte b in resoult)
                        {
                            sb.Append(b.ToString("x2"));
                        }
                    }
                }
                return sb.ToString();
            }

    }
}
