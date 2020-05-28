var counter = 0;
var output = [];

function AddText()
{
    if (document.getElementById("input").value != "" || document.getElementById("input").value != null) {
        document.getElementById("added").innerHTML += "<p id=" + counter + ">" + document.getElementById("input").value + "</p>";
        output[counter] = document.getElementById("input").value + "\n";
        document.getElementById("input").value = "";
        counter++;
        UpdateOutput();
    }
}

function UpdateOutput() {

    document.getElementById("MainContent_output").value = "";
    for (var i = 0; i < counter; i++) {
        document.getElementById("MainContent_output").value += output[i];
    }
}