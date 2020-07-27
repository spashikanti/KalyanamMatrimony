$(document).ready(function () {
    var ddlMaritalStatus = $('#MaritalStatus');
    ddlMaritalStatus.empty();
    ddlMaritalStatus.append('<option disabled>Choose Marital Status</option>');
    ddlMaritalStatus.prop('selectedIndex', 0);

    var ddlBodyType = $('#BodyType');
    ddlBodyType.empty();
    ddlBodyType.append('<option disabled>Choose Body Type</option>');
    ddlBodyType.prop('selectedIndex', 0);

    var ddlHeight = $('#Height');
    ddlHeight.empty();
    ddlHeight.append('<option disabled>Choose Height</option>');
    ddlHeight.prop('selectedIndex', 0);

    var ddlComplexion = $('#Complexion');
    ddlComplexion.empty();
    ddlComplexion.append('<option disabled>Choose Complexion</option>');
    ddlComplexion.prop('selectedIndex', 0);

    var ddlMotherTongue = $('#MotherTongue');
    ddlMotherTongue.empty();
    ddlMotherTongue.append('<option disabled>Choose Mother Tongue</option>');
    ddlMotherTongue.prop('selectedIndex', 0);

    var ddlBloodGroup = $('#BloodGroup');
    ddlBloodGroup.empty();
    ddlBloodGroup.append('<option disabled>Choose Blood Group</option>');
    ddlBloodGroup.prop('selectedIndex', 0);

    var ddlDiet = $('#Diet');
    ddlDiet.empty();
    ddlDiet.append('<option disabled>Choose Diet</option>');
    ddlDiet.prop('selectedIndex', 0);

    var ddlSmoke = $('#Smoke');
    ddlSmoke.empty();
    ddlSmoke.append('<option disabled>Choose Smoke</option>');
    ddlSmoke.prop('selectedIndex', 0);

    var ddlDrink = $('#Drink');
    ddlDrink.empty();
    ddlDrink.append('<option disabled>Choose Drink</option>');
    ddlDrink.prop('selectedIndex', 0);

    var ddlFamilyValues = $('#FamilyValues');
    ddlFamilyValues.empty();
    ddlFamilyValues.append('<option disabled>Choose Family Values</option>');
    ddlFamilyValues.prop('selectedIndex', 0);

    var ddlRasi = $('#Rasi');
    ddlRasi.empty();
    ddlRasi.append('<option disabled>Choose Rasi</option>');
    ddlRasi.prop('selectedIndex', 0);

    var ddlNakshatram = $('#Nakshatram');
    ddlNakshatram.empty();
    ddlNakshatram.append('<option disabled>Choose Nakshatram</option>');
    ddlNakshatram.prop('selectedIndex', 0);

    var ddlReligion = $('#Religion');
    ddlReligion.empty();
    ddlReligion.append('<option disabled>Choose Religion</option>');
    ddlReligion.prop('selectedIndex', 0);

    var ddlCaste = $('#Caste');
    ddlCaste.empty();
    ddlCaste.append('<option disabled>Choose Caste</option>');
    ddlCaste.prop('selectedIndex', 0);

    //Partner Preference
    var ddlPMaritalStatus = $('#PartnerPreference_MaritalStatus');
    ddlPMaritalStatus.empty();
    ddlPMaritalStatus.append('<option disabled>Choose Marital Status</option>');
    ddlPMaritalStatus.prop('selectedIndex', 0);

    var ddlPBodyType = $('#PartnerPreference_BodyType');
    ddlPBodyType.empty();
    ddlPBodyType.append('<option disabled>Choose Body Type</option>');
    ddlPBodyType.prop('selectedIndex', 0);

    var ddlPHeightFrom = $('#PartnerPreference_HeightFrom');
    ddlPHeightFrom.empty();
    ddlPHeightFrom.append('<option disabled>Choose Height From</option>');
    ddlPHeightFrom.prop('selectedIndex', 0);

    var ddlPHeightTo = $('#PartnerPreference_HeightTo');
    ddlPHeightTo.empty();
    ddlPHeightTo.append('<option disabled>Choose Height To</option>');
    ddlPHeightTo.prop('selectedIndex', 0);

    var ddlPComplexion = $('#PartnerPreference_Complexion');
    ddlPComplexion.empty();
    ddlPComplexion.append('<option disabled>Choose Complexion</option>');
    ddlPComplexion.prop('selectedIndex', 0);

    var ddlPMotherTongue = $('#PartnerPreference_MotherTongue');
    ddlPMotherTongue.empty();
    ddlPMotherTongue.append('<option disabled>Choose Mother Tongue</option>');
    ddlPMotherTongue.prop('selectedIndex', 0);

    var ddlPReligion = $('#PartnerPreference_Religion');
    ddlPReligion.empty();
    ddlPReligion.append('<option disabled>Choose Religion</option>');
    ddlPReligion.prop('selectedIndex', 0);

    var ddlPCaste = $('#PartnerPreference_Caste');
    ddlPCaste.empty();
    ddlPCaste.append('<option disabled>Choose Caste</option>');
    ddlPCaste.prop('selectedIndex', 0);

    var ddlPDiet = $('#PartnerPreference_Diet');
    ddlPDiet.empty();
    ddlPDiet.append('<option disabled>Choose Diet</option>');
    ddlPDiet.prop('selectedIndex', 0);

    var ddlPSmoke = $('#PartnerPreference_Smoke');
    ddlPSmoke.empty();
    ddlPSmoke.append('<option disabled>Choose Smoke</option>');
    ddlPSmoke.prop('selectedIndex', 0);

    var ddlPDrink = $('#PartnerPreference_Drink');
    ddlPDrink.empty();
    ddlPDrink.append('<option disabled>Choose Drink</option>');
    ddlPDrink.prop('selectedIndex', 0);

    $("#Religion").on("change", function () {
        var religion = "";
        $("#Religion option:selected").each(function () {
            religion = $(this).text();
        });

        $.getJSON('../../data/masterData.json', function (jd) {
            $.each(jd.Religion, function (key, entry) {
                if (entry.item == religion) {
                    ddlCaste.empty();
                    ddlCaste.append('<option disabled>Choose Caste</option>');
                    ddlCaste.prop('selectedIndex', 0);

                    loadDropdowns(entry.Caste, ddlCaste);
                    //Set Dropdowns if hiddenfields has value
                    if ($("#hdCaste") != null && $("#hdCaste").val() != undefined) {
                        document.getElementById("Caste").value = $("#hdCaste").val();
                    }
                }
            });
        });

    });

    $("#PartnerPreference_Religion").on("change", function () {
        var religion = "";
        $("#PartnerPreference_Religion option:selected").each(function () {
            religion = $(this).text();
        });

        $.getJSON('../../data/masterData.json', function (jd) {
            $.each(jd.Religion, function (key, entry) {
                if (entry.item == religion) {
                    ddlPCaste.empty();
                    ddlPCaste.append('<option disabled>Choose Caste</option>');
                    ddlPCaste.prop('selectedIndex', 0);

                    loadDropdowns(entry.Caste, ddlPCaste);
                    //Set Dropdowns if hiddenfields has value
                    if ($("#hdPCaste") != null && $("#hdPCaste").val() != undefined) {
                        document.getElementById("PartnerPreference_Caste").value = $("#hdPCaste").val();
                    }
                }
            });
        });

    });

    $.getJSON('../../data/masterData.json', function (jd) {
        loadDropdowns(jd.Height, ddlHeight);
        loadDropdowns(jd.MaritalStatus, ddlMaritalStatus);
        loadDropdowns(jd.BodyType, ddlBodyType);
        loadDropdowns(jd.Complexion, ddlComplexion);
        loadDropdowns(jd.MotherTongue, ddlMotherTongue);
        loadDropdowns(jd.BloodGroup, ddlBloodGroup);
        loadDropdowns(jd.Diet, ddlDiet);
        loadDropdowns(jd.Smoke, ddlSmoke);
        loadDropdowns(jd.Drink, ddlDrink);
        loadDropdowns(jd.FamilyValues, ddlFamilyValues);
        loadDropdowns(jd.Rasi, ddlRasi);
        loadDropdowns(jd.Nakshatram, ddlNakshatram);
        loadDropdowns(jd.Religion, ddlReligion);

        loadDropdowns(jd.MaritalStatus, ddlPMaritalStatus);
        loadDropdowns(jd.BodyType, ddlPBodyType);
        loadDropdowns(jd.Height, ddlPHeightFrom);
        loadDropdowns(jd.Height, ddlPHeightTo);
        loadDropdowns(jd.Complexion, ddlPComplexion);
        loadDropdowns(jd.MotherTongue, ddlPMotherTongue);
        loadDropdowns(jd.Religion, ddlPReligion);
        loadDropdowns(jd.Diet, ddlPDiet);
        loadDropdowns(jd.Smoke, ddlPSmoke);
        loadDropdowns(jd.Drink, ddlPDrink);

        //Set Dropdowns if hiddenfields has value
        if ($("#hdHeight") != null && $("#hdHeight").val() != undefined) {
            document.getElementById("Height").value = $("#hdHeight").val();
        }
        if ($("#hdMaritalStatus") != null && $("#hdMaritalStatus").val() != undefined) {
            document.getElementById("MaritalStatus").value = $("#hdMaritalStatus").val();
        }
        if ($("#hdBodyType") != null && $("#hdBodyType").val() != undefined) {
            document.getElementById("BodyType").value = $("#hdBodyType").val();
        }
        if ($("#hdComplexion") != null && $("#hdComplexion").val() != undefined) {
            document.getElementById("Complexion").value = $("#hdComplexion").val();
        }
        if ($("#hdMotherTongue") != null && $("#hdMotherTongue").val() != undefined) {
            document.getElementById("MotherTongue").value = $("#hdMotherTongue").val();
        }
        if ($("#hdBloodGroup") != null && $("#hdBloodGroup").val() != undefined) {
            document.getElementById("BloodGroup").value = $("#hdBloodGroup").val();
        }
        if ($("#hdDiet") != null && $("#hdDiet").val() != undefined) {
            document.getElementById("Diet").value = $("#hdDiet").val();
        }
        if ($("#hdSmoke") != null && $("#hdSmoke").val() != undefined) {
            document.getElementById("Smoke").value = $("#hdSmoke").val();
        }
        if ($("#hdDrink") != null && $("#hdDrink").val() != undefined) {
            document.getElementById("Drink").value = $("#hdDrink").val();
        }
        if ($("#hdFamilyValues") != null && $("#hdFamilyValues").val() != undefined) {
            document.getElementById("FamilyValues").value = $("#hdFamilyValues").val();
        }
        if ($("#hdRasi") != null && $("#hdRasi").val() != undefined) {
            document.getElementById("Rasi").value = $("#hdRasi").val();
        }
        if ($("#hdNakshatram") != null && $("#hdNakshatram").val() != undefined) {
            document.getElementById("Nakshatram").value = $("#hdNakshatram").val();
        }
        if ($("#hdReligion") != null && $("#hdReligion").val() != undefined) {
            document.getElementById("Religion").value = $("#hdReligion").val();
            $('#Religion').trigger('change');
        }


        if ($("#hdPMaritalStatus") != null && $("#hdPMaritalStatus").val() != undefined) {
            document.getElementById("PartnerPreference_MaritalStatus").value = $("#hdPMaritalStatus").val();
        }
        if ($("#hdPBodyType") != null && $("#hdPBodyType").val() != undefined) {
            document.getElementById("PartnerPreference_BodyType").value = $("#hdPBodyType").val();
        }
        if ($("#hdPHeightFrom") != null && $("#hdPHeightFrom").val() != undefined) {
            document.getElementById("PartnerPreference_HeightFrom").value = $("#hdPHeightFrom").val();
        }
        if ($("#hdPHeightTo") != null && $("#hdPHeightTo").val() != undefined) {
            document.getElementById("PartnerPreference_HeightTo").value = $("#hdPHeightTo").val();
        }
        if ($("#hdPComplexion") != null && $("#hdPComplexion").val() != undefined) {
            document.getElementById("PartnerPreference_Complexion").value = $("#hdPComplexion").val();
        }
        if ($("#hdPMotherTongue") != null && $("#hdPMotherTongue").val() != undefined) {
            document.getElementById("PartnerPreference_MotherTongue").value = $("#hdPMotherTongue").val();
        }
        if ($("#hdPReligion") != null && $("#hdPReligion").val() != undefined) {
            document.getElementById("PartnerPreference_Religion").value = $("#hdPReligion").val();
            $('#PartnerPreference_Religion').trigger('change');
        }
        if ($("#hdPDiet") != null && $("#hdPDiet").val() != undefined) {
            document.getElementById("PartnerPreference_Diet").value = $("#hdPDiet").val();
        }
        if ($("#hdPSmoke") != null && $("#hdPSmoke").val() != undefined) {
            document.getElementById("PartnerPreference_Smoke").value = $("#hdPSmoke").val();
        }
        if ($("#hdPDrink") != null && $("#hdPDrink").val() != undefined) {
            document.getElementById("PartnerPreference_Drink").value = $("#hdPDrink").val();
        }
     });

});

function loadDropdowns(jsonObj, dropdown) {
    $.each(jsonObj, function (key, entry) {
        dropdown.append($('<option></option>').attr('value', entry.item).text(entry.item));
    });
}