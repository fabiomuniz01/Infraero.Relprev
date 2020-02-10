



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
        },
        CancelarEdit: function (event) {
            var self = this;

            //$("#DtIniVigencia").val("");
            //$("#DtFimVigencia").val("");
            //$("#Descricao").val("");
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