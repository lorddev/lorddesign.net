// JScript File

var txt_web, btn_web, txt_media, btn_media, txt_design, btn_design, txt_clients, btn_clients, txt_contact, btn_contact;

 txt_web = document.getElementById("txt_web");
 btn_web = document.getElementById("btn_web");
 txt_media = document.getElementById("txt_media");
 btn_media = document.getElementById("btn_media");
 txt_design = document.getElementById("txt_design");
 btn_design = document.getElementById("btn_design");
 txt_clients = document.getElementById("txt_clients");
 btn_clients = document.getElementById("btn_clients");
 //txt_contact = document.getElementById("txt_contact");
 //btn_contact = document.getElementById("btn_contact");

function btn_web_Click(){
 if(btn_web.src == "http://www.lorddesign.net/images/down-arrow.gif"){
   txt_web.style.display = "block";
   btn_web.src = "images/up-arrow.gif";
 }else if(btn_web.src == "http://www.lorddesign.net/images/up-arrow.gif"){
   txt_web.style.display = "none";
   btn_web.src = "images/down-arrow.gif";
 }
  }
  
function btn_media_Click(){
 if(btn_media.src == "http://www.lorddesign.net/images/down-arrow.gif"){
   txt_media.style.display = "block";
   btn_media.src = "images/up-arrow.gif";
 }else if(btn_media.src == "http://www.lorddesign.net/images/up-arrow.gif"){
   txt_media.style.display = "none";
   btn_media.src = "images/down-arrow.gif";
 }
  }

function btn_design_Click(){
   if(btn_design.src == "http://www.lorddesign.net/images/down-arrow.gif"){
   txt_design.style.display = "block" ;
   btn_design.src = "images/up-arrow.gif";
 }else if(btn_design.src == "http://www.lorddesign.net/images/up-arrow.gif"){
   txt_design.style.display = "none";
   btn_design.src = "images/down-arrow.gif";
 }
  }
  
function btn_clients_Click(){
   if(btn_clients.src == "http://www.lorddesign.net/images/down-arrow.gif"){
   txt_clients.style.display = "block" ;
   btn_clients.src = "images/up-arrow.gif";
 }else if(btn_clients.src == "http://www.lorddesign.net/images/up-arrow.gif"){
   txt_clients.style.display = "none";
   btn_clients.src = "images/down-arrow.gif";
 }
  }
//* deprecated in favor of ASP.NET programmatic access
//function btn_contact_Click() {
//   if(btn_contact.src == "http://www.lorddesign.net/images/down-arrow.gif"){
//   txt_contact.style.display = "block";
//   btn_contact.src = "images/up-arrow.gif";
// }else if(btn_contact.src == "http://www.lorddesign.net/images/up-arrow.gif"){
//   txt_contact.style.display = "none";
//   btn_contact.src = "images/down-arrow.gif";
// }
//  }
