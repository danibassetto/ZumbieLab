﻿$(document).ready(function () {
    getDataTable('#contact-table')
    getDataTable('#user-table')

    $('.btn-total-contatos').click(function () {
        var userId = $(this).attr('user-id');

        $.ajax({
            type: 'GET',
            url: '/User/GetByUserId?userId=' + userId,
            success: function (result) {
                $("#listContactUser").html(result);
                $('#modalContactUser').modal('show');
                getDataTable('#contact-user-table');
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
            "sLengthMenu": "Mostrar _MENU_ registros por pagina",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
            "sZeroRecords": "Nenhum registro encontrado",
            "sSearch": "Pesquisar",
            "oPaginate": {
                "sNext": "Proximo",
                "sPrevious": "Anterior",
                "sFirst": "Primeiro",
                "sLast": "Ultimo"
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

function formatarTelefone(input) {
    let phone = input.value.replace(/\D/g, '');

    if (phone.length === 11) {
        input.value = `(${phone.slice(0, 2)}) ${phone.slice(2, 7)}-${phone.slice(7)}`;
    } else {
        input.value = `(${phone.slice(0, 2)}) ${phone.slice(2, 6)}-${phone.slice(6)}`;
    }
}