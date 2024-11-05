new DataTable('#example');

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#example').DataTable({
        "ajax": { url: '/Admin/Product/GetAll' },
        "columns": [
            { data: 'name', "width": "15%" },
            { data: 'position', "width": "15%" },
            { data: 'salary', "width": "15%" },
            { data: 'office', "width": "15%" }
        ]
    });
}