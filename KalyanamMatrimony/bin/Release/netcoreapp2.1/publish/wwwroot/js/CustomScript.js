
$(document).ready(function () {

    $("#btnCreateProfile").click(function (event) {
        debugger;
        $('#v-pills-tab a[href="#v-pills-userinfo"]').tab('show');
        validateCreateProfile(event);
    });

    $(".custom-file-input").change(function () {
        readURL(this);
    });

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

function validateCreateProfile(event) {
    debugger;
    var errors = {
        Messages: []
    };
    if (document.getElementById('FirstName').value == "") {
        errors.Messages.push("The Frist Name field is required.");
    }
    if (document.getElementById('LastName').value == "") {
        errors.Messages.push("The Last Name field is required.");
    }
    if (document.getElementById('Email').value == "") {
        errors.Messages.push("The Email field is required.");
    }
    if (document.getElementById('Password').value == "") {
        errors.Messages.push("The Password field is required.");
    }

    if (errors.Messages.length > 0) {
        var ul = document.createElement('ul');
        for (var i = 0; i < errors.Messages.length; i++) {
            var li = document.createElement('li');
            li.innerHTML = errors.Messages[i];
            ul.appendChild(li);
        }
        $("#validationSummary").append(ul);
        event.preventDefault();
    }
    
}

function displayToast(jsonObj) {
    debugger;
    if (jsonObj != null) {
        switch (jsonObj.type) {
            case "info":
                toastr.info(jsonObj.message);
                break;
            case "success":
                toastr.success(jsonObj.message);
                break;
            case "error":
                toastr.error(jsonObj.message);
                break;
            case "warning":
                toastr.warning(jsonObj.message);
                break;
            default:
        }
    }
    
}