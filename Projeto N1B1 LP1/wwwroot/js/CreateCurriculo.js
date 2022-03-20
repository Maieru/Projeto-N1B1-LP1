var numeroDeFormacoes = 5;
var numeroDeExpProfissionais = 3;
var numeroDeIdiomas = 5;

function adicionaIdioma() {
    var divsDeIdioma = $("[id = Idioma]");
    var numeroDeIdiomasDisponiveis = numeroDeIdiomas;

    for (var i = 0; i < divsDeIdioma.length; i++) {
        if ($(divsDeIdioma[i]).is(":hidden")) {
            divsDeIdioma[i].removeAttribute("hidden")
            numeroDeIdiomasDisponiveis--;
            break;
        }
        else
            numeroDeIdiomasDisponiveis--;
    }

    if (numeroDeIdiomasDisponiveis == 0)
        $("#btnAdicionaIdioma").attr("hidden", true);
}

function excluiIdioma(numeroDoIdioma) {
    var divSelecionada = $("#ConteudoInternoIdiomas").children()[numeroDoIdioma];
    $(divSelecionada).attr("hidden", true);

    // Retorna os campos para um valor vazio
    $(`[name = Idioma${numeroDoIdioma + 1}`).val(0);
    $(`[name = LeituraIdioma${numeroDoIdioma + 1}`).val(0);
    $(`[name = EscutarIdioma${numeroDoIdioma + 1}`).val(0);
    $(`[name = FalarIdioma${numeroDoIdioma + 1}`).val(0);

    if ($("#btnAdicionaIdioma").is(":hidden"))
        $("#btnAdicionaIdioma").removeAttr("hidden")
}