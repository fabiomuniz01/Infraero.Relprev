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


            var $DtOcorrencia = $("#DtStart");
            $DtOcorrencia.mask('00/00/0000', { reverse: false });
            $('#DtStart').datepicker({
                format: "dd/mm/yyyy",
                todayBtn: "linked",
                language: "pt-BR",
                orientation: "bottom left",
                autoclose: true
            });
            var $DtOcorrencia = $("#DtEnd");
            $DtOcorrencia.mask('00/00/0000', { reverse: false });
            $('#DtEnd').datepicker({
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

            $("#form").validate({
                rules: {
                    "EmailRelator": {
                        required: false,
                        email: true
                    },
                },
                messages: {
                    "EmailRelator": {
                        required: "Por favor informe o endereço eletrônico válido do usuário.",
                        email: "Formato de e-mail inválido."
                    },
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
        ,
        GetUnidadeBySigla: function (event) {
            var self = this;
            self.ShowLoad(true, "vUnidade");

            axios.get("GetUnidadeBySigla/?sigla=" + self.params.sigla).then(result => {

                if (result.data.dep_codigo === undefined) {
                    new PNotify({
                        title: 'Atendimento Técnico',
                        text: result.data,
                        type: 'error'
                    });
                } else {
                    self.UnidadeInfraEstruturaDto.Dependencia = result.data;
                }
                self.ShowLoad(false, "vAtendimento");

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                self.ShowLoad(false, "vAtendimento");
            });
        }
    }
});
