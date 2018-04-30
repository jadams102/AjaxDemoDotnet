// Write your Javascript code.
$(document).ready(function () {
    //Display text using a URL action
    $('.hello-ajax').click(function () {
        $.ajax({
            type: 'GET',
            url: '@Url.Action("HelloAjax", "Home")',
            success: function (result) {
                $('#result1').html(result);
            }
        });
    });
    //Display text using parameters and a URL action
    $('.sum').click(function () {
        $.ajax({
            type: 'GET',
            data: { firstNumber: 1, secondNumber: 2 },
            url: '@Url.Action("Sum", "Home")',
            success: function (result) {
                $('#result2').html(result);
            }
        });
    });
    //Display an object using AJAX and a URL action
    $('.display-object').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'json',
            contentType: 'application/json',
            url: '@Url.Action("DisplayObject", "Home")',
            success: function (result) {
                var resultString = 'Id: ' + result.id + '<br>City: ' + result.city + '<br>Country: ' + result.country;
                $('#result3').html(resultString);
            }
        });
    });
    //Display a partial view using AJAX
    $('.display-view').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '@Url.Action("DisplayViewWithAjax", "Home")',
            success: function (result) {
                $('#result4').html(result);
            }
        });
    });
});