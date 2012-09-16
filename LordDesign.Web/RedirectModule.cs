// -----------------------------------------------------------------------
// <copyright file="RedirectModule.cs" company="Lord Design">
//   Copyright (c) 2012 Lord Design, Paradise, California.
// </copyright>
// <created>09/15/2012 5:36 PM</created>
// <author>aaron</author>
// -----------------------------------------------------------------------

using System;
using System.Web;

using LordDesign.Utilities;

namespace LordDesign.Web
{
    using System.Collections.Generic;
    using System.Linq;

    public class RedirectModule : IHttpModule
    {
        #region Public Properties

        public String ModuleName
        {
            get
            {
                return "RedirectModule";
            }
        }

        #endregion

        #region Public Methods and Operators

        public void Dispose()
        {
        }

        // In the Init function, register for HttpApplication 
        // events by adding your handlers.
        public void Init(HttpApplication application)
        {
            application.BeginRequest += BeginRequest;
            application.EndRequest += EndRequest;
        }

        #endregion

        #region Methods

        private static void BeginRequest(object source, EventArgs e)
        {
            var application = source as HttpApplication;
            var context = application.Context;
            try
            {
                // Only redirect for html or htm or aspx.
                string[] filteredTypes = { ".aspx", ".html", ".htm" };
                string filePath = context.Request.FilePath;
                string fileExtension = VirtualPathUtility.GetExtension(filePath);

                if (!filteredTypes.Contains(fileExtension))
                {
                    return;
                }

                var path = context.Request.Url.AbsolutePath.ToLower();
                if (path == "/" || path == "/index.html")
                {
                    return;
                }

                string url = context.Request.Url.ToString().ToLower();

                if (url.Contains("lorddesign.net/weblog") || url.Contains("blog.lorddesign.net"))
                {
                    context.Response.Status = "301 Moved Permanently";
                    context.Response.AddHeader("Location", "http://mustfollow.wordpress.com/");
                    return;
                }

                context.Response.Status = "301 Moved Permanently";
                context.Response.AddHeader("Location", "http://www.lorddesign.net/");

                //context.Response.Write(url);
                //throw new Exception(url);
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
            }
        }

        private static void EndRequest(object source, EventArgs e)
        {
            //    HttpApplication application = (HttpApplication)source;
            //    HttpContext context = application.Context;
            //    context.Response.Write(@"<hr><h1><font color=red>
            //            HelloWorldModule: End of Request</font></h1>");
        }

        #endregion
    }
}