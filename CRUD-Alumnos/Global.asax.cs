using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CRUD_Alumnos
{

    //ACA se registran los eventos cuando arranca el sistema,
    //cuando hay un error, cuando se para el servidor
    public class MvcApplication : System.Web.HttpApplication
    { 

        //Esto se ejecuta cada vez que la aplicación inicia
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
