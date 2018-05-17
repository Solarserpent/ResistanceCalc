// Write your JavaScript code.
$('#ColorA').change(function () {
    setColorClass($(this).val(), $('#bandA'));
});
$('#ColorB').change(function () {
    setColorClass($(this).val(), $('#bandB'));
});
$('#ColorC').change(function () {
    setColorClass($(this).val(), $('#bandC'));
});
$('#ColorD').change(function () {
    setColorClass($(this).val(), $('#bandD'));
});

jQuery(window).on("load", function () {

    $('#ColorA').change();
    $('#ColorB').change();
    $('#ColorC').change();
    $('#ColorD').change();

});
//$('#ColorA').on("(function () {
//    setColorClass($(this).val(), $('#bandA'));
//});
//$('#ColorB').load(function () {
//    setColorClass($(this).val(), $('#bandB'));
//});
//$('#ColorC').load(function () {
//    setColorClass($(this).val(), $('#bandC'));
//});
//$('#ColorD').load(function () {
//    setColorClass($(this).val(), $('#bandD'));
//});

function setColorClass(color, object) {
    switch (color) {
        case "Black":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band black");
            }
            else {
                object.removeClass().addClass("band black");
            }
            break;
        case "Brown":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band brown");
            }
            else {
                object.removeClass().addClass("band brown");
            }
            break;
        case "Red":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band red");
            }
            else {
                object.removeClass().addClass("band red");
            }
            break;
        case "Orange":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band orange");
            }
            else {
                object.removeClass().addClass("band orange");
            }
            break;
        case "Yellow":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band yellow");
            }
            else {
                object.removeClass().addClass("band yellow");
            }
            break;
        case "Green":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band green");
            }
            else {
                object.removeClass().addClass("band green");
            }
            break;
        case "Blue":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band blue");
            }
            else {
                object.removeClass().addClass("band blue");
            }
            break;
        case "Violet":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band violet");
            }
            else {
                object.removeClass().addClass("band violet");
            }
            break;
        case "Gray":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band gray");
            }
            else {
                object.removeClass().addClass("band gray");
            }
            break;
        case "White":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band white");
            }
            else {
                object.removeClass().addClass("band white");
            }
            break;
        case "Pink":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band pink");
            }
            else {
                object.removeClass().addClass("band pink");
            }
            break;
        case "Silver":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band silver");
            }
            else {
                object.removeClass().addClass("band silver");
            }
            break;
        case "Gold":
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band gold");
            }
            else {
                object.removeClass().addClass("band gold");
            }
            break;
        default:
            if (object.hasClass("hor-band")) {
                object.removeClass().addClass("hor-band");
            }
            else {
                object.removeClass().addClass("band");
            }
            break;
    }
}