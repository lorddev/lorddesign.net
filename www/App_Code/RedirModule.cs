using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;

public class RedirModule : IHttpModule
{
  public RedirModule()
  {
  }

  public String ModuleName
  {
    get { return "RedirModule"; }
  }

  // In the Init function, register for HttpApplication 
  // events by adding your handlers.
  public void Init(HttpApplication application)
  {
    application.BeginRequest += this.Application_BeginRequest;
    application.EndRequest += this.Application_EndRequest;
  }

  private void Application_BeginRequest(Object source, EventArgs e)
  {

    // Create HttpApplication and HttpContext objects to access
    // request and response properties.
    HttpApplication application = (HttpApplication)source;
    HttpContext context = application.Context;
    try
    {
      // if (context.Request.Path.EndsWith(".html"))
      // {
        // if (context.Request.Path.EndsWith("/archives/2004/11/as_far_as_the_e.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/11/as-far-as-east-is-from-west.html");
        // }
        // else if (context.Request.Path.EndsWith("/archives/2004/11/faith_like_a_bo.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/11/faith-like-book.html");
        // }
        // else if (context.Request.Path.EndsWith("/archives/2004/11/jacobs_presumpt.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/11/jacobs-presumption.html");
        // }
        // else if (context.Request.Path.EndsWith("/archives/2004/11/sometimes_you_c.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/11/sometimes-you-cant-make-it-on-your-own.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/11/"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004_11_01_archive.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/sex_and_the_sup.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/sex-and-supremacy-of-christ.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/on_sunbathing.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/on-sunbathing.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/omygish.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/choosing-gods-will.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/winter_interces.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/winter-intercession.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/our_future_hope.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/our-future-hope.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2004/12/our_future_hope.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004/12/our-future-hope.html");
        // }
        // //else if (context.Request.Path.Contains("/archives/2004/12/"))
        // //{
        // //  context.Response.Status = "301 Moved Permanently";
        // //  context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2004_12_01_archive.html");
        // //}
        // else if (context.Request.Path.Contains("/archives/2005/01/i_still_havent_1.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/01/i-still-havent-found-what-im-looking.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/02/i_still_havent.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2008/06/i-still-havent-found-what-im-looking.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/02/the_blessedness.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/02/blessedness-of-possessing-nothing.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/02/simplicity.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/02/simplicity-and-surrender.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/04/spiritual_bankr.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/04/spiritual-bankruptcy.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/04/removing_the_ve.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/04/removing-veil.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/05/the_high_price.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2008/06/high-price-of-packer-pride.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/05/apprehending_go.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/05/apprehending-god.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/05/a_new_agenda_fo_1.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/05/new-agenda-for-our-talk.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/02/dell_dimension_1.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/02/dell-dimension-2350-mods-continued.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/01/modding_a_dell.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/01/modding-dell.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2007/08/my_first_viral.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2007/08/my-first-viral-video-if-you-can-call.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2005/08/simplifying_thi.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2005/08/simplifying-things.html");
        // }
        // else if (context.Request.Path.Contains("/archives/2006/07/giving_is_a_par.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2006/07/giving-is-party.html");
        // }
        // else if (context.Request.Path.Contains("/archives/calvary_newsletter/"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/search/label/Calvary%20Newsletter");
        // }
        // else if (context.Request.Path.Contains("/archives/book_reviews/"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/search/label/Book%20Reviews");
        // }
        // else if (context.Request.Path.Contains("/archives/2007/08/as_a_good_soldi.html"))
        // {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://mustfollow.blogspot.com/2007/08/as-good-soldier-of-christ-jesus-2-tim.html");
        // }
// else if (context.Request.Path.Contains("/archives/2007/02/"))
// {
          // context.Response.Status = "301 Moved Permanently";
          // context.Response.AddHeader("Location", "http://blog.lorddesign.net/");

// }
        // else
        // {
          // throw new Exception("Unhandled html page requested: " + context.Request.Path);
        // }
      // }
      
      string url = context.Request.Url.ToString().ToLower();
      
      if (url.Contains("lorddesign.net/weblog") || url.Contains("blog.lorddesign.net"))
      {
        context.Response.Status = "301 Moved Permanently";
        context.Response.AddHeader("Location", "http://mustfollow.blogspot.com");
      }
      
      //context.Response.Write(url);
      //throw new Exception(url);
      
    }
    catch (Exception ex)
    {
      // Code that runs when an unhandled error occurs.  Should allow us to collect a list of all 
      // blog pages that need to be redirected.
      ErrorMail em = new ErrorMail(ConfigurationManager.AppSettings["MailFrom"],
        ConfigurationManager.AppSettings["DevMailTo"], ConfigurationManager.AppSettings["MailServer"]);
      em.Send(ex);
    }

    //    context.Response.Write(@"<h1><font color=red>
    //            HelloWorldModule: Beginning of Request
    //            </font></h1><hr>");
  }

  private void Application_EndRequest(Object source, EventArgs e)
  {
    //    HttpApplication application = (HttpApplication)source;
    //    HttpContext context = application.Context;
    //    context.Response.Write(@"<hr><h1><font color=red>
    //            HelloWorldModule: End of Request</font></h1>");
  }

  public void Dispose()
  {
  }
}