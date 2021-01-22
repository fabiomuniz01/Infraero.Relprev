
var vm = new Vue({
    el: "#parecer",
    data: {
        params: {
            acao: ""
        },
        loading: false
    },
    mounted: function () {
        var self = this;
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
        CompleteParecer: function () {
            var self = this;
            document.getElementById("acao").value = "complete";

            document.getElementById('tituloNumRelato').innerHTML =
                "<i class='fa fa-fw fa-file-text-o'></i>&nbsp;&nbsp;Complementar Parecer Técnico";
            $('#myMsgNumRelatoModal').modal('show');
        },
        EvaluateParecer: function () {
            var self = this;
            document.getElementById("acao").value = "evaluate";

            document.getElementById('tituloNumRelato').innerHTML =
                "<i class='fa fa-fw fa-tags'></i>&nbsp;&nbsp;Avaliar Parecer Técnico";
            $('#myMsgNumRelatoModal').modal('show');
        },
        ReplyParecer: function () {
            var self = this;
            document.getElementById("acao").value = "reply";
            document.getElementById('tituloNumRelato').innerHTML =
                "<i class='fa fa-fw fa-reply-all'></i>&nbsp;&nbsp;Responder Parecer Técnico";
            $('#myMsgNumRelatoModal').modal('show');
        },
        CreateParecer: function () {
            var self = this;
            document.getElementById("acao").value = "create";
            document.getElementById('tituloNumRelato').innerHTML =
                "<i class='fa fa-fw fa-reply-all'></i>&nbsp;&nbsp;Responder Parecer Técnico";
            $('#myMsgNumRelatoModal').modal('show');
        }
    }
});

var vmModal = new Vue({
    el: "#myMsgNumRelatoModal",
    data: {
        params: {
            relato: ""
        },
        loading: false
    },
    mounted: function () {
        var self = this;
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
        GetRelatoByNumRelato: function () {
            var self = this;

            var acao = $("#acao").val();

            axios.get("Parecer/GetRelatoByNumRelato/?numRelato=" + self.params.relato).then(result => {

                if (result.data !== false) {
                    new PNotify({
                        title: 'Parecer',
                        text: result.data,
                        type: 'error'
                    });
                }
                switch (acao) {
                    case "complete":
                        window.location.href = "Parecer/Complete/" + result.data;
                        break;
                    case "reply":
                        window.location.href = "Parecer/Reply/" + result.data;
                        break;
                    case "create":
                        window.location.href = "Parecer/create/" + result.data;
                        break;
                    case "evaluate":
                        window.location.href = "Parecer/Evaluate/" + result.data;
                        break;
                    default:
                }

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
            });
        }
    }
});