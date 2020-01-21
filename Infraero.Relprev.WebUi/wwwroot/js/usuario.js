// Select2
(function ($) {

    'use strict';

    var $select = $(".select2").select2({
        allowClear: true
    });

    $(".select2").each(function () {
        var $this = $(this),
            opts = {};

        var pluginOptions = $this.data('plugin-options');
        if (pluginOptions)
            opts = pluginOptions;

        $this.themePluginSelect2(opts);
    });

    /*
     * When you change the value the select via select2, it triggers
     * a 'change' event, but the jquery validation plugin
     * only re-validates on 'blur'*/

    $select.on('change', function () {
        $(this).trigger('blur');
    });

    $('#form').validate({
        ignore: 'input[type=hidden], .select2-input, .select2-focusser'
    });

    $select.rules('add', 'required');


    $("#form").validate({
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