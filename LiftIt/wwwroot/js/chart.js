function lineChartWaga() {
    window.lineChartWaga = Morris.Line({
        element: 'line-chart-waga',
        data: [
            { y: '2006', a: 100, b: 90, c:0 },
            { y: '2007', a: 75, b: 65, c: 10 },
            { y: '2008', a: 50, b: 40, c: 20 },
            { y: '2009', a: 75, b: 65, c:  0},
            { y: '2010', a: 50, b: 40, c: 40 },
            { y: '2011', a: 75, b: 65, c: 40 },
            { y: '2012', a: 100, b: 90, c: 60 }
        ],
        xkey: 'y',
        ykeys: ['a', 'b', 'c'],
        labels: ['Series A', 'Series B', 'Series C'],
        lineColors: ['#1e88e5', '#ff3321', '#2dc997'],
        lineWidth: '3px',
        resize: true,
        redraw: true
    });
}

function lineChartObwody() {
    window.lineChartObwody = Morris.Line({
        element: 'line-chart-obwody',
        data: [
            { y: '2006', a: 100},
            { y: '2007', a: 75},
            { y: '2008', a: 50},
            { y: '2009', a: 75},
            { y: '2010', a: 50},
            { y: '2011', a: 75},
            { y: '2012', a: 100}
        ],
        xkey: 'y',
        ykeys: ['a'],
        labels: ['Series A'],
        lineColors: ['#2dc997'],
        lineWidth: '3px',
        resize: true,
        redraw: true
    });
}

function lineChartTrening() {
    window.lineChartTrening = Morris.Line({
        element: 'line-chart-trening',
        data: [
            { y: '2006', a: 30 },
            { y: '2007', a: 32.5 },
            { y: '2008', a: 35 },
            { y: '2009', a: 35 },
            { y: '2010', a: 40 },
            { y: '2011', a: 45 },
            { y: '2012', a: 40 }
        ],
        xkey: 'y',
        ykeys: ['a'],
        labels: ['Series A'],
        lineColors: ['#2dc997'],
        lineWidth: '3px',
        resize: true,
        redraw: true
    });
}


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