$(document).ready(function () {

    $('h2').fadeIn(2000);

    $('#searchField').on('input', function () {
        $('#searchResult').text('Fetching search predictions...');

        $.ajax({
            method: 'GET',
            url: '/Api',
            data: {
                searchString: $('#searchField').val()
            },
            dataType: 'json',
            error: function (jqXHR, textStatus, errorThrown) {
                alert('Något gick fel! status:' + textStatus + "\nerror: " + errorThrown);
            },
            success: function (data) {
                if (data.Name === undefined)
                    $('#searchResult').html(data);
                else
                    $('#searchResult').html("Letade du efter " + data.Name + "? id=" + data.Id);
            }
        });
    });//on input
});//document.ready