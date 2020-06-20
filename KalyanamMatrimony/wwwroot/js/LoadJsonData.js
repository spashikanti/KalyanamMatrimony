$(document).ready(function () {
    debugger;
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

    $("#Religion").on("change", function () {
        var religion = "";
        $("#Religion option:selected").each(function () {
            religion = $(this).text();
        });

        $.getJSON('../data/masterData.json', function (jd) {
            $.each(jd.Religion, function (key, entry) {
                debugger;
                console.log(key, entry);
                if (entry.item == religion) {

                    ddlCaste.empty();
                    ddlCaste.append('<option disabled>Choose Caste</option>');
                    ddlCaste.prop('selectedIndex', 0);

                    loadDropdowns(entry.Caste, ddlCaste);
                }
            });
        });

    });

    $.getJSON('../../data/masterData.json', function (jd) {
        loadDropdowns(jd.MaritalStatus, ddlMaritalStatus);
        loadDropdowns(jd.BodyType, ddlBodyType);
        loadDropdowns(jd.Height, ddlHeight);
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
     });

});

function loadDropdowns(jsonObj, dropdown) {
    $.each(jsonObj, function (key, entry) {
        dropdown.append($('<option></option>').attr('value', entry.item).text(entry.item));
    });
}