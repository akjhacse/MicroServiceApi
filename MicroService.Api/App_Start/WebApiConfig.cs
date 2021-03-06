﻿using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using MicroService.Api.Middleware;

namespace MicroService.Api {

   public static class WebApiConfig {

      public static void Register(HttpConfiguration config) {
         // Web API routes
         config.MapHttpAttributeRoutes();

         config.Routes.MapHttpRoute(
             name: "DefaultApi",
             routeTemplate: "api/{controller}/{id}",
             defaults: new { id = RouteParameter.Optional }
         );

         config.Services.Replace(typeof(IExceptionHandler), new WebApiExceptionHandler());
      }
   }
}
