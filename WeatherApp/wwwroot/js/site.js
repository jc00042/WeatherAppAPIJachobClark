// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function dropbtnFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}

function tempDropbtnFunction() {
    document.getElementById("myDropdown2").classList.toggle("show");
}
function filterFunction() {
    var input, filter, ul, li, a, i;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    div = document.getElementById("myDropdown");
    a = div.getElementsByTagName("a");
    for (i = 0; i < a.length; i++) {
        txtValue = a[i].textContent || a[i].innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
            a[i].style.display = "";
        } else {
            a[i].style.display = "none";
        }
    }
}
async function displayPlayerInfo(PID) {
    const reponse = await fetch(`https://localhost:7258/api/NewPlayer/${PID}`)
    const data = await response.json();
    document.getElementById('pName').innerHTML = data[0].pName;
    document.getElementById('pName').style.visibility = "visible";
    document.getElementById('pPosition').innerHTML = data[0].pPosition;
    document.getElementById('pPosition').style.visibility = "visible";
    document.getElementById('pNumber').innerHTML = data[0].pNumber;
    document.getElementById('pNumber').style.visibility = "visible";
}

async function displayTeamInfo(TeamLocation) {
    const reponse = await fetch(`https://localhost:7258/api/Team/${TeamLocation}`)
    const data = await response.json();
    document.getElementById('teamName').innerHTML = data[0].teamName;
    document.getElementById('teamName').style.visibility = "visible";
    document.getElementById('teamLocation').innerHTML = data[0].teamLocation;
    document.getElementById('teamLocation').style.visibility = "visible";
}