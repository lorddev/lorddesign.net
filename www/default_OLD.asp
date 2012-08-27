<!--METADATA TYPE="typelib"  
UUID="CD000000-8B95-11D1-82DB-00C04FB1625D"  
NAME="CDO for Windows 2000 Library" --> 
<!--METADATA TYPE="typelib"  
UUID="00000205-0000-0010-8000-00AA006D2EA4"  
NAME="ADODB Type Library" -->
<%@ Language=VBScript %>
<% option explicit %>
<%
Dim ErrMsg, doProcess, strURL
strURL = Request.ServerVariables("URL")
dim longpath, path, loc
path = Request.ServerVariables("SCRIPT_NAME")
loc = instrRev(path,"/") 
path = "http://" & Request.ServerVariables("SERVER_NAME") & "/" '& left(path, len(path) - loc)
longpath = "http://" & Request.ServerVariables("SERVER_NAME") & Request.ServerVariables("SCRIPT_NAME")
'tells counter not to increment when the form is being submitted
Dim ctr
If not Request.ServerVariables("HTTP_REFERER") = longpath then
  'ctr = Counter.Set("lorddesign", 242)
  ctr = Counter.Increment("lorddesign")
Else
  ctr = Counter.Get("lorddesign")
End if

If Request.ServerVariables("REQUEST_METHOD") = "POST" then
  Dim mail_from, body
  mail_from = Request.Form("Email")
  body = Request.Form("msg")
  If mail_from = "" then
    ErrMsg = "You did not enter an e-mail address.<br>" & vbCr & _
	  "Please try again.<br>" & vbCr
	doProcess = False
  ElseIf InStr(1, mail_from, "@", vbBinaryCompare) = 0 Then
    ErrMsg = "You did not enter a valid e-mail address.<br>" & vbCr & _
	  "Please try again.<br>" & vbCr
	doProcess = False
  ElseIf InStr(1, mail_from, ".", vbBinaryCompare) = 0 Then
    ErrMsg = "You did not enter a valid e-mail address.<br>" & vbCr & _
	  "Please try again.<br>" & vbCr
	doProcess = False
  ElseIf body = "" then
    ErrMsg = "You did not enter any content into the message field.<br>" & vbCr & _
	  "Please try again.<br>" & vbCr
	doProcess = False
  Else
	Dim objMail, mail_to, subject
	mail_to = "aaron@lorddesign.net"
	subject = "Message posted from lorddesign.net"
	
	'Thanks to sitepoint.com for info on updating from CDONTS to CDOSYS
    Set objMail = Server.CreateObject("CDO.Message")
	Dim objConfig
	Set objConfig = Server.CreateObject("CDO.Configuration")
	objConfig.Fields(cdoSendUsingMethod) = cdoSendUsingPort  
	objConfig.Fields(cdoSMTPServer) = "127.0.0.1" 
	objConfig.Fields(cdoSMTPServerPort) = 25  
	objConfig.Fields(cdoSMTPAuthenticate) = cdoAnonymous

	'Update configuration 
	objConfig.Fields.Update 
	Set objMail.Configuration = objConfig 
	
    objMail.From = mail_from
	objMail.Cc = mail_from
    objMail.To = mail_to
	objMail.Sender = "form@lorddesign.net"
    objMail.Subject = subject
    objMail.TextBody = body
    objMail.Send
	
	Set objMail = Nothing
	Set objConfig = Nothing
	
	ErrMsg = "Thank you.  Your message has been sent."
  End if
