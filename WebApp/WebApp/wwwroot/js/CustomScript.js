














//Users.cshtml
function confirmDelete(element) {
    bootbox.confirm({
        message: "Are you sure you want to delete this employee?",
        size: "xl",
        callback: function (result) {
            if (result) {
                element.closest("form").submit();
            }
        }
    });
}