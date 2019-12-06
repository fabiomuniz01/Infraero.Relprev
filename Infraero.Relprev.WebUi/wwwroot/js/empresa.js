//$(document).ready(function () {
    
//    $('#dataTables').dataTable({

//        "ajax": {
//            'url': "api/PerfilApi/GetPerfilGrid",
//            'type': "GET",
//            'contentType': "application/json; charset=utf-8"
//        },

//        "columns": [
//            { "data": "Empresa" },
//            { "data": "cnpj" },
//            { "data": "telefone" },
//            { "data": "unid" },
//            {
//                "data": null,
//                "sortable": false,
//                "render": function (c) {
//                    return "<a style='color:#eea236' href='javascript:(crud.editModal(" +
//                        c.Id +
//                        "))'><i class='fa fa-pencil'></i></a>&nbsp;&nbsp; " +
//                        "<a style='color:#d43f3a' href='javascript:(crud.deleteModal(" +
//                        c.Id +
//                        "))'><i class='fa fa-trash'></i></a>";
//                }
//            }
//        ],
//        "columnDefs": [
//            { "width": "5%", "targets": 0, "className": "dt-center" },
//            { "width": "70%", "targets": 1 },
//            { "width": "15%", "targets": 2, "className": "dt-center" },
//            { "width": "10%", "targets": 3, "className": "dt-center" }
//        ],
//        "createdRow": function (row, data, index) {
//            if (data.FlagAtivo === 'INATIVO') {
//                $('td', row).eq(2).css('color', 'red');
//            } else {
//                $('td', row).eq(2).css('color', 'green');
//            }
//        },
//        //"autoWidth": true,
//        "language": {
//            "sEmptyTable": "Nenhum registro encontrado",
//            "sInfo": "Mostrando de _START_ até _END_ de _TOTAL_ registros",
//            "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
//            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
//            "sInfoPostFix": "",
//            "sInfoThousands": ".",
//            "sLengthMenu": "_MENU_ resultados por página",
//            "sLoadingRecords": "Carregando...",
//            "sProcessing": "Processando...",
//            "sZeroRecords": "Nenhum registro encontrado",
//            "sSearch": "Pesquisar: ",
//            "oPaginate": {
//                "sNext": "Próximo →" +
//                    "" +
//                    "",
//                "sPrevious": "← Anterior",
//                "sFirst": "Primeiro",
//                "sLast": "Último"
//            },
//            "oAria": {
//                "sSortAscending": ": Ordenar colunas de forma ascendente",
//                "sSortDescending": ": Ordenar colunas de forma descendente"
//            }
//        },
//        "responsive": false
//    });

//});

(function ($) {

    'use strict';

    var datatableInit = function () {

        $('#datatable-default').dataTable({
            dom: '<"row"<"col-lg-6"l><"col-lg-6"f>><"table-responsive"t>p',
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