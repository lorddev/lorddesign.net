<%@ Language=VBScript %>
<% option explicit %>
<%
Dim ErrMsg
Dim ctr
ctr = CLng(Counter.Get("lorddesign"))
ErrMsg = "There have been " & ctr & " visits to design.longboardbreaker.com."
%>
<HTML>
<HEAD>
<TITLE>: lord design :</TITLE>
<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=iso-8859-1">
<link rel="stylesheet" href="style_sheet.css" type="text/css">
</HEAD>
<BODY BGCOLOR="#04203F" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0" text="#829EBD" style="background-color: 
#04203f; background-image: url(images/dread-bg.gif); background-repeat: no-repeat;
vertical-align: bottom;">
<div class="bodytext"><%=ErrMsg%></div>
</body>
</html>
