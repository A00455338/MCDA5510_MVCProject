
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
        $('#totalPrice').val(allSeatsVals.length * 15);
        /*var url = '@Url.Action("selectedSeats/", "Pay")';
        var data = { Arr: allSeatsVals };
        $.post(url, data, function (result) {
            var id = '#postedFor' + postId;
            $(id).html(result);
        });*/
    
}
