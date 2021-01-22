
var vm = new Vue({
    el: "#form",
    data: {
        params: {
            cnpj: ""
        },
        loading: false
    },
    mounted: function () {
        var self = this;
        (function ($) {

            'use strict';

            jQuery.validator.addMethod("noSpace", function (value, element) {
                return value == '' || value.trim().length != 0;
            }, "Sem espaço por favor e não o deixe vazio");

            var $numCnpj = $("#cnpj");
            $numCnpj.mask('00.000.000/0000-00', { reverse: false });

            var $numTel = $("#Telefone");
            $numTel.mask('(00) 0000-0000');

            $("#form").validate({
                rules: {
                    cnpj: { cnpj: true, required: true },
                    Empresa: {
                        noSpace: true
                    }
                },
                messages: {
                    cnpj: { cnpj: 'CNPJ inválido', required: "Por favor informe o CNPJ da empresa / órgão público" }
                },
                //submitHandler: function (form) {
                //    alert('ok');
                //},
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

            jQuery.validator.addMethod("cnpj",
                function(value, element) {

                    var numeros, digitos, soma, i, resultado, pos, tamanho, digitos_iguais;
                    if (value.length == 0) {
                        return false;
                    }

                    value = value.replace(/\D+/g, '');
                    digitos_iguais = 1;

                    for (i = 0; i < value.length - 1; i++)
                        if (value.charAt(i) != value.charAt(i + 1)) {
                            digitos_iguais = 0;
                            break;
                        }
                    if (digitos_iguais)
                        return false;

                    tamanho = value.length - 2;
                    numeros = value.substring(0, tamanho);
                    digitos = value.substring(tamanho);
                    soma = 0;
                    pos = tamanho - 7;
                    for (i = tamanho; i >= 1; i--) {
                        soma += numeros.charAt(tamanho - i) * pos--;
                        if (pos < 2)
                            pos = 9;
                    }
                    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
                    if (resultado != digitos.charAt(0)) {
                        return false;
                    }
                    tamanho = tamanho + 1;
                    numeros = value.substring(0, tamanho);
                    soma = 0;
                    pos = tamanho - 7;
                    for (i = tamanho; i >= 1; i--) {
                        soma += numeros.charAt(tamanho - i) * pos--;
                        if (pos < 2)
                            pos = 9;
                    }

                    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;

                    return (resultado == digitos.charAt(1));
                },
                "Informe um CNPJ válido");

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
        CancelarEdit: function (event) {
            var self = this;

            $("#ddlUnidadeInfraestrutura").select2("val", "0");
            
        },
        ExisteCnpj: function () {
            var self = this;
            self.ShowLoad(true, "vEmpresa");

            axios.get("GetEmpresaByCnpj/?cnpj="+self.params.cnpj).then(result => {

                if (result.data !== false) {
                    new PNotify({
                        title: 'Empresa',
                        text: result.data,
                        type: 'error'
                    });
                } 

                self.ShowLoad(false, "vEmpresa");

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                    self.ShowLoad(false, "vEmpresa");
            });
        }
    }
});