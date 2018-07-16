var series = "http://localhost:52567/api/series";
function serieDetalhes(serie) {
    return string = "http://localhost:52567/api/series/" + serie + "/";
}
//guarda a promise numa var de forma ao JQUERY ter acesso
let result;
let pessoa;
function serieEpisodios(serie) {
    return string = "http://localhost:52567/api/series/" + serie + "episodios/";
}

function seriePessoas(pessoa) {
    return string = "http://localhost:52567/api/series/pessoas/" + pessoa + "/";
}

document.addEventListener("DOMContentLoaded", function main(e) {

    ecraSeries();
});

function mostraSeries(series) {

    for (var i = 0; i < series.length; i++) {
        var serie = series[i];

        var divSerie = document.createElement("div");
        var imgSerie = document.createElement("img");
        var nomeSerie = document.createElement("p");




        divSerie.id = serie.nomeId;
        divSerie.className = "serieDiv";
        imgSerie.src = serie.SerieImg;
        imgSerie.id = serie.SerieImg;
        imgSerie.width = 128;
        imgSerie.height = 190;
        imgSerie.className = "imgSerie";
        nomeSerie.textContent = serie.NomeSerie;


        seriesContainer.appendChild(divSerie);
        divSerie.appendChild(imgSerie);
        divSerie.appendChild(nomeSerie);
    }

}

function mostraDetalhes(serie) {


    var imgSerie = document.createElement("img");
    var p = document.createElement("p");
    var p1 = document.createElement("p");
    var p2 = document.createElement("p");
    var p3 = document.createElement("p");
    var p4 = document.createElement("p");
    var p5 = document.createElement("p");

    var divTopo = document.createElement("div");
    var divInfo = document.createElement("div");
    var divImg = document.createElement("div");
    var divDetalhesTexto = document.createElement("div");
    var divDesc = document.createElement("div");
    var divDetalhesVideos = document.createElement("div");
    var divDetalhesRating = document.createElement("div");
    var divImdbLogo = document.createElement("div");

    divImdbLogo.id = "divImdbLogo";
    var imgLogo = document.createElement("img");
    imgLogo.src = "/img/imdb-logo.png";
    imgLogo.setAttribute("link", serie.Link);
    divImdbLogo.appendChild(imgLogo);

    var h1Rating = document.createElement("h1");
    h1Rating.textContent = "Rating";
    divDetalhesRating.appendChild(h1Rating);
    divDetalhesRating.id = "divDetalhesRating";
    divDetalhesVideos.id = "divDetalhesVideos";
    var pVideos = document.createElement("h1");
    pVideos.textContent = "Videos";
    divDetalhesVideos.appendChild(pVideos);

    //videos na seccao detalhes da serie
    for (var i = 0; i < serie.ListaDeVideos.length; i++) {
        var thumbnail = document.createElement("img");

        thumbnail.src = "https://vignette.wikia.nocookie.net/fantendo/images/3/35/Social-youtube-logo-grey.png/revision/latest?cb=20140105160310";
        thumbnail.width = 80;
        thumbnail.height = 80;
        thumbnail.id = "thumbnail";
        thumbnail.setAttribute("youtubeId", serie.ListaDeVideos[i].Video);
        thumbnail.setAttribute("titulo", serie.ListaDeVideos[i].Titulo);
        divDetalhesVideos.appendChild(thumbnail);
    }

    //rating da serie
    var divEstrelas = document.createElement("div");
    divEstrelas.id = "divEstrelas";
    var count = 0;
    for (var i = 0; i < 10 - serie.Rating; i++) {

        while (count < serie.Rating) {
            var spanFull = document.createElement("span");
            spanFull.className = "full";
            divEstrelas.appendChild(spanFull);
            count++;
        }
        var spanEmpty = document.createElement("span");
        spanEmpty.className = "empty";
        divEstrelas.appendChild(spanEmpty);

    }
    divDetalhesRating.appendChild(divEstrelas);







    divImg.id = "divImg";

    divTopo.id = "divTopo";
    divInfo.id = "divInfo";
    divDetalhesTexto.id = "divDetalhesTexto";
    divDesc.id = "divDesc";

    imgSerie.src = serie.SerieImg;
    imgSerie.id = serie.SerieImg;
    imgSerie.width = 128;
    imgSerie.height = 190;
    imgSerie.className = "img";

    p.textContent = "NOME:" + serie.Nome;
    p1.textContent = "TEMPORADAS:" + serie.Temporadas;
    p2.textContent = "Nº.EPISÓDIOS:" + serie.NEpisodios;
    p3.textContent = "REALIZADOR /S:" + serie.Realizador;
    p3.id = "realizador";
    p4.textContent = "ELENCO:" + serie.Elenco;
    p5.textContent = serie.Desc;


    divInfo.setAttribute("serie", serie.nomeId);

    divImg.appendChild(imgSerie);
    divTopo.appendChild(divImg);

    divDetalhesTexto.appendChild(p);
    divDetalhesTexto.appendChild(p1);
    divDetalhesTexto.appendChild(p2);
    divDetalhesTexto.appendChild(p3);
    divDetalhesTexto.appendChild(p4);

    var divPopup = document.createElement("div");
    seriesDetalhes.appendChild(divPopup);

    divTopo.appendChild(divDetalhesTexto);
    divTopo.appendChild(divDetalhesVideos);
    divTopo.appendChild(divDetalhesRating);
    divTopo.appendChild(divImdbLogo);

    divDesc.appendChild(p5);
    divTopo.appendChild(divDesc);
    var br = document.createElement("br");
    var slider = document.createElement("input");
    var img = document.createElement("img");

    slider.type = "range";
    slider.id = "slider";
    slider.value = "0";
    slider.min = "1";
    slider.max = serie.ListaEpisodios.length;
    slider.step = "1";
    img.id = "imgEp";
    img.src = serie.ListaEpisodios[0].Img;



    var nEp = document.createElement("p");
    nEp.textContent = "1";
    nEp.id = "sliderStatus";

    var divEpisodio = document.createElement("div");
    divEpisodio.id = "divEpisodio";

    //div que vai conter apena o slider
    divSlider = document.createElement("div");
    divSlider.id = "divSlider";
    divSlider.appendChild(slider);

    divEpisodio.appendChild(nEp);
    divEpisodio.appendChild(img);


    document.getElementById("seriesEpisodios").appendChild(divSlider);
    document.getElementById("seriesEpisodios").appendChild(divEpisodio);
    //document.getElementById("seriesEpisodios").appendChild(sliderValue);
    // document.getElementById("seriesEpisodios").appendChild(nEp);




    document.getElementById("seriesEpisodios").appendChild(br);



    seriesDetalhes.appendChild(divTopo);


}

