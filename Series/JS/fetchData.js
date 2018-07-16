function getSeries () {

    var series = "http://localhost:52567/api/series";

    return fetch(series, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao obter as Series"));
            }
        });

}
function getDetalhes(serieId) {
    var url = "/api/series/" + serieId + "/";
    return fetch(series, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao obter os detalhes das Series"));
            }
        });

}