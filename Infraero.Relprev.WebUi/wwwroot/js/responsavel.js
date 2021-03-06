﻿var vm = new Vue({
    el: "#form",
    data: {
        params: {
            cpf: ""
        },
        loading: false
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

            $("#ddlUnidadeInfraestrutura").change(function () {

                var url = "GetEmpresaByUnidade";

                var ddlSource = "#ddlUnidadeInfraestrutura";

                $.getJSON(url,
                    { id: $(ddlSource).val() },
                    function (data) {
                        var items = '';
                        $("#ddlEmpresa").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlEmpresa").html(items);
                    });
            });

            var $numCpf = $("#cpf");
            $numCpf.mask('000.000.000-00', { reverse: false });

            var $numTel = $("#NumTelefone");
            $numTel.mask('(00) 0000-0000');

            $("#form").validate({
                rules: {
                    cpf: { cpf: true, required: true }
                },
                messages: {
                    cpf: { cpf: 'Formato de CPF inválido', required: "Por favor informe o número do CPF do responsável técnico." }
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

            jQuery.validator.addMethod("cpf", function (cpf, element) {
                var regex = /^\d{3}\.\d{3}\.\d{3}\-\d{2}$/;
                var add, rev, i;
                if (!regex.test(cpf))
                    return false;

                cpf = cpf.replace(/[^\d]+/g, '');
                if (cpf == '') return false;
                // Elimina CPFs invalidos conhecidos	
                if (cpf.length != 11 ||
                    cpf == "00000000000" ||
                    cpf == "11111111111" ||
                    cpf == "22222222222" ||
                    cpf == "33333333333" ||
                    cpf == "44444444444" ||
                    cpf == "55555555555" ||
                    cpf == "66666666666" ||
                    cpf == "77777777777" ||
                    cpf == "88888888888" ||
                    cpf == "99999999999")
                    return false;
                // Valida 1o digito	
                add = 0;
                for (i = 0; i < 9; i++)
                    add += parseInt(cpf.charAt(i)) * (10 - i);
                rev = 11 - (add % 11);
                if (rev == 10 || rev == 11)
                    rev = 0;
                if (rev != parseInt(cpf.charAt(9)))
                    return false;
                // Valida 2o digito	
                add = 0;
                for (i = 0; i < 10; i++)
                    add += parseInt(cpf.charAt(i)) * (11 - i);
                rev = 11 - (add % 11);
                if (rev == 10 || rev == 11)
                    rev = 0;
                if (rev != parseInt(cpf.charAt(10)))
                    return false;
                return true; 


            }, "Informe um CPF válido");
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
        },
        ExisteCpf: function () {
            var self = this;
            self.ShowLoad(true, "vResponsavel");

            axios.get("GetResponsavelTecnicoByCpf/?cpf=" + self.params.cpf).then(result => {

                if (result.data !== false) {
                    new PNotify({
                        title: 'Responsavel',
                        text: result.data,
                        type: 'error'
                    });
                }

                self.ShowLoad(false, "vResponsavel");

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                self.ShowLoad(false, "vResponsavel");
            });
        }
    }
});

