var vm = new Vue({
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
            var $DtOcorrencia = $("#DtOcorrencia");
            $DtOcorrencia.mask('00/00/0000', { reverse: false });
            $('#DtOcorrencia').datepicker({
	            format: "dd/mm/yyyy",
	            todayBtn: "linked",
	            language: "pt-BR",
	            orientation: "bottom left",
	            autoclose: true
            });

            $('#custom-file-input').on("change", function () {

	            var files = $(this)[0].files;

                $('#arquivosDatatable').DataTable({
                    data: files,
		            "columns": [
			            { "data": "name" },
			            {
				            "data": null,
				            "sortable": false,
				            "render": function (c) {
					            return "<a style='color:#eea236' href='javascript:(crud.editModal(" +
						            c.Id +
						            "))'><i class='fa fa-pencil'></i></a>&nbsp;&nbsp; " +
						            "<a style='color:#d43f3a' href='javascript:(crud.deleteModal(" +
						            c.Id +
						            "))'><i class='fa fa-trash'></i></a>";
				            }
			            }
		            ]
	            });
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

            /*
             * When you change the value the select via select2, it triggers
             * a 'change' event, but the jquery validation plugin
             * only re-validates on 'blur'*/

            $select.on('change', function () {
                $(this).trigger('blur');
            });

            $("#ddlEmpresa").change(function () {

                var url = "GetUnidadeByIdEmpresa";

                var ddlSource = "#ddlEmpresa";

                $.getJSON(url,
                    { id: $(ddlSource).val() },
                    function (data) {
                        var items = '';
                        $("#ddlUnidadeInfraestrutura").empty;
                        $.each(data,
                            function (i, row) {
                                items += "<option value='" + row.value + "'>" + row.text + "</option>";
                            });
                        $("#ddlUnidadeInfraestrutura").html(items);
                    });
            });

            var $numCpf = $("#cpf");
            $numCpf.mask('000.000.000-00', { reverse: false });

            var $numTel = $("#NumTelefoneRelator");
            $numTel.mask('(00) 0000-0000');

            $("#form").validate({
                rules: {
                    "EndEmail": {
                        required: true,
                        email: true
                    },
                },
                messages: {
                    "EndEmail": {
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
        },
        ExisteCpf: function () {
            var self = this;
            self.ShowLoad(true, "vUsuario");

            axios.get("GetUsuarioByCpf/?cpf=" + self.params.cpf).then(result => {

                if (result.data !== false) {
                    new PNotify({
                        title: 'Usuario',
                        text: result.data,
                        type: 'error'
                    });
                }

                self.ShowLoad(false, "vUsuario");

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                self.ShowLoad(false, "vUsuario");
            });
        }
    }
});

function UploadFile() {

	var fileUpload = $("#files").get(0);

	var files = fileUpload.files;

	var data = new FormData();

	data.append(files[0].name, files[0]);

	$.ajax({

		type: "POST",

		url: "UploadFile",

		contentType: false,

		processData: false,

		data: data,

		async: false,

		beforeSend: function () {

			$("#divloader").show()

		},

		success: function (message) {

			alert(message);
			$('input[name="hidenFile"]').val(message);

		},

		error: function () {

			alert("Error!");

		},

		complete: function () {

			$("#divloader").hide()

		}

	});

}