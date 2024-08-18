$(document).ready(function () {
    GetCountry(); 
});

function GetCountry() {
    $.ajax({
        url: '/Home/Country',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#country').append('<Option value= ' + data.id + '>' + data.name + '</Option>');
            })
        }

    });
}