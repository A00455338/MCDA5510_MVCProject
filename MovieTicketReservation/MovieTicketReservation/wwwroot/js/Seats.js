const { error } = require("jquery");

function updateTextArea(target) {

        var allNumberVals = [];
        var allSeatsVals = [];

        //Storing in Array
        allNumberVals.push($("#Numseats").val());
        $('#seatsBlock :checked').each(function () {
            allSeatsVals.push($(this).val());
        });

        //Displaying 

        $('#NumberDisplay').val(allSeatsVals.length);
        $('#seatsDisplay').val(allSeatsVals);
    $('#totalPrice').val(allSeatsVals.length * 15);
    console.log(target);

    var seats = allSeatsVals.toString();
    target = target + '?data=' + seats;
    window.location.href = target;
    $.ajax({
        type: 'POST',
        data: allSeatsVals,
        url: target,
        success: console.log("success"),
      error: console.error(error)
    });

    var myData = { arr: allSeatsVals}

    
}
