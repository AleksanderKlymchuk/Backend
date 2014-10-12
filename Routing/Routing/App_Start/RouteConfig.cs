using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace Routing
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {


            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            
            //Setup a Route that uses “shop” as static URL segments and matches URL’s like
// host/shop/books/
// host/shop/books/programming/pro-asp.net-mvc5
// host/shop/movies/action
// host/shop/movies/drama/the-shining
//What is the correct order of routes when you have multiple routes?

            routes.MapRoute("", "shop/{books}/{programming}", new { action = "index", controller = "Home" });


            routes.MapRoute(
            name: "Default",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Home", action = "index", id = UrlParameter.Optional }




////////////////////////////////////////////////////////////////////
//Setup a Route that has an id as the third optional segment that accepts only integers as value. 
//Is there more than one way of doing it?

            //routes.MapRoute(
            //    name: "Default",
            //2
            //    // url: "{controller}/{action}",

            //    url: "{controller}/{action}/{*id}",
            //    defaults: new { controller = "Home", action="index"},
            //    //3
            //    //constraints:new {id = new IntRouteConstraint()}
            //    //4 int only allowed
            //    constraints: new { id = new RangeRouteConstraint(10, 100) }
            //    //new {id = @"\d+"} regular expresion

            //);

//Setup a Route that accepts any number of segments
                // routes.MapRoute("Myroute", "{controller}/{action}/{*id}", new { controller = "Home", action = "Index" });

            
           //id required
           //defaults: new { controller = "Home", action="index"}

                );


             }
    }
}

//,id=UrlParameter.Optional
//Route myRoute = new Route("{controller}/{action}",new MvcRouteHandler());
//routes.Add("Myroute",myRoute);

 //routes.MapRoute("","shop/{controller}/{category}/{title}", new { action = "Home" });
// routes.MapRoute("Test", "shop/{type}/{subtype}/{item}", new { controller = "Home", action = "Home" });
