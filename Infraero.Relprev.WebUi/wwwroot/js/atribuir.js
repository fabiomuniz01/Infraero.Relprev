

var vm = new Vue({
    el: "#form",
    created: function () {

    },
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

                var url = "../../AtribuirRespRelato/GetListResponsavelTecnicoByEmpresa";

                var ddlSource = "#ddlEmpresa";

                $.getJSON(url,
                    { idEmpresa: $(ddlEmpresa).val(), idRelato: $(CodRelato).val() },
                    function (data) {
                        var items = '<option value="">Selecione o reponsável técnico</option>';
                        $("#ddlResponsavelTecnico").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlResponsavelTecnico").html(items);
                        
                    });
            });

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
