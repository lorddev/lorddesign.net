Imports Microsoft.VisualBasic
Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Mail
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' By Aaron Lord (aaron@lorddesign.net)
' Last modified 8/12/05

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

            Dim Conn As SqlConnection = New SqlConnection(ConfigurationSettings.AppSettings("ConnStr"))
            Dim strSQL_Photo As String = "select top 1 photo_filename, footer_color from tblRandomPhotos order by newid()"
            Dim cmdPhoto As SqlCommand = New SqlCommand(strSQL_Photo, Conn)
            Dim dtrPhoto As SqlDataReader
            Conn.Open()
            dtrPhoto = cmdPhoto.ExecuteReader()
            While dtrPhoto.Read
                hccPhoto.Style.Item("background-image") = "url(images/rotation/" & _
                  dtrPhoto.Item("photo_filename").ToString & ")"
                hccInnerFoot.Style.Item("color") = dtrPhoto.Item("footer_color").ToString
            End While

            Conn.Close()

            'Write ASP.NET to text file.
            Dim sr As StreamReader = File.OpenText("C:\websites1\lorddesign.net\default.aspx")
            Dim sw As StreamWriter = New StreamWriter("C:\websites1\lorddesign.net\write\aspx.html")
            sw.WriteLine("<html xmlns=""http://www.w3.org/1999/xhtml"">")
            sw.WriteLine("<head>")
            sw.WriteLine("</head>")
            sw.WriteLine("<body>")
            sw.WriteLine("<pre>")
            Dim input As String
	    input = sr.ReadToEnd()
	    input = Replace(input, "&", "&amp;") 'Allows this code to be viewed properly in html
	    input = Replace(input, "<", "&lt;")
            input = Replace(input, ">", "&gt;")
            sw.Write(input)
            sw.WriteLine("</pre>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")
            sr.Close()
            sw.Close()

            'Write VB to text file.
            sr = File.OpenText("C:\websites1\lorddesign.net\_vb\LD_Home.vb")
            sw = New StreamWriter("C:\websites1\lorddesign.net\write\code_behind.html")
            sw.WriteLine("<html xmlns=""http://www.w3.org/1999/xhtml"">")
            sw.WriteLine("<head>")
            sw.WriteLine("</head>")
            sw.WriteLine("<body>")
            sw.WriteLine("<pre>")
	    input = sr.ReadToEnd()
	    input = Replace(input, "&", "&amp;") 'Allows this code to be viewed properly in html
	    input = Replace(input, "<", "&lt;")
            input = Replace(input, ">", "&gt;")
            sw.Write(input)
            sw.WriteLine("</pre>")
            sw.WriteLine("</body>")
            sw.WriteLine("</html>")
            sr.Close()
            sw.Close()

        End If
    End Sub

    Sub btnContactArrow_Click(ByVal sender As Object, ByVal e As ImageClickEventArgs)
        If hccContact.Visible = False Then
            hccContact.Visible = True
            btnContactArrow.ImageUrl = "images/up-arrow.gif"
        ElseIf hccContact.Visible = True Then
            hccContact.Visible = False
            btnContactArrow.ImageUrl = "images/down-arrow.gif"
        End If

    End Sub

    Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Page.IsValid Then

            'Check to make sure that the email address is in the right format
            Dim strEmail As String, strPattern As String
            strEmail = txtEmail.Text
            strPattern = "^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,3}$"
            If Not Regex.IsMatch(strEmail, strPattern, RegexOptions.IgnoreCase) Then
                'Invalid email address!
                lblErrMsg.Text = "You did not enter a valid e-mail address.<br/>" & vbCr & _
                   "Please try again.<br/>" & vbCr
            Else
                'Check to see if the domain name entered in the email address exists
                Dim strDomain As String
                strDomain = strEmail.Substring(strEmail.IndexOf("@") + 1)
                'Attempt to Resolve the hostname
                Dim strIP As String

                Try
                    strIP = DNS.Resolve(strDomain).AddressList(0).ToString()
                    'If we reach here, we have a valid email address, so do whatever processing needs 
                    'to be done.
                    SendMail()

                Catch se As SocketException
                    'The DNS resolve was unsuccessful...
                    strIP = se.Message
                    If se.ErrorCode = 11004 Then 'must be x@sbcglobal.net
                        If strDomain = "sbcglobal.net" Then 'send it anyway
                            SendMail()
                        Else
                            lblErrMsg.Text = "The DNS resolve of your hostname was unsuccessful." & vbCr & _
                            "Try a different address.<br/>" & vbCr
                        End If
                    End If
                End Try

            End If
        End If
    End Sub

    Sub SendMail()
        Dim objMail As New MailMessage
        objMail.BodyFormat = MailFormat.Text
        objMail.To = "support@lorddesign.net"
        objMail.From = txtEmail.Text
        objMail.Subject = "Message posted from lorddesign.net"
        objMail.Body = txtMsg.Text
        SmtpMail.SmtpServer = "localhost"
        SmtpMail.Send(objMail)

        objMail = Nothing

        'Make changes to page after submission.
        btnSubmit.Enabled = False
        lblErrMsg.Text = "Thank you. Your message has been sent."

    End Sub

End Class