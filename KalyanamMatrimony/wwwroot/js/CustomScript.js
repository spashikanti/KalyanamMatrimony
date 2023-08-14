
$(document).ready(function () {
    $("#btnCreateProfile").click(function (event) {
        displayProgressBar(true);
        $('#v-pills-tab a[href="#v-pills-userinfo"]').tab('show');
        validateCreateProfile(event);
    });

    $(".custom-file-input").change(function () {
        readURL(this);
    });

    $.getJSON('../../data/masterData.json', function (jd) {
        $("#hdFileSizeLimit").val(jd.FileSizeLimit);
    });

    displayProgressBar(false);
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var fileSizeLimit = $("#hdFileSizeLimit").val();
        if (input.files[0].size > fileSizeLimit) {
            var actualSizeLimit = parseInt(fileSizeLimit) / 1024;
            alert('File Size Limit exceeded, Please upload photo below ' + actualSizeLimit + ' kb only.')
            $(input).val('');
            return false;
        }

        var fileName = $(input).val().split("\\").pop();
        $(input).next('.custom-file-label').html(fileName);

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
            $('#v-pills-tab a[href="#v-pills-partner"]').tab('show');
            break;
        case 8:
            $('#v-pills-tab a[href="#v-pills-photos"]').tab('show');
            break;
        default:
    }
}

function profileMoveNext(showTab) {
    switch (showTab) {
        case 1:
            $('#pills-tab a[href="#pills-userinfo"]').tab('show');
            break;
        case 2:
            $('#pills-tab a[href="#pills-personalInfo"]').tab('show');
            break;
        case 3:
            $('#pills-tab a[href="#pills-eduInfo"]').tab('show');
            break;
        case 4:
            $('#pills-tab a[href="#pills-familyInfo"]').tab('show');
            break;
        case 5:
            $('#pills-tab a[href="#pills-hobbies"]').tab('show');
            break;
        case 6:
            $('#pills-tab a[href="#pills-horoscope"]').tab('show');
            break;
        case 7:
            $('#pills-tab a[href="#pills-photos"]').tab('show');
            break;
        default:
    }
}

function validateCreateProfile(event) {
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
    if (document.getElementById('Password') != null && document.getElementById('Password').value == "") {
        errors.Messages.push("The Password field is required.");
    }
    if (document.getElementById('AboutYourself').value.length > 200) {
        errors.Messages.push("The About Yourself field value cannot exceed 200 characters.");
    }
    if (document.getElementById('AboutFamily').value.length > 200) {
        errors.Messages.push("The About Family field value cannot exceed 200 characters.");
    }
    if (document.getElementById('AstroProfile').value.length > 200) {
        errors.Messages.push("The Astrology Profile field value cannot exceed 200 characters.");
    }
    
    if (errors.Messages.length > 0) {
        var ul = document.createElement('ul');
        for (var i = 0; i < errors.Messages.length; i++) {
            var li = document.createElement('li');
            li.innerHTML = errors.Messages[i];
            ul.appendChild(li);
        }
        $("#validationSummary").empty();
        $("#validationSummary").append(ul);
        event.preventDefault();
        displayProgressBar(false);
    }
}

function displayToast(jsonObj) {
    jsonObj = JSON.parse(jsonObj);
    if (jsonObj != null) {
        switch (jsonObj.Type) {
            case 0:
                toastr.info(jsonObj.Message);
                break;
            case 1:
                toastr.warning(jsonObj.Message);
                break;
            case 2:
                toastr.error(jsonObj.Message);
                break;
            case 3:
                toastr.success(jsonObj.Message);
                break;
            default:
        }
    }
    
}

function displayProgressBar(isTrue) {
    if (isTrue)
        $("#divProgressBar").css("display", "block");
    else
        $("#divProgressBar").css("display", "none");
}