End if
%>
<html>
<HEAD>
<TITLE>: lord design :</TITLE>
<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=iso-8859-1">
<link rel="stylesheet" href="style_sheet.css" type="text/css">
</HEAD>
<BODY BGCOLOR="#04203F" text="#829EBD" style="background-color: 
#04203f; background-image: url(images/dread-bg.gif); background-repeat: no-repeat;
vertical-align: bottom; margin: 0;">
<table width="100%" cellpadding="0" cellspacing="0" border="0" style="height: 100%;">
  <tr> 
    <td align="right" valign="top"> 
      <!--begin content table-->
      <table width="216" cellpadding="0" cellspacing="0" border="0" style="position:
	    relative; width: 216px; height: auto; left: -90px; top: 100px; z-index: 2;">
        <tr> 
          <td width="216" height="18" style="height: 97px;"><img src="images/lord-design_title.gif" width="216" height="97" alt="" /></td>
        </tr>
        <tr> 
          <td width="216" height="18" style="height: 18px;">&nbsp;</td>
        </tr>
        <tr> 
          <td width="216"> 
            <table width="216" cellpadding="0" cellspacing="0" border="0" id="webtitle"
			  style="width:216px; height:18px; background: url(images/gradients/category_bar.gif) repeat;">
              <tr> 
                <td width="108" height="18"> <img src="images/web-development.gif" alt="web development" width="108" height="18"></td>
                <td width="90" height="18">&nbsp;</td>
                <td width="18" height="18"> <img src="images/down-arrow.gif" alt="" width="18" height="18" id="wdown" border="0" 
					style="cursor: pointer" onClick="Wdown_Click();" /></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr> 
          <td width="216" valign="top" class="bodytext"><div id="webcell" class="bodytext"></div></td>
        </tr>
        <tr> 
          <td width="216"> 
            <table width="216" cellpadding="0" cellspacing="0" border="0"
			  style="width:216px;height:18px;background: url(images/gradients/category_bar.gif) repeat;">
              <tr> 
                <td width="108"> <img src="images/digital-media.gif" alt="digital media" width="108" height="18"></td>
                <td width="90" height="18">&nbsp; </td>
                <td width="18" height="18"><img id="dmdown" src="images/down-arrow.gif" alt="" width="18" height="18" style="cursor: pointer" onClick="DmDown_Click();" /></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr> 
          <td width="216" valign="top" class="bodytext"><div id="mediacell" class="bodytext"></div></td>
        </tr>        <tr> 
          <td width="216"> 
            <table width="216" cellpadding="0" cellspacing="0" border="0"
			  style="width:216px;height:18px;background: url(images/gradients/category_bar.gif) repeat;">
              <tr> 
                <td width="108"> <img src="images/graphic-design.gif" alt="graphic design" width="108" height="18"></td>
                <td width="90" height="18">&nbsp; </td>
                <td width="18" height="18"><img id="gdown" src="images/down-arrow.gif" alt="" width="18" height="18" style="cursor: pointer" onClick="Gdown_Click();" /></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr> 
          <td width="216" valign="top" class="bodytext"><div id="designcell" class="bodytext"></div></td>
        </tr>
        <tr> 
          <td width="216"> 
            <table width="216" cellpadding="0" cellspacing="0" border="0"
			  style="width:216px;height:18px;background: url(images/gradients/category_bar.gif) repeat;">
              <tr> 
                <td width="108"> <img src="images/client-list.gif" alt="client list" width="108" height="18"></td>
                <td width="90" height="18">&nbsp; </td>
                <td width="18" height="18"><img id="ClDown" src="images/down-arrow.gif" alt="" width="18" height="18" style="cursor: pointer" onClick="ClDown_Click();" /></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr> 
          <td width="216" valign="top" class="bodytext"><div id="clientcell" class="bodytext"></div></td>
        </tr>
        <tr> 
          <td width="216"> 
            <table width="216" cellpadding="0" cellspacing="0" border="0" id="contacttitle"
			  style="width:216px;height:18px; background: url(images/gradients/category_bar.gif) repeat;">
              <tr> 
                <td width="108"> <img src="images/contact-form.gif" alt="contact form" width="108" height="18"></td>
                <td width="90" height="18">&nbsp; </td>
                <td> <img id="CoDown" src="images/down-arrow.gif" alt="" width="18" height="18" style="cursor: pointer" onClick="CoDown_Click();" /></td>
              </tr>
            </table>
          </td>
        </tr>
        <tr> 
          <td width="216" class="bodytext" valign="top" align="right">
		    <form name="form1" method="post" action="<%=strURL%>">
			  <div id="contactcell" class="bodytext"></div>
              <%= ErrMsg %> 
            </form></td>
        </tr>
      </table>
      &nbsp; <br>
      <!--end content table-->
    </td>
  </tr>
  <tr> 
    <td align="right" valign="bottom" height="82">
	  <div style="position"> 
      <div align="right" style="position: relative; top: -10px; left: -10px; z-index: 1;"><a href="http://www.nextmill.net" target="_blank"><img src="images/nextmill.jpg" alt="" width="120" height="31" border="0"></a> 
        &nbsp; <img src="images/lord-design-logo.jpg" alt="" width="37" height="55"> 
        <br>
        <font face="Verdana, Arial, Helvetica, sans-serif" color="#203C5B" style="font-size: 7pt">© 
        2003 Aaron J. Lord | visitor: <%=ctr%> | <%=Now%></font> </div>
	  </div>
    </td>
  </tr>
