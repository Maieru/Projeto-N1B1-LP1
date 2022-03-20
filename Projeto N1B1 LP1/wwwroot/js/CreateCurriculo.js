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

function adicionaExperienciaProfissional() {
    var divsDeExperienciaProfissional = $("[id = ExperienciaProfissional]");
    var numeroDeExpProfissionaisDisponiveis = numeroDeExpProfissionais;

    for (var i = 0; i < divsDeExperienciaProfissional.length; i++) {
        if ($(divsDeExperienciaProfissional[i]).is(":hidden")) {
            divsDeExperienciaProfissional[i].removeAttribute("hidden")
            numeroDeExpProfissionaisDisponiveis--;
            break;
        }
        else
            numeroDeExpProfissionaisDisponiveis--;
    }

    if (numeroDeExpProfissionaisDisponiveis == 0)
        $("#btnAdicionaExpProf").attr("hidden", true);
}

function excluiExperienciaProfissional(numeroDaExpProfissional) {
    var divSelecionada = $("#ConteudoInternoExperienciasProfissionais").children()[numeroDaExpProfissional];
    $(divSelecionada).attr("hidden", true);

    // Retorna os campos para um valor vazio
    $(`[name = CargoOcupadoExp${numeroDaExpProfissional + 1}`).val("");
    $(`[name = DataInicioExp${numeroDaExpProfissional + 1}`).val("");
    $(`[name = DataTerminoExp${numeroDaExpProfissional + 1}`).val("");

    if ($("#btnAdicionaExpProf").is(":hidden"))
        $("#btnAdicionaExpProf").removeAttr("hidden")
}