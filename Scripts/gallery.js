function openNav() {
    if (window.innerWidth > 700) { 
        document.getElementById("mySidenav").style.width = "250px";
        document.getElementById("main").style.marginLeft = "250px";
    }
    else document.getElementById("mySidenav").style.width = "100%";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
  document.getElementById("main").style.marginLeft= "0";
}


var modal = document.getElementById('myModal');

function openImg(imgId) {
    var img = document.getElementById(imgId);
    var modalImg = document.getElementById("img");
    var captionText = document.getElementById("caption");
    modal.style.display = "block";
    modalImg.src = document.getElementById(imgId).src;
    captionText.innerHTML = document.getElementById(imgId).alt;
    
}

var span = document.getElementsByClassName("close")[0];

span.onclick = function() { 
    modal.style.display = "none";
}
