function DeleteConfirmation(Id) {
    swal({
        title: "Você Tem Certeza?",
        text: "Uma vez deletada, você não conseguirá recuperar esse registro!",
        icon: "warning",
        buttons: true,
        dangerMode: true,
        })
        .then((willDelete) => {
            if (willDelete) {
                swal("Deletado com Sucesso", {
                    icon: "success",
                }).then(() => location.href = `Curriculo/Delete?Id=${Id}`);
            }
        });
}