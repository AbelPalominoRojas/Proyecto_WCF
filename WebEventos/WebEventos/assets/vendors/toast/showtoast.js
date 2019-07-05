$(document).ready(function() {
    var toastheading = 'Mensaje',
        toastHideAfter = 4000;

    function msgInfo(msg) {
        $.toast({
            heading: toastheading,
            text: msg,
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'info',
            hideAfter: toastHideAfter,
            stack: 6
        });
    }

    function msgWarning(msg) {
        $.toast({
            heading: toastheading,
            text: msg,
            position: 'top-right',
            loaderBg: '#F39C12',
            icon: 'warning',
            hideAfter: toastHideAfter,
            stack: 6
        });
    }

    function msgSuccess(msg) {
        $.toast({
            heading: toastheading,
            text: msg,
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'success',
            hideAfter: toastHideAfter,
            stack: 6
        });

    }

    function msgError(msg) {
        $.toast({
            heading: toastheading,
            text: msg,
            position: 'top-right',
            loaderBg: '#ff6849',
            icon: 'error',
            hideAfter: toastHideAfter

        });

    }

    window.msgInfo = msgInfo;
    window.msgWarning = msgWarning;
    window.msgSuccess = msgSuccess;
    window.msgError = msgError;
});