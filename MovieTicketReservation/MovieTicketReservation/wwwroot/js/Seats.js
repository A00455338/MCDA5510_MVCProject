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
      error: alert(error)
    });
        //var url = '@Url.Action("selectedSeats/", "Pay")';
        //var data = { Arr: allSeatsVals };
        //$.post(url, data, function (result) {
        //    var id = '#postedFor' + postId;
        //    $(id).html(result);
        //});
    var myData = { arr: allSeatsVals}
    //$.ajax({
    //    type: 'POST',
    //    data: myData, // #2
    //    url: '/Pay',
    //    contentType: 'application/json', 
    //    dataType: 'json', 
    //    success: alert('Youhou'),
    //    error: alert(error)
    //});
    
}
