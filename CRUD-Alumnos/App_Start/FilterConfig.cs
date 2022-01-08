using System.Web;
using System.Web.Mvc;

namespace CRUD_Alumnos
{
    //ACA SE PUEDE CONFIGURAR, MÁS QUE TODO PARA LA SEGURIDAD CON UN PROYECTO TIENE AUTENTICACION DE USUARIOS
    //Aca puedo configurar que tipo de seguridad quiero para más que todo para personalizarla por ejemplo
    //cuando utilizo roles de usuarios(administrador, cliente, etc) y cada rol va a entrar a ciertos lugares
    //paginas
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
