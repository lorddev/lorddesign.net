Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

' By Aaron Lord (aaron@lorddesign.net).
' Last modified 7/9/2006.
' 7/9/2006 - Updated to ASP.NET 2.0 methods, refactored VB and JS code a bit,
' improved design for Mozilla browsers.

Public Class LD_Home
    Inherits Page

    Public lblCounter, lblErrMsg As Label
    Public txtEmail, txtMsg As TextBox
    Public hccPhoto, hccInnerFoot, hccContact As HtmlContainerControl
    Public btnSubmit As Button
    Public btnContactArrow As ImageButton

    Public Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then

            lblCounter.Text = Application("Counter").ToString & " | " & _
              DateTime.Now()

            Dim Conn As SqlConnection = New SqlConnection(ConfigurationManager.AppSettings("ConnStr"))

            Dim strSQL_Photo As String = "SELECT TOP 1 photo_filename, footer_color " & _
              "FROM tblRandomPhotos WHERE photo_filename NOT LIKE '%st-andrews.jpg%' " & _
              "ORDER BY NEWID()"

            Dim cmdPhoto As SqlCommand = New SqlCommand(strSQL_Photo, Conn)
            Dim dtrPhoto As SqlDataReader

            Conn.Open()
            dtrPhoto = cmdPhoto.ExecuteReader()
            If dtrPhoto.Read Then
                hccPhoto.Style.Item("background-image") = "url(images/rotation/" & _
                  dtrPhoto.Item("photo_filename").ToString & ")"
                hccInnerFoot.Style.Item("color") = dtrPhoto.Item("footer_color").ToString
            End If

            dtrPhoto.Close()
            dtrPhoto = Nothing

            Conn.Close()
            Conn = Nothing

            ' Write ASP.NET to text file.
            Call BuildTextFile("C:\websites1\lorddesign.net\default.aspx", _
              "C:\websites1\lorddesign.net\write\aspx.html")

            ' Write VB to text file.
            Call BuildTextFile("C:\websites1\lorddesign.net\_vb\LD_Home.vb", _
              "C:\websites1\lorddesign.net\write\code_behind.html")

            Call BuildOnloadScript(False)

        End If

    End Sub

    Sub BuildOnloadScript(ByVal bIsPostBack As Boolean)
        Dim theHead As HtmlGenericControl
        theHead = Page.FindControl("theHead")

        Dim strScript As String = vbCrLf & "    window.onload = function(){" & vbCrLf & _
            "        loadVars();" & vbCrLf

        If bIsPostBack Then
            strScript &= "        btn_contact_Click(document.getElementById('btn_contact'));" & vbCrLf
        End If

        strScript &= "    }" & vbCrLf

        Dim NewScript As New HtmlGenericControl("script")
        NewScript.InnerHtml = strScript

        theHead.Controls.Add(NewScript)

    End Sub

    Sub BuildTextFile(ByVal strReadFile As String, ByVal strWriteFile As String)

        Dim sr As StreamReader = File.OpenText(strReadFile)
        Dim sw As StreamWriter = New StreamWriter(strWriteFile)

        sw.WriteLine("<html xmlns=""http://www.w3.org/1999/xhtml"">")
        sw.WriteLine("<head>")
        sw.WriteLine("</head>")
        sw.WriteLine("<body>")
        sw.WriteLine("<pre>")

        Dim input As String = sr.ReadToEnd()

        ' Allows code to be viewed properly in html.
        input = Replace(input, "&", "&amp;")
        input = Replace(input, "<", "&lt;")
        input = Replace(input, ">", "&gt;")

        sw.Write(input)
        sw.WriteLine("</pre>")
        sw.WriteLine("</body>")
        sw.WriteLine("</html>")

        sr.Close()
        sw.Close()

    End Sub

    Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Page.IsValid Then

            ' Check to make sure that the email address is in the right format.
            Dim strEmail As String, strPattern As String
            strEmail = txtEmail.Text
            strPattern = "^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,3}$"

            If Not Regex.IsMatch(strEmail, strPattern, RegexOptions.IgnoreCase) Then
                ' Invalid email address!
                lblErrMsg.Text = "You did not enter a valid e-mail address.<br/>" & vbCr & _
                   "Please try again.<br/>" & vbCr
            Else
                ' Check to see if the domain name entered in the email address exists.
                Dim strDomain As String
                strDomain = strEmail.Substring(strEmail.IndexOf("@") + 1)

                ' Attempt to Resolve the hostname.
                Dim strIP As String

                Try
                    strIP = Dns.GetHostEntry(strDomain).AddressList(0).ToString()

                    ' If we reach here, we have a valid email address, so do whatever 
                    ' processing needs to be done.
                    SendMail()

                Catch se As SocketException

                    ' The DNS resolve was unsuccessful.
                    strIP = se.Message
                    If se.ErrorCode = 11004 Then

                        ' Must be address@sbcglobal.net.  They have something going on 
                        ' which prevents IP address resolution.
                        If strDomain = "sbcglobal.net" Then

                            ' Send it anyway.
                            Call SendMail()
                        Else
                            lblErrMsg.Text = "The DNS resolve of your hostname was unsuccessful." & _
                              vbCrLf & "Try a different address.<br/>" & vbCrLf
                        End If

                    End If

                End Try

            End If

        End If

    End Sub

    Sub SendMail()

        Dim strBodyText As String = Replace(txtMsg.Text, vbCrLf, "<br />" & vbCrLf)

        Dim objMail As New MailMessage(txtEmail.Text, "support@lorddesign.net", _
          "Message posted from lorddesign.net", strBodyText)

        objMail.IsBodyHtml = True

        Dim objSmtp As New SmtpClient("localhost")
        objSmtp.Send(objMail)

        objMail = Nothing
        objSmtp = Nothing

        ' Make changes to page after submission.
        btnSubmit.Enabled = False
        lblErrMsg.Text = "Thank you. Your message has been sent."

        BuildOnloadScript(True)

    End Sub

End Class