function grab(url) {

    //var series = "http://localhost:52567/api/series";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            //debugger;
            if (resposta.status === 200) {

                return resposta.json();

            } else {
                return Promise.reject(new Error("Erro ao DADOS!"));
            }
        });

}
function ecraSeries() {

    return getSeries(series)

        .then(function (series) {
            mostraSeries(series);

        });
}


function ecraDetalhes(serie) {
    return grab(serieDetalhes(serie))

        .then(function (serie) {
            mostraDetalhes(serie)
            result = serie;
            console.log(result);
        });
}
function ecraPessoas(string) {
    return grab(seriePessoas(string))

        .then(function (string) {
            mostraPessoas(string)
            pessoa = pessoa;
            console.log(string);
        });

}

function mostraPessoas(string) {
    var nome = document.createElement("p");
    var role = document.createElement("p");
    var nasc = document.createElement("p");
    var texto = document.createElement("p");

    nome.textContent = string.PessoaNome;
    role.textContent = string.Role;
    nasc.textContent = string.DataNasc;
    texto.textContent = string.Texto;

    document.getElementById("seriesPessoas").appendChild(nome);
    document.getElementById("seriesPessoas").appendChild(role);
    document.getElementById("seriesPessoas").appendChild(nasc);
    document.getElementById("seriesPessoas").appendChild(texto);

}

function muda() {


    document.getElementById("seriesContainer").style.display = "flex";
    document.getElementById("seriesDetalhes").style.display = "none";
    document.getElementById("seriesEpisodios").style.display = "none";
    document.getElementById("seriesPessoas").style.display = "none";
    document.getElementById("divSlider").innerHTML = "";
    document.getElementById("divEpisodio").innerHTML = "";
    document.getElementById("button").style.display = "none";


}
$(document).on("click", '#button', function () {
    console.log("botao");
    $('#divEpisodio').remove();
    $('#divSlider').remove();


});


$(document).on("click", '#seriesContainer > div', function () {
    document.getElementById("seriesContainer").style.display = "none";
    $('#button').show();
    ecraDetalhes($(this).attr('id'));
    document.getElementById("seriesDetalhes").innerHTML = "";
    document.getElementById("seriesDetalhes").style.display = "flex";
    document.getElementById("seriesEpisodios").style.display = "flex";
    console.log(serieDetalhes($(this).attr('id')));



});

$(document).on('input change', '#slider', function () {
    //listen to slider changes
    var v = $(this).val();//valor do slider
    v--;//começa no 0
    $('#sliderStatus').html($(this).val());
    $("#imgEp").prop("src", result.ListaEpisodios[v].Img);

});

//popup do episodio
$(document).on('click', '#imgEp', function () {
    //listen to slider changes
    //vai buscar o index do ep
    var ep = $('#sliderStatus').text();
    ep--;
    //limpa o div
    $('#popupEpisodio').children().remove();
    $('#divSlider').hide();
    var object = document.createElement("object");
    var h1 = document.createElement("h1");

    h1.textContent = result.ListaEpisodios[ep].Titulo;

    object.data = 'https://www.youtube.com/embed/' + result.ListaEpisodios[ep].Episodio;
    object.width = 360;
    object.height = 400;
    object.setAttribute("allowfullscreen", "");

    $('#popupEpisodio').append(object);
    $('#popupEpisodio').append(h1);

    $('#popupEpisodio').show();
    console.log(result.ListaEpisodios[ep].Episodio);
});
//esconde o popup
$(document).on("click", '#popupEpisodio', function () {
    $('#popupEpisodio').children().remove();

    $('#divSlider').show();
    $('#popupEpisodio').hide();



});
//redirecionamento para a pagina do IMDB
$(document).on("click", '#divImdbLogo > img', function () {
    window.open($(this).attr('link'), '_blank');



});

//popup dos videos/traillers

$(document).on("click", '#divDetalhesVideos > img', function () {
    $('#popupEpisodio').children().remove();
    $('#divSlider').hide();
    var object = document.createElement("object");
    var h1 = document.createElement("h1");
    h1.textContent = $(this).attr("titulo");

    object.data = 'https://www.youtube.com/embed/' + $(this).attr("youtubeId");
    object.width = 360;
    object.height = 400;
    object.setAttribute("allowfullscreen", "");

    document.getElementById("popupEpisodio").appendChild(object);
    document.getElementById("popupEpisodio").appendChild(h1);
    $('#popupEpisodio').show();



});
//clica no nome do realizador e leva para o seu ecra
$(document).on("click", '#realizador', function () {
    var pessoa = $(this).text();

    var string = pessoa.split(':')[1];
    string = string.split(' ')[0];
    ecraPessoas(string);
});


