
//window.onresize = function () {
//    window.lineChartWaga.redraw();
//    window.lineChartObwody.redraw();
//    window.lineChartTrening.redraw();
//}

function createButtonWaga() {

    var element = document.createElement("button");
    element.className = "btn btn-success btn-lg btn-block";
    //Assign different attributes to the element. 
    element.type = "button";
    //element.value = type; // Really? You want the default value to be the type string?
    var t = document.createTextNode("Wyświetl/Odśwież");


    var foo = document.getElementById("createButtonWaga");
    //Append the element in page (in span).  
    element.appendChild(t);
    foo.appendChild(element);
}

function createButtonObwody() {
    var element = document.createElement("button");
    element.className = "btn btn-success btn-lg btn-block";
    //Assign different attributes to the element. 
    element.type = "button";
    //element.value = type; // Really? You want the default value to be the type string?
    var t = document.createTextNode("Wyświetl/Odśwież");


    var foo = document.getElementById("createButtonObwody");
    //Append the element in page (in span).  
    element.appendChild(t);
    foo.appendChild(element);

}

function createButtonTrening() {
    var element = document.createElement("button");
    element.className = "btn btn-success btn-lg btn-block";
    //Assign different attributes to the element. 
    element.type = "button";
    //element.value = type; // Really? You want the default value to be the type string?
    var t = document.createTextNode("Wyświetl/Odśwież");


    var foo = document.getElementById("createButtonTrening");
    //Append the element in page (in span).  
    element.appendChild(t);
    foo.appendChild(element);

}



var doItOnce = false;
var doItOnce2 = false;
var doItOnce3 = false;
function createLabelWaga() {
    if (doItOnce == false) {
        var para = document.createElement("h2");
        var t = document.createTextNode("Monitoruj zmiany masy ciała w czasie");
        para.appendChild(t);
        document.getElementById("napisWaga").appendChild(para);
        doItOnce = true;
    }
    
}

function createLabelObwody() {
    if (doItOnce2 == false) {
        var para = document.createElement("h2");
        var t = document.createTextNode("Monitoruj zmiany obwodów swojego ciała w czasie");
        para.appendChild(t);
        document.getElementById("napisObwody").appendChild(para);
        doItOnce2 = true;
    }
}

function createLabelTrening() {
    if (doItOnce3 == false) {
        var para = document.createElement("h2");
        var t = document.createTextNode("Monitoruj osiągnięty progres treningu");
        para.appendChild(t);
        document.getElementById("napisTrening").appendChild(para);
        doItOnce3 = true;
    }
}