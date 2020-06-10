

var vm = new Vue({
    el: "#form",
    mounted: function () {
        var self = this;
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

            $("#ddlEmpresa").change(function () {

                var url = "../GetResponsavelByEmpresa";

                var ddlSource = "#ddlEmpresa";

                $.getJSON(url,
                    { id: $(ddlEmpresa).val() },
                    function (data) {
                        var items = '<option value="">Selecione o reponsável técnico</option>';
                        $("#ddlResponsavel").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlResponsavel").html(items);
                    });
            });
            $("#ddlAssunto").change(function () {

                var url = "../GetResponsavelByEmpresa";

                var ddlSource = "#ddlAssunto";

                $.getJSON(url,
                    { id: $(ddlSource).val() },
                    function (data) {
                        var items = '';
                        $("#ddlResponsavel").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlResponsavel").html(items);
                    });
            });


            (function ($) {

                'use strict';

                /*
                Basic
                */
                $('.modal-basic').magnificPopup({
                    type: 'inline',
                    preloader: false,
                    modal: true
                });

                /*
                Sizes
                */
                $('.modal-sizes').magnificPopup({
                    type: 'inline',
                    preloader: false,
                    modal: true
                });

                /*
                Modal Dismiss
                */
                $(document).on('click', '.modal-dismiss', function (e) {
                    e.preventDefault();
                    $.magnificPopup.close();
                });

            }).apply(this, [jQuery]);




        }).apply(this, [jQuery]);
    },
    methods: {
        ShowLoad: function (flag, el) {
            var self = this;

            self.isLoading = flag;
            $("#" + el).loadingOverlay({
                "startShowing": flag
            });
            self.loading = flag;

            if (!flag) {
                self.isLoading = flag;
                $("#" + el).removeClass("loading-overlay-showing");
                self.loading = flag;
            } else {
                self.isLoading = flag;
                $("#" + el).addClass("loading-overlay-showing");
                self.loading = flag;
            }
        }
    }
});

