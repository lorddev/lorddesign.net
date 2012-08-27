<%@ Application Language="VB" %>

<script Language="VB" RunAt="Server">

  ' Global.asax must be in VB in order for the Counter to work.  C# won't let you call
  ' the Increment() method because it doesn't consider it a valid member of
  ' System.Object.  - A.L. 6/8/08
  
  Sub Application_Start()
    ' Code that runs on application startup
  End Sub

  Sub Application_End()
    '  Code that runs on application shutdown
  End Sub
  
  Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
    ' Code that runs when an unhandled error occurs
    Dim em As ErrorMail = New ErrorMail(ConfigurationManager.AppSettings("MailFrom"), _
      ConfigurationManager.AppSettings("DevMailTo"), ConfigurationManager.AppSettings("MailServer"))
    em.Send(Server.GetLastError())
  End Sub

  Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
  
    ' Code that runs when a session ends. 
    ' Note: The Session_End event is raised only when the sessionstate mode
    ' is set to InProc in the Web.config file. If session mode is set to StateServer 
    ' or SQLServer, the event is not raised.

  End Sub

</script>

