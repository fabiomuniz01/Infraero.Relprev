

var vm = new Vue({
    el: "#form",
    created: function () {

    },
    mounted: function () {
        var self = this;
        (function ($) {

            'use strict';
            

            $('#datatable-default').dataTable({

                "ajax": {
                    'url': "../../AtribuirRespRelato/GetListResponsavelTecnicoByRelato/?id=" + $("#CodRelato").val(),
                    'type': "GET",
                    'contentType': "application/json; charset=utf-8",
                },

                "columns": [
                    { "data": "CodEmpresa" },
                    { "data": "NomeEmpresa" },
                    { "data": "CodResponsavel" },
                    { "data": "NomeResponsavel" },
                    {
                        "data": null,
                        "sortable": false,
                        "render": function (c) {
                            return "<a style='color:#d43f3a'" +
                                c.CodResponsavel +
                                "))'><i class='fa fa-trash'></i></a>";
                        }
                    }
                ],
                "columnDefs": [
                    {
                        "targets": [0],
                        "visible": false,
                    },
                    {
                        "targets": [2],
                        "visible": false
                    }
                ],
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
           
            //var table = $('#datatable-default').DataTable();

            //$('#datatable-default tbody').on('click', 'a', function () {
            //    var list = $("#ListCodResponsavel").val();

            //    var parentRow = $(this).closest("tr").prev()[0];

            //    var cells = parentRow.cells;
            //    var id = ',' + cells[2].innerText;

            //    list = list.replace(id, '');

            //    $("#ListCodResponsavel").val(list);

            //    table
            //        .row($(this).parents('tr'))
            //        .remove()
            //        .draw();
            //});

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
                    { id: $(ddlEmpresa).val() },
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
        },
        Adicionar: function () {
            //var url = "../AtribuirRespRelato/AdicionarResponsavel";
            var listCodResponsavel = '';

            var selected = $('#ddlResponsavelTecnico').find(':selected');

            $.each(selected, function (i, val) {

                var obj = {
                    CodEmpresa: $('#ddlEmpresa').find(':selected')[0].value,
                    NomeEmpresa: $('#ddlEmpresa').find(':selected')[0].text,
                    CodResponsavel: val.value,
                    NomeResponsavel: val.text,
                    Acao: "<a style='color:#d43f3a'" +
                        val.value +
                        "))'><i class='fa fa-trash'></i></a>"
                };

                var t = $('#datatable-default').DataTable();

                t.row.add([
                    obj.CodEmpresa,
                    obj.NomeEmpresa,
                    obj.CodResponsavel,
                    obj.NomeResponsavel,
                    obj.Acao
                ]).draw(false);

                listCodResponsavel = listCodResponsavel + ',' + obj.CodResponsavel

            });

            $("#ListCodResponsavel").val(listCodResponsavel);




            


            //$.ajax({
            //    type: 'POST',
            //    url: url,
            //    data: selected,
            //    success: function (data) {

                    
            //    },
            //    contentType: "application/json",
            //    dataType: 'json'
            //});
        }
    }
});

crud = {
    deleteRow: function (id) {


    }
}