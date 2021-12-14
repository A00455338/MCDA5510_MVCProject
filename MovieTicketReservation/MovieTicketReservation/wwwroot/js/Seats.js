
function updateTextArea() {

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
    $('#totalPrice').val(allSeatsVals.length*15);
    
}
