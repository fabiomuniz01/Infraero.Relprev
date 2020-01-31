



var vm = new Vue({
    el: "#form",
    data: {
        UnidadeInfraEstruturaDto: {
            Dependencia: {}
        },
        params: {
            sigla:""
        }
    },
    mounted: function () {
        var self = this;
        (function ($) {

            'use strict';

            $('#DtIniVigencia').datepicker({
                format: "dd/mm/yyyy",
                language: "pt-BR"
            });
            $('#DtFimVigencia').datepicker({
                format: "dd/mm/yyyy",
                language: "pt-BR"
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
        GetUnidadeBySigla: function (event) {
            var self = this;

            axios.get("GetUnidadeBySigla/?sigla=" + self.params.sigla).then(result => {

                if (result.data.dep_codigo === undefined) {
                    new PNotify({
                        title: 'Unidade de Infraestrutura',
                        text: result.data,
                        type: 'error'
                    });
                } else {
                    self.UnidadeInfraEstruturaDto.Dependencia = result.data;
                }

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                
                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.',
                //        type: 'custom',
                //        addclass: 'notification-primary',
                //        icon: 'fa fa-twitter'
                //    });

                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.'
                //    });

                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.',
                //        type: 'success'
                //    });

                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.',
                //        type: 'info'
                //    });

                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.',
                //        type: 'error'
                //    });

                //    new PNotify({
                //        title: 'Regular Notice',
                //        text: 'Check me out! I\'m a notice.',
                //        addclass: 'notification-dark',
                //        icon: 'fa fa-user'
                //});
            });
        }
    }
});