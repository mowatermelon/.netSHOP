window.onload = function () {
    var obj01 = document.getElementById("LOGIN");
    var obj02 = document.getElementById("List05");
    var obj03 = document.getElementById("close");

    if (obj02.text == "LOGIN") {
        obj02.onmouseover = function () {
            startMove(obj01, 'width', 350);
        }
        obj02.onclick = function () {
            startMove(obj01, 'width', 0);
        }
        obj03.onmouseover = function () {
            startMove(obj01, 'width', 0);
        }
    }
    else {
            alert(change);
            }

    }

function startMove(obj, attr, lastVal) {
    clearInterval(obj.timer);
    obj.timer = setInterval(function () {
        var iru = 0;
        if (attr == 'opacity') {
            iru = parseFloat(getStyle(obj, attr)) * 100;
        }
        else {
            iru = parseInt(getStyle(obj, attr));
        }
        var speed = (lastVal - iru) / 10;
        speed = speed > 0 ? Math.ceil(speed) : Math.floor(speed);
        if (iru == lastVal) {
            clearInterval(timer);
        }
        else {
            if (attr == 'opacity') {
                obj.style.opacity = (iru + speed) / 100;
                obj.style.filter = 'alpha(opacity:' + (iru + speed) + ')';
            }
            else {
                if (attr == 'color') {
                    obj.style[attr] = '#17D' + (iru + speed);
                }
                else {
                    obj.style[attr] = iru + speed + 'px';
                }
            }
        }
    }, 30)

}

function getStyle(obj, attr) {
    if (obj.currentStyle) {
        return obj.currentStyle;
    }
    else {
        return getComputedStyle(obj, false)[attr];
    }
}