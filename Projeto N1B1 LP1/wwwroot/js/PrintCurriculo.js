function Print() {
    var restorepage = $('body').html();
    var printcontent = $('#Curriculo').clone();
    var htmlOriginal = printcontent.html();
    htmlOriginal += '<link href="/css/VisualizarCurriculo.css" rel="stylesheet" />';
    printcontent.html(htmlOriginal);
    $('body').empty().html(printcontent);
    window.print();
    $('body').html(restorepage);
}