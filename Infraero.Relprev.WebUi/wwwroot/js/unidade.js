
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


//var vm = new Vue({
//    el: "#form",
//    data: {
//        UnidadeInfraEstruturaDto: {
//            Dependencia: {}
//        }
//    },
//    methods: {
//        GetUnidadeBySigla: function (event) {
//            var self = this;

//            axios.get("GetUnidadeBySigla").then(result => {
//                self.UnidadeInfraEstruturaDto.Dependencia = result.data;
//                console.log(result);
//            }).catch(error => {
//                Site.Notification("Erro ao buscar e analisar dados", error.response.data.Message, "error");

                
//            });
//        },
//    }
//});