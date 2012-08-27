<%@ Page Inherits="LD_Home" Src="_vb/LD_Home.vb" Debug="True" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="theHead" runat="server">
    <title>: lord design.net :</title>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />

    <script language="JavaScript" type="text/javascript" src="JScript.js"></script>

</head>
<body>
    <form runat="server">
        <div align="center">
            <div id="main">
                <div id="hccPhoto" style="background-image: url(images/rotation/irn-bru.jpg);" runat="server">
                    <div id="hccInnerFoot" runat="server">
                        © 2005-2006 Aaron J. Lord
                    </div>
                    <div id="content">
                        <img src="images/aaron-head2.1.gif" alt=": lord design.net :" />
                        <div id="web-bar" class="cat_bar" style="margin-top: 10px;"><img src="images/web-development.gif" alt="web development" /><img src="images/down-arrow.gif"
                                alt="" class="cat_img" id="btn_web" onclick="btn_web_Click(this);" /></div>
                        <div id="txt_web" class="textblock" style="display: none;">
                            <div class="bodytext">
                                expert knowledge in the development of dynamic data-driven web-based appli- cations
                                since 1999 • technologies : asp asp.net html dhtml dom css javascript vbscript vb.net
                                access sql server flash dreamweaver movable type cross-browser compatibility w3c
                                compliance</div>
                        </div>
                        <div id="media-bar" class="cat_bar">
                            <img src="images/digital-media.gif" alt="digital media" /><img src="images/down-arrow.gif"
                                alt="" class="cat_img" id="btn_media" onclick="btn_media_Click(this);" /></div>
                        <div id="txt_media" class="textblock" style="display: none;">
                            <div class="bodytext">
                                development of digital media for online and offline use since 1999 • technologies
                                : cakewalk proaudio adobe audition adobe premiere pro windows media mp3 realaudio
                                realvideo cd and dvd production</div>
                        </div>
                        <div id="graphic-bar" class="cat_bar">
                            <img src="images/graphic-design.gif" alt="graphic design" /><img src="images/down-arrow.gif"
                                alt="" class="cat_img" id="btn_design" onclick="btn_design_Click(this);" /></div>
                        <div id="txt_design" class="textblock" style="display: none;">
                            <div class="bodytext">
                                web site design digital imaging vector graphics encapsulated postscript • technologies
                                : adobe photoshop acrobat page maker illustrator macromedia freehand
                            </div>
                        </div>
                        <div id="client-bar" class="cat_bar">
                            <img src="images/client-list.gif" alt="client list" /><img src="images/down-arrow.gif"
                                alt="" class="cat_img" id="btn_clients" onclick="btn_clients_Click(this);" /></div>
                        <div id="txt_clients" class="textblock" style="display: none;">
                            <div class="bodytext">
                                atom-bomb.com &#149; <a href="http://www.abkco.com/home.asp" target="_blank">abkco records</a>
                                &#149; <a href="http://www.calvarychapelchico.com" target="'_blank">calvary chapel chico</a>
                                &#149; <a href="http://www.dambag.com" target="_blank">flood technologies</a> &#149;
                                <a href="http://www.mghworld.com" target="_blank">mgh enterprises</a> &#149; national
                                geographic &#149; <a href="http://www.northvalleyrecovery.com" target="_blank">north
                                    valley recovery</a> &#149; southern arizona community academy &#149; <a href="http://www.inspiritandintruth.net"
                                        target="_blank">in spirit and in truth</a> &#149; <a href="http://www.whitespeed.com"
                                            target="_blank">whitespeed</a></div>
                        </div>
                        <div id="contact-bar" class="cat_bar">
                            <img src="images/contact-form.gif" alt="contact form" /><img src="images/down-arrow.gif"
                                alt="" class="cat_img" id="btn_contact" onclick="btn_contact_Click(this);" /></div>
                        <div id="txt_contact" class="textblock" style="display: none;">
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
                <div id="left">
                    <a href="http://www.nextmill.net" target="_blank">
                        <img src="images/mill-sys-logo.gif" alt="Millennium Systems" border="0" /></a>
                    <img src="images/slogo_xhtml10.png" alt="xhtml 1.0" style="position: relative; left: 14px;
                        bottom: 6px;" /><img src="images/slogo_css.gif" alt="CSS" style="position: relative;
                            left: 30px; bottom: 6px" /><img src="images/net-devel.gif" alt="Using the .NET Framework"
                                style="position: relative; left: 46; bottom: 6px;" />
                </div>
                <div id="outerfoot">
                    source: <a href="JScript.js">js</a> <a href="StyleSheet.css">css</a> <a href="write/aspx.html">
                        aspx</a> <a href="write/code_behind.html">vb</a> | <a href="http://www.lorddesign.net/weblog">
                            blog</a> | <a href="http://www.myspace.com/fiddler56">myspace</a> | <a href="http://www.lorddesign.net">
                                reload</a></div>
            </div>
        </div>
    </form>
</body>
</html>
