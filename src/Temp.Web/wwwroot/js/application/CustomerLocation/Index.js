$(document).ready(function () {
    $("#CountryList").on("change", function () {
        $.ajax({
            type: "POST",
            url: "/CustomerLocation/GetState",
            data: { "CountryId": $("#CountryList").val() },
            success: function (response) {
                var items = '';
                $(response).each(function () {
                    items += "<option value=" + this.value + ">" + this.text + "</option>";
                });
                $("#StateList").html(items);
            },
            failure: function (response) {
                alert(response.responseText);
            },
            error: function (response) {
                alert(response.responseText);
            }
        });
    });
});
