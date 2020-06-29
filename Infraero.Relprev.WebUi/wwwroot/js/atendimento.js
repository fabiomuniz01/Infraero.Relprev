var vm = new Vue({
    el: "#form",
    data: {
       
        loading: false
    },
    mounted: function () {
        var self = this;
        (function ($) {
            'use strict';
            if ($.isFunction($.fn['timepicker'])) {

                $(function () {
                    $('[data-plugin-timepicker]').each(function () {
                        var $this = $(this),
                            opts = {};

                        var pluginOptions = $this.data('plugin-options');
                        if (pluginOptions)
                            opts = pluginOptions;

                        $this.themePluginTimePicker(opts);
                    });
                });

            }

            //os campos de frontend deve ter os mesmos nomes da entity.cs
            var $DtOcorrencia = $("#DtOcorrenciaInicio");
            $DtOcorrencia.mask('00/00/0000', { reverse: false });
            $('#DtOcorrenciaInicio').datepicker({
                format: "dd/mm/yyyy",
                todayBtn: "linked",
                language: "pt-BR",
                orientation: "bottom left",
                autoclose: true
            });
            var $DtOcorrencia = $("#DtOcorrenciaFim");
            $DtOcorrencia.mask('00/00/0000', { reverse: false });
            $('#DtOcorrenciaFim').datepicker({
                format: "dd/mm/yyyy",
                todayBtn: "linked",
                language: "pt-BR",
                orientation: "bottom left",
                autoclose: true
            });

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

            $select.on('change', function () {
                $(this).trigger('blur');
            });
            $("#ddlEmpresa").change(function () {

                var url = "../AtendimentoTecnico/GetListResponsavelTecnicoByEmpresa";

                var ddlSource = "#ddlEmpresa";

                $.getJSON(url,
                    { id: $(ddlEmpresa).val() },
                    function (data) {
                        var items = '<option value="">Selecionar um responsável</option>';
                        $("#ddlResponsavelTecnico").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlResponsavelTecnico").html(items);
                    });
            });

            $("#ddlUnidadeInfraestrutura").change(function () {

                var url = "../AtendimentoTecnico/GetListEmpresaByUnidae";
                
                var ddlSource = "#ddlUnidadeInfraestrutura";

                $.getJSON(url,
                    { id: $(ddlSource).val() },
                    function (data) {
                        var items = '<option value="">Selecionar uma empresa</option>';
                        $("#ddlEmpresa").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlEmpresa").html(items);
                    });
            });

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
