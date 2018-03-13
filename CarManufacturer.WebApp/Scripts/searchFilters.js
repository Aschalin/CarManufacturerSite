$(".filter").on('change', function (e) {
    $("form").submit();
});

$('.filter').keypress(function (e) {
    if (e.which == 13) {
        $("form").submit();
    }
});