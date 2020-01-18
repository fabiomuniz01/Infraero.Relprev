(function () {

    'use strict';

    // basic
    $("#form").validate({
        rules: {
            "Login.Password": {
                required: true,
                minlength: 8
            }
        },
        messages: {
            "Login.Password": {
                required: "Por favor informe sua senha.",
                minlength: jQuery.validator.format("O usuário deve informar uma senha válida, contendo no mínimo 8 dígitos")
            }
        },
        highlight: function (label) {
            $(label).closest('.form-group').removeClass('has-success').addClass('has-error');
        },
        success: function (label) {
            $(label).closest('.form-group').removeClass('has-error');
            label.remove();
        },
        errorPlacement: function (error, element) {
            var placement = element.closest('.input-group');
            if (!placement.get(0)) {
                placement = element;
            }
            if (error.text() !== '') {
                placement.after(error);
            }
        }
    });

}).apply(this, [jQuery]);