var vm = new Vue({
    el: "#form",
    data: {
        params: {
            relato:""
        },
        loading: false
    },
    mounted: function () {
        var self = this;
        (function ($) {

            'use strict';

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
        GetRelatoByNumRelato: function () {
            var self = this;
            self.ShowLoad(true, "vRelato");

            axios.get("GetRelatoByNumRelato/?numRelato=" + self.params.relato).then(result => {

                if (result.data !== false) {
                    new PNotify({
                        title: 'Relato',
                        text: result.data,
                        type: 'error'
                    });
                }

                self.ShowLoad(false, "vRelato");

                window.location.href = "Cancel/?id=" + result.data;

            }).catch(error => {
                Site.Notification("Erro ao buscar e analisar dados", error.response.data, "error", 1);
                self.ShowLoad(false, "vRelato");
            });
        }
    }
});
