

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

            var datatableInit = function () {

                $('#datatable-default').dataTable({
                    dom: '<"row"<"col-lg-6"l><"col-lg-6"f>><"table-responsive"t>p',
                    "searching": false,
                    "lengthChange": false,
                    "pageLength": 3,
                    "language": {
                        "sEmptyTable": "Nenhum registro encontrado",
                        "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
                        "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
                        "sInfoFiltered": "(Filtrados de _MAX_ registros)",
                        "sInfoPostFix": "",
                        "sInfoThousands": ".",
                        "sLengthMenu": "_MENU_ resultados por página",
                        "sLoadingRecords": "Carregando...",
                        "sProcessing": "Processando...",
                        "sZeroRecords": "Nenhum registro encontrado",
                        "sSearch": "Pesquisar: ",
                        "oPaginate": {
                            "sNext": "Próximo →" +
                                "" +
                                "",
                            "sPrevious": "← Anterior",
                            "sFirst": "Primeiro",
                            "sLast": "Último"
                        },
                        "oAria": {
                            "sSortAscending": ": Ordenar colunas de forma ascendente",
                            "sSortDescending": ": Ordenar colunas de forma descendente"
                        }
                    }
                });

            };

            $(function () {
                datatableInit();
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

