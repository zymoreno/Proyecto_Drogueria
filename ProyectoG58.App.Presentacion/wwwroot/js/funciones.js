$(document).ready(function() {
    $( "#btnAgregaProducto" ).click(function() {
        
        //alert("Holaaaa");
        agregarCampo();
        
      });
});

$(document).on('click', '#eliminar', function (event) {
    event.preventDefault();
    $(this).closest('tr').remove();
});


/*function funcPrincipal()
{
    alert("Hola Ross");
    $("#btnAgregaProducto").on('click', funcNuevaCelda);
}

function funcNuevaCelda()
{
    $("#tablaDetalleVenta")
    .append
    (
        $('<tr>')
        .append
        (
            $('<td>')
            .append
            (
                $('<input>').attr('type', 'text').addClass('form-control')
            )
            
        )
        .append
        (
            $('<td>')
            .append
            (
                $('<input>').attr('type', 'text').addClass('form-control')
            )
            
        )
        .append
        (
            $('<td>')
            .append
            (
                $('<input>').attr('type', 'text').addClass('form-control')
            )
            
        )
        .append
        (
            $('<td>')
            .append
            (
                $('<input>').attr('type', 'text').addClass('form-control')
            )
            
        )
        .append
        (
            $('<td>')
            .append
            (
                $('<input>').attr('type', 'text').addClass('form-control')
            )
            
        )
        .append
        (
            $('<td>')
            .append
            (
                $('<div>').addClass('btn btn-danger').text('Eliminar')
            )
            
        )
    );

}*/

function agregarFila(selectProducto, inputCantidadProducto, inputVrUnitarioProducto, inputVrIvaProducto, inputVrParcialProducto) {
   
    var htmlTags = '<tr>'+
       //  '<td style="display: none">' + idPaquete + '</td>'+
         '<td>' + selectProducto + '</td>'+
         '<td>' + inputCantidadProducto + '</td>'+
         '<td>' + inputVrUnitarioProducto + '</td>'+
         '<td>' + inputVrIvaProducto + '</td>'+
         '<td>' + inputVrParcialProducto + '</td>'+
         '<td><input type="button" class="btn btn-warning borrar" value="Borrar" /></td>'+
       '</tr>';
       
    $('#tablaDetalleVenta tbody').append(htmlTags);

 }
 function agregarCampo()
 {
    var prod = document.getElementById("selectProducto").value;
    var cant = document.getElementById("inputCantidadProducto").value;
    var vunit = document.getElementById("inputVrUnitarioProducto").value;
    var viva = document.getElementById("inputVrIvaProducto").value;
    var vparcial = document.getElementById("inputVrParcialProducto").value;

    var htmlTags = '<tr>'+
       //  '<td style="display: none">' + idPaquete + '</td>'+
         '<td>' + prod + '</td>'+
         '<td>' + cant + '</td>'+
         '<td>' + vunit + '</td>'+
         '<td>' + viva + '</td>'+
         '<td>' + vparcial + '</td>'+
         '<td><input type="button" class="btn btn-warning borrar" id="eliminar" value="Eliminar" /></td>'+
       '</tr>';
       
    $('#tablaDetalleVenta tbody').append(htmlTags);
 }
