function moveSquare(id) {
    var square = document.getElementById(id);
    var currentX = 0;
    var finalX = 100;
    var step = 5;
    var interval = 10;
    var timer = setInterval(function () {
        if (currentX >= finalX) {
            clearInterval(timer);
        } else {
            currentX += step;
            square.style.transform = "translateX(" + currentX + "px)";
        }
    }, interval);
}