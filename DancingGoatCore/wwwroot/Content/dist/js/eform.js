$('.fn-form-text input[type="text"]').on('change', function () {
    if ($(this).val() == "") {
        $(this).parents().eq(0).removeClass('errorvalid');
    }
});
function showTitle(elm) {
    if (elm.val() == "") {
        elm.addClass("empty");
        elm.closest(".fn-form-content").addClass("errorempty");
    } else {
        elm.removeClass("empty");
        elm.closest(".fn-form-content").removeClass("errorempty");
    }
}
$(".form-select").blur(function () {
    showTitle($(this));
});
$('.form-select').on('change', function () {
    if (this.value == "") {
        $(this).addClass('empty');
    } else {
        $(this).removeClass('empty');
    }
});
new Awesomplete('.email', {
    minChars: 3,
    //autoFirst : true,
    list: ["gmail.com", "hotmail.com"],
    data: function (text, input) {
        return input + "@" + text;
    },
    filter: Awesomplete.FILTER_EMAILAUTO,
});
// Check Validate Not Mat
$(".form-control").on('blur', function () {
    // Check Format Email
    if ($(this).hasClass("email") == true) {
        var VAL = $(this).val();
        if ($(this).val() != "") {
            var email = new RegExp(/^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/);
            if (email.test(VAL)) {
                $(this).parent().removeClass('errorvalid');
                if ($(this).attr("id") == "newemail") {
                    checkConfirmEmail();
                }
            } else {
                $(this).parent().addClass('errorvalid');
                $(this).parents().eq(1).find(".fn-valid-email span").text("ให้ถูกต้อง");
            }
        } else {
            $(this).parent().removeClass('errorvalid');
            $(this).parent().addClass('errorempty');
        }
    }
});


// imask name
var nameMask = IMask(
    document.getElementById('name'),
    {
        mask: /^[ก-ฮะ-์]+$/
    });
// imask surname
var surnameMask = IMask(
    document.getElementById('surname'),
    {
        mask: /^[ก-ฮะ-์]+$/
    });
// imask email
var emailMask = IMask(
    document.getElementById('email'),
    {
        mask: /^[a-zA-Z@._0-9]+$/

    });
// imask phone number
var phoneNumberMask = IMask(
    document.getElementById('phone'),
    {
        mask: '#!0-000-0000',
        definitions: {
            // <any single char>: <same type as mask (RegExp, Function, etc.)>
            // defaults are '0', 'a', '*'
            '#': /[0]/,
            '!': /[6-9]/
        }
    });
// check length Phone Number
function textLengthPhoneNum() {
    let phoneNum = document.getElementById('phone').parentElement;
    let lengthPhoneNum = document.getElementById('phone').value.length;
    if (lengthPhoneNum == 12) {
        phoneNum.classList.remove('errorvalid');
    }

    else {
        phoneNum.classList.add('errorvalid');
    }
}

//  auto generate clear button text when focus input
Array.prototype.forEach.call(document.querySelectorAll(".fn-form-text"), function (el) {
    var input = el.querySelector("input");
    //conditionallyHideClearIcon();
    input.addEventListener("input", conditionallyHideClearIcon);
    //Click x Icon
    var checkSpanOrders = el.querySelector('[data-clear-input]');
    // alert(checkSpan);
    if (checkSpanOrders !== null) {
        checkSpanOrders.addEventListener('click', function (e) {
            input.value = '';
            conditionallyHideClearIcon();
            phoneNumberMask.updateValue();
            nameMask.updateValue();
            surnameMask.updateValue();
            emailMask.updateValue();
            $(this).parent().removeClass('errorvalid');
        });
    }

    //Input type text On change
    el.querySelector('input').addEventListener('blur', function (e) {
        var inputval = e.target.value;
        setTimeout(function () {
            e.target.nextElementSibling.style.display = 'none';
        }, 150);
        if (inputval == "") {
            e.target.parentElement.classList.add("errorempty");

        } else {
            e.target.parentElement.classList.remove("errorempty");

        }
    });

    el.querySelector('input').addEventListener('focus', function (e) {
        var inputval = e.target.value;
        if (inputval == "") {
            //e.target.parentElement.classList.add("errorempty");
            setTimeout(function () {
                e.target.nextElementSibling.style.display = 'none';
            }, 150);
        } else {
            e.target.parentElement.classList.remove("errorempty");
            setTimeout(function () {
                e.target.nextElementSibling.style.display = 'block';
            }, 150);
        }

    });

    function conditionallyHideClearIcon(e) {
        var target = (e && e.target) || input;
        target.nextElementSibling.style.display = target.value ? 'block' : 'none';
        target.value ? '' : target.parentElement.classList.remove("errorempty");
    }
});

//Textarea
Array.prototype.forEach.call(document.querySelectorAll(".fn-form-textarea"), function (el) {
    var textarea = el.querySelector("textarea");
    textarea.addEventListener('input', function (e) {
        e.target.style.height = 'auto';
        e.target.style.height = (e.target.scrollHeight) + 'px';
    });
});
$('textarea').keyup(function () {
    let characterCount = $(this).val().length,
        current = $(this).parent().find('.fn-text-count .text-current');
    current.text(characterCount);
});