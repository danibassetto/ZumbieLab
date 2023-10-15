$(document).ready(function () {
    getDataTable('#user-table')
    getDataTable('#host-table')

    $('.btn-show-attributes').click(function () {
        var userId = $(this).attr('user-id');

        $.ajax({
            type: 'GET',
            url: '/Host/ShowAttributes/' + userId,
            success: function (result) {
                $("#hostShowAttributes").html(result);
                $('#modalShowAttributes').modal('show');
                $('#show-attributes-table').DataTable({
                    "paging": false,
                    "searching": false
                });
            }
        });
    });
});

function getDataTable(id) {
    $(id).DataTable({
        "ordering": true,
        "paging": true,
        "searching": true,
        "oLanguage": {
            "sEmptyTable": "Nenhum registro encontrado na tabela",
            "sInfo": "Mostrar _START_ at&eacute; _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrar 0 at&eacute; 0 de 0 Registros",
            "sInfoFiltered": "(Filtrar de _MAX_ total registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Próximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Último"
            },
            "oAria": {
                "sSortAscending": ": Ordenar colunas de forma ascendente",
                "sSortDescending": ": Ordenar colunas de forma descendente"
            }
        }
    });
}

$('.close-alert').click(function () {
    $('.alert').hide('hide');
});

$(document).ready(function () {
    $("#showHidePassword").on('click', function () {
        var passwordField = $("#password");
        var passwordFieldType = passwordField.attr('type');
        if (passwordFieldType === 'password') {
            passwordField.attr('type', 'text');
            $("#showHidePassword i").removeClass('fa-eye').addClass('fa-eye-slash');
        } else {
            passwordField.attr('type', 'password');
            $("#showHidePassword i").removeClass('fa-eye-slash').addClass('fa-eye');
        }
    });
});