$(document).ready(function () {

    function transition() {
        if ($('table td').length > 1) {
            $('#loader').fadeOut('fast');
        } else {
            $('#loader').fadeIn('fast');
            
        }
    }

    setInterval(transition, 5000);
})