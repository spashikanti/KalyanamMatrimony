
$(document).ready(function () {

    //$('.custom-file-input').on("change", function () {
        
    //    readURL(this);

    //    //if (fileName !== null && fileName !== undefined && fileName !== "") {
    //    //    debugger;
    //    //    var reader = new FileReader();

    //    //    reader.onload = function (e) {
    //    //        debugger;
    //    //        $('#profile-img-tag').attr('src', e.target.result);

    //    //    }

    //    //    reader.readAsDataURL($(this).files[0]);
            
    //    //    //$(this).next('.img-profile').attr('src', $(this).val());

    //    //    //reader.readAsDataURL(input.files[0]);
    //    }
    //});

    $(".custom-file-input").change(function () {
        readURL(this);
    });

    function readURL(input) {
        debugger;
        var fileName = $(input).val().split("\\").pop();
        $(input).next('.custom-file-label').html(fileName);

        if (input.files && input.files[0]) {
            var reader = new FileReader();

            reader.onload = function (e) {
                if (input.id === "PhotoFile1")
                    $('#imgProfile1').attr('src', e.target.result);
                if (input.id === "PhotoFile2")
                    $('#imgProfile2').attr('src', e.target.result);
                if (input.id === "PhotoFile3")
                    $('#imgProfile3').attr('src', e.target.result);
            }
            reader.readAsDataURL(input.files[0]);
        }
    }


});


function moveNext(showTab) {
    debugger;
    switch (showTab) {
        case 1:
            $('#v-pills-tab a[href="#v-pills-userinfo"]').tab('show');
            break;
        case 2:
            $('#v-pills-tab a[href="#v-pills-personalInfo"]').tab('show');
            break;
        case 3:
            $('#v-pills-tab a[href="#v-pills-eduInfo"]').tab('show');
            break;
        case 4:
            $('#v-pills-tab a[href="#v-pills-familyInfo"]').tab('show');
            break;
        case 5:
            $('#v-pills-tab a[href="#v-pills-hobbies"]').tab('show');
            break;
        case 6:
            $('#v-pills-tab a[href="#v-pills-horoscope"]').tab('show');
            break;
        case 7:
            $('#v-pills-tab a[href="#v-pills-photos"]').tab('show');
            break;
        default:
    }
}