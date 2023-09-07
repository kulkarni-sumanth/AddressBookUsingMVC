//$(document).ready(function () {
//    $('#add').click(function () {
//        $.ajax({
//            url: '/Employee/DisplayAddForm',
//            type: 'GET',
//            success: function (result) {
//                $('#partial-view').html(result);
//            }
//        });
//    });

//    $('#back').click(function () {
//        var employeeId = $(this).data('employee-id');
//        $.ajax({
//            url: '/Employee/_DisplayEmployeeDetails/' + employeeId,
//            type: 'GET',
//            success: function (result) {
//                $('#partial-view').html(result);
//            }
//        });
//    });

//    $('#edit').click(function () {
//        var employeeId = $(this).data('employee-id');
//        $.ajax({
//            url: '/Employee/DisplayEditForm/' + employeeId,
//            type: 'GET',
//            success: function (result) {
//                $('#partial-view').html(result);
//            }
//        });
//    });

//    $('.list-item').click(function () {
//        var employeeId = $(this).data('employee-id');
//        $.ajax({
//            url: '/Employee/_DisplayEmployeeDetails/' + employeeId,
//            type: 'GET',
//            success: function (result) {
//                $('#partial-view').html(result);
//            }
//        });
//    });
//});