</table>
<script language="JavaScript" type="text/javascript">
<!--
var wd, wdb, gd, gdb, cf, cfb;

 wd = document.getElementById("webcell");
 wdb = document.getElementById("wdown");
 dmtext = document.getElementById("mediacell");
 dmarrow = document.getElementById("dmdown");
 gd = document.getElementById("designcell");
 gdb = document.getElementById("gdown");
 cld = document.getElementById("clientcell");
 cldb = document.getElementById("ClDown");
 cf = document.getElementById("contactcell");
 cfb = document.getElementById("CoDown");

function Wdown_Click(){
 if(wdb.src == "<%=path%>images/down-arrow.gif"){
   wd.innerHTML = "expert knowledge in the development of dynamic " +  "data-driven web-based appli- cations since 1998 &#149; technologies " +  ": asp asp.net html dhtml dom css javascript vbscript vb.net access sql server macromedia flash dreamweaver ultradev";
   wdb.src = "images/up-arrow.gif";
 }else if(wdb.src == "<%=path%>images/up-arrow.gif"){
   wd.innerHTML = "";
   wdb.src = "images/down-arrow.gif";
 }
  }
  
function DmDown_Click(){
 if(dmarrow.src == "<%=path%>images/down-arrow.gif"){
   dmtext.innerHTML = "development of digital media for online and offline use since 1999 &#149; technologies " +  ": cakewalk proaudio adobe audition adobe premiere pro windows media mp3 realaudio realvideo cd and dvd production";
   dmarrow.src = "images/up-arrow.gif";
 }else if(dmarrow.src == "<%=path%>images/up-arrow.gif"){
   dmtext.innerHTML = "";
   dmarrow.src = "images/down-arrow.gif";
 }
  }

function Gdown_Click(){
   if(gdb.src == "<%=path%>images/down-arrow.gif"){
   gd.innerHTML = " web site design digital imaging vector graphics " +  "encapsulated postscript &#149; tech- nologies : adobe photoshop acrobat " +  "page maker illustrator macromedia freehand " ;
   gdb.src = "images/up-arrow.gif";
 }else if(gdb.src == "<%=path%>images/up-arrow.gif"){
   gd.innerHTML = "";
   gdb.src = "images/down-arrow.gif";
 }
  }
  
function ClDown_Click(){
   if(cldb.src == "<%=path%>images/down-arrow.gif"){
   cld.innerHTML = "<a href='http://www.abkco.com/home.asp' target='_blank'>abkco records<\/a> &#149; <a href='http://www.calvarychapelchico.com' target='_blank'>calvary chapel chico<\/a> &#149; <a href='http://www.dambag.com' target='_blank'>flood technologies<\/a> &#149; <a href='http://www.mghworld.com' target='_blank'>mgh enterprises<\/a> &#149; <a href='http://www.whitespeed.com/foxcable/nationalgeographic/form.asp' target='_blank'>national geographic<\/a> &#149; <a href='http://www.northvalleyrecovery.com' target='_blank'>north valley recovery<\/a> &#149; <a href='http://www.sacaeagles.com' target='_blank'>southern arizona community academy<\/a> &#149; <a href='http://www.whitespeed.com' target='_blank'>whitespeed<\/a> " ;
   cldb.src = "images/up-arrow.gif";
 }else if(cldb.src == "<%=path%>images/up-arrow.gif"){
   cld.innerHTML = "";
   cldb.src = "images/down-arrow.gif";
 }
  }

function CoDown_Click() {
    if(cfb.src == "<%=path%>images/down-arrow.gif"){
   cf.innerHTML = " email <br> " +  "<input type='text' name='email' class='textfield' style='width: 216px; height: 18px; background: url(images/gradients/e-mail.gif) repeat;'> " +  "<br> " +  "msg<br> " +  "<textarea name='msg' class='textfield' align='right' style='width: 216px; height: 104px; background: url(images/gradients/textarea.gif) repeat;'><\/textarea> " +  "<br>" +  "&nbsp;" +  "<input type='submit' name='Submit' value='Submit' style='background: url(images/gradients/e-mail.gif) repeat;' class='button'>" +  "<br> <br> <br> <br>" +  "&nbsp;";
   cfb.src = "images/up-arrow.gif";
 }else if(cfb.src == "<%=path%>images/up-arrow.gif"){
   cf.innerHTML = "";
   cfb.src = "images/down-arrow.gif";
 }
  }

// ============================================================================
// This code converted from VBScript to Javascript by the ScriptConverter tool.
// Use freely.  Please do not redistribute without permission.
// Copyright 2003 Rob Eberhardt - scriptConverter@slingfive.com.
// ============================================================================	
-->
</script>

</BODY>
</HTML>