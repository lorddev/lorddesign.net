<%@ Page Inherits="LD_Home" Src="_vb/LD_Home.vb" Debug="True" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>: lord design.net :</title>
  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
  <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
  <form runat="server">
    <div align="center">
      <div id="main">
        <div id="hccPhoto" style="background-image: url(images/rotation/irn-bru.jpg);" runat="server">
          <div id="hccInnerFoot" runat="server">
            © 2005 Aaron J. Lord | visitor:
            <asp:Label ID="lblCounter" runat="server" /></div>
          <div id="content">
            <img src="images/aaron-head.gif" alt=": lord design.net :" />
            <div id="web-bar" class="cat_bar" style="margin-top: 10px;">
              <img src="images/web-development.gif" alt="web development" /><img src="images/down-arrow.gif"
                alt="" width="18" height="18" id="btn_web" style="cursor: pointer; border: 0" onclick="btn_web_Click();" /></div>
            <div id="txt_web" class="textblock" style="display: none;">
              <div class="bodytext">
                expert knowledge in the development of dynamic data-driven web-based appli- cations
                since 1999 • technologies : asp asp.net html dhtml dom css javascript vbscript vb.net
                access sql server flash dreamweaver movable type cross-browser compatibility w3c
                compliance</div>
            </div>
            <div id="media-bar" class="cat_bar" style="margin-top: 3px;">
              <img src="images/digital-media.gif" alt="digital media" /><img src="images/down-arrow.gif"
                alt="" width="18" height="18" id="btn_media" style="cursor: pointer; border: 0;"
                onclick="btn_media_Click();" /></div>
            <div id="txt_media" class="textblock" style="display: none;">
              <div class="bodytext">
                development of digital media for online and offline use since 1999 • technologies
                : cakewalk proaudio adobe audition adobe premiere pro windows media mp3 realaudio
                realvideo cd and dvd production</div>
            </div>
            <div id="graphic-bar" class="cat_bar" style="margin-top: 3px;">
              <img src="images/graphic-design.gif" alt="graphic design" /><img src="images/down-arrow.gif"
                alt="" width="18" height="18" id="btn_design" style="cursor: pointer; border: 0"
                onclick="btn_design_Click();" /></div>
            <div id="txt_design" class="textblock" style="display: none;">
              <div class="bodytext">
                web site design digital imaging vector graphics encapsulated postscript • technologies
                : adobe photoshop acrobat page maker illustrator macromedia freehand
              </div>
            </div>
            <div id="client-bar" class="cat_bar" style="margin-top: 3px;">
              <img src="images/client-list.gif" alt="client list" /><img src="images/down-arrow.gif"
                alt="" width="18" height="18" id="btn_clients" style="cursor: pointer; border: 0;"
                onclick="btn_clients_Click();" /></div>
            <div id="txt_clients" class="textblock" style="display: none;">
              <div class="bodytext">
                atom-bomb.com &#149;
		<a href="http://www.abkco.com/home.asp" target="_blank">abkco records</a> &#149;
                <a href="http://www.calvarychapelchico.com" target="'_blank">calvary chapel chico</a>
                &#149; <a href="http://www.dambag.com" target="_blank">flood technologies</a> &#149;
                <a href="http://www.mghworld.com" target="_blank">mgh enterprises</a> &#149; <a href="http://www.whitespeed.com/foxcable/nationalgeographic/form.asp"
                  target="_blank">national geographic</a> &#149; <a href="http://www.northvalleyrecovery.com"
                    target="_blank">north valley recovery</a> &#149; <a href="http://www.sacaeagles.com"
                      target="_blank">southern arizona community academy</a> &#149; <a href="http://www.inspiritandintruth.net"
                        target="_blank">in spirit and in truth</a> &#149; <a href="http://www.whitespeed.com"
                          target="_blank">whitespeed</a></div>
            </div>
            <div id="contact-bar" class="cat_bar" style="margin-top: 3px;">
              <img src="images/contact-form.gif" alt="contact form" /><asp:ImageButton ID="btnContactArrow"
                ImageUrl="images/down-arrow.gif" Width="18" Height="18" OnClick="btnContactArrow_Click"
                Style="cursor: pointer; border: 0" runat="server" /></div>
            <div id="hccContact" visible="false" class="textblock" runat="server">
              <div class="bodytext">
                email
                <br />
                <asp:TextBox ID="txtEmail" CssClass="textfield" TextMode="SingleLine" Style="width: 216px;
                  height: 18px; background: url(images/gradients/e-mail.gif) repeat;" runat="server" />
                <br />
                msg<br />
                <asp:TextBox ID="txtMsg" TextMode="MultiLine" Rows="4" CssClass="textfield" Style="width: 216px;
                  height: 104px; background: url(images/gradients/textarea.gif) repeat;" runat="server" />
                <asp:Button ID="btnSubmit" Text="Send Message" Style="background: url(images/gradients/submit.gif) repeat;"
                  CssClass="button" OnClick="btnSubmit_Click" runat="server" />
              </div>
              <asp:Label ID="lblErrMsg" CssClass="bodytext" runat="server" />
            </div>
          </div>
        </div>
        <div id="left" style="position: relative; float: left; left: 45px; top: 37px;">
          <a href="http://www.nextmill.net" target="_blank">
            <img src="images/mill-sys-logo.gif" alt="Millennium Systems" border="0" /></a>
          <img src="images/slogo_xhtml10.png" alt="xhtml 1.0" style="position: relative; left: 14px;
            bottom: 6px;" /><img src="images/slogo_css.gif" alt="CSS" style="position: relative;
              left: 30px; bottom: 6px" /><img src="images/net-devel.gif" alt="Using the .NET Framework"
                style="position: relative; left: 46; bottom: 6px;" />
        </div>
        <div id="outerfoot" style="position: relative; float: right; right: 45px; top: 45px;
          font-family: Verdana, Geneva, Sans-serif; font-size: 7pt; color: #CCCCCC;">
          source: <a href="JScript.js">js</a> <a href="StyleSheet.css">css</a> <a href="write/aspx.html">
            aspx</a> <a href="write/code_behind.html">vb</a> | <a href="http://www.lorddesign.net/weblog">
              blog</a> | <a href="http://www.myspace.com/fiddler56">myspace</a> | <a href="http://www.lorddesign.net">
                reload</a></div>
      </div>
    </div>
  </form>

  <script language="JavaScript" type="text/javascript" src="JScript.js">
<!--
//moved to file
-->
</script>

</body>
</html>
