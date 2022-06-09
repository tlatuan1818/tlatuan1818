$(document).ready(function () {
    $('#dataTable').dataTable({
      
        "language": {
            "lengthMenu": "Hiển thị _MENU_ sản phẩm của trang",
            "zeroRecords": "Không tìm thấy sản phẩm bạn tìm",
            "info": "Trang _PAGE_ của _PAGES_ trang",
            "infoFiltered": "( Tìm thấy _MAX_ sản phẩm)"
            
        },
        "scrollY": "500px",
        "scrollCollapse": true,
    });
});


