using System;
using System.Data;
using System.Configuration;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for ErrorMail
/// </summary>
public class ErrorMail
{
  private string m_from;
  public string From
  {
    get
    {
      return this.m_from;
    }
    set
    {
      this.m_from = value;
    }
  }

  private string m_to;
  public string To
  {
    get
    {
      return this.m_to;
    }
    set
    {
      this.m_to = value;
    }
  }

  private string m_smtpServer;
  public string SmtpServer
  {
    get
    {
      return this.m_smtpServer;
    }
    set
    {
      this.m_smtpServer = value;
    }
  }

  public ErrorMail(string from, string to, string smtpServer)
  {
    this.m_from = from;
    this.m_to = to;
    this.m_smtpServer = smtpServer;
  }

  public ErrorMail()
  {
    this.m_from = ConfigurationManager.AppSettings["MailFrom"];
    this.m_to = ConfigurationManager.AppSettings["DevMailTo"];
    this.m_smtpServer = ConfigurationManager.AppSettings["MailServer"];
  }

  public void Send(Exception ex)
  {
    this.Send(String.Empty, ex);
  }

  public void Send(string message, Exception ex)
  {
    if (message != String.Empty)
    {
      message = "Message from code: " + message + "\r\n\r\n";
    }

    string bodyText = "An error was encountered in the lorddesign.net website.\r\n\r\n" + message 
      + ex.ToString() + "\r\n\r\nIP Address: " + HttpContext.Current.Request.UserHostAddress;

    using (MailMessage mail = new MailMessage(this.m_from, this.m_to,
      "Error in LORDDESIGN.NET", bodyText))
    {
      mail.IsBodyHtml = false;

      SmtpClient smtp = new SmtpClient(this.m_smtpServer);
      smtp.Send(mail);
    }
  }
}