// JScript File

var txt_web;
var txt_media;
var txt_design;
var txt_clients;
var txt_contact;

function loadVars(){
    txt_web = document.getElementById('txt_web');
    txt_media = document.getElementById('txt_media');
    txt_design = document.getElementById('txt_design');
    txt_clients = document.getElementById('txt_clients');
    txt_contact = document.getElementById('txt_contact');
}

function btn_web_Click(btn_web){
    if(btn_web.src == 'http://www.lorddesign.net/images/down-arrow.gif'){
        txt_web.style.display = 'block';
        btn_web.src = 'images/up-arrow.gif';
    }
    else if(btn_web.src == 'http://www.lorddesign.net/images/up-arrow.gif'){
        txt_web.style.display = 'none';
        btn_web.src = 'images/down-arrow.gif';
    }
}
  
function btn_media_Click(btn_media){
    if(btn_media.src == 'http://www.lorddesign.net/images/down-arrow.gif'){
        txt_media.style.display = 'block';
        btn_media.src = 'images/up-arrow.gif';
    }
    else if(btn_media.src == 'http://www.lorddesign.net/images/up-arrow.gif'){
        txt_media.style.display = 'none';
        btn_media.src = 'images/down-arrow.gif';
    }
}

function btn_design_Click(btn_design){
    if(btn_design.src == 'http://www.lorddesign.net/images/down-arrow.gif'){
        txt_design.style.display = 'block' ;
        btn_design.src = 'images/up-arrow.gif';
    }
    else if(btn_design.src == 'http://www.lorddesign.net/images/up-arrow.gif'){
        txt_design.style.display = 'none';
        btn_design.src = 'images/down-arrow.gif';
    }
}
  
function btn_clients_Click(btn_clients){
    if(btn_clients.src == 'http://www.lorddesign.net/images/down-arrow.gif'){
        txt_clients.style.display = 'block' ;
        btn_clients.src = 'images/up-arrow.gif';
    }
    else if(btn_clients.src == 'http://www.lorddesign.net/images/up-arrow.gif'){
        txt_clients.style.display = 'none';
        btn_clients.src = 'images/down-arrow.gif';
    }
}

function btn_contact_Click(btn_contact) {
    if(btn_contact.src == 'http://www.lorddesign.net/images/down-arrow.gif'){
        txt_contact.style.display = 'block';
        btn_contact.src = 'images/up-arrow.gif';
    }
    else if(btn_contact.src == 'http://www.lorddesign.net/images/up-arrow.gif'){
        txt_contact.style.display = 'none';
        btn_contact.src = 'images/down-arrow.gif';
    }
}