using ProyectoMVC5.App_Start;
using System;
using System.Web.Routing;

namespace ProyectoMVC5
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

    }
}