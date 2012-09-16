// -----------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Lord Design">
//   Copyright (c) 2012 Lord Design, Paradise, California.
// </copyright>
// <created>09/15/2012 3:26 PM</created>
// <author>aaron</author>
// -----------------------------------------------------------------------

namespace LordDesign.Web
{
    using System;
    using System.Web;

    using LordDesign.Utilities;

    public class Global : HttpApplication
    {
        #region Methods

        private void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown
        }

        private void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs
            var error = this.Server.GetLastError().GetBaseException();
            Logger.Log(error);
        }

        private void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
        }

        private void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.
        }

        private void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started
        }

        #endregion
    }
}