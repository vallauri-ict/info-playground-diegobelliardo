"use strict"

$(document).ready(function() {
    let _viaggioDiv = $("#Viaggio");

    let request = inviaRichiesta("get", "/api/viaggi");
    request.done(function (data) {
        let children = _viaggioDiv.children();
        children.eq(0).html(data[0].cognomeAutista + " " + data[0].nomeAutista);
        children.eq(1).html(data[0].cittaPartenza + " -> " + data[0].cittaArrivo);
        children.eq(2).html(data[0].costo + "€");

        let _table = _viaggioDiv.find("tbody").html("");
        for(let item of data)
        {
            $("<tr>", {
                "appendTo" : _table,
                "append" : [
                    $("<td>", { "html" : item.nomePasseggero }),
                    $("<td>", { "html" : item.cognomePasseggero })
                ]
            });
        }
    });
    request.fail(errore);
});