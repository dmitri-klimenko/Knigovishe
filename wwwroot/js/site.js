var ajax_suggest = '';
var suggest_timeout = 0;
var suggest_pos = -1;

function isMobile() {
    var check = false;
    (function (a) { if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino|android|ipad|playbook|silk/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) check = true; })(navigator.userAgent || navigator.vendor || window.opera);
    return check;
}


function sync(arr) {
    var ww = $(window).width();
    if (ww < 800) return;

    var max = 0;
    $(arr).each(function () {
        if ($(this).height() > max)
            max = $(this).height();
    });
    $(arr).each(function () {
        $(this).height(max);
    });
}

function syncLicense() {
    var ww = $(window).width();
    if (ww < 1000) return;
    sync($(".license_center").not(".myself"));
    sync($(".license_price").not(".myself"));
}


function showNotifications() {
    $(".notifications").show();
    $("#mobile_menu").hide();
    profileMenu = false;

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "showNotifications" },
        success: function (data) { }
    });
}

function removeNotification(el, id) {

    $(el).closest('.notification_item').remove();

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "removeNotification", "id": id },
        success: function (data) { }
    });
}


function closeNotifications() {
    $(".notifications").hide();
}



function syncNews() {
    var ww = $(window).width();
    if (ww < 800) return;

    var i = 0;
    var row = 0;

    $('.post').each(function () {

        $(this).attr('data-row', row);
        i++;
        if (i % 3 == 0) row++;
    });

    for (var r = 0; r <= row; r++) {
        sync($('.post[data-row=' + r + ']').find('.post-sync'));
    }
}


$(function () {
    resize();

    checkScroll();
    updateCountry();

    syncLicense();
    syncNews();

    $(".infoLabel").each(function () {
        $(this).on('mouseenter', function () {
            var w = $(this).closest('.license').width();
            var h = $(this).closest('.license').height();
            $(this).closest('.license').find('.infoContent').width(w - 40);
            $(this).closest('.license').find('.infoContent').height(h);
            $(this).closest('.license').find('.infoContent').show();
            $(this).hide();
        });

        $(this).closest('.license').find('.infoContent').on('mouseleave', function () {
            $(this).hide();
            $(this).closest('.license').find('.infoLabel').show();
        });


    });


    $(".cb").click(function () {
        $(this).siblings('input').trigger('click');
    });

    $(".account_username").on('mouseenter', function () {
        closeNotifications();
    });

    $(window).scroll(function () {
        checkScroll();
        $("#header").addClass("scroll");
    });

    $("#header input[name=keywords]").on('input', function () {
        if (suggest_timeout != 0) clearTimeout(suggest_timeout);
        suggest_timeout = setTimeout('suggest()', 200);
    });

	/*
	$("#header input[name=keywords]").on('blur',function(){
		$("#suggest").hide();
	});
	*/

    if ($("#register").length == 1) {
        toggleType();
    }


    if ($("select[name=school]").length == 1) {
        updateSchools();
    }


    if ($("#question").length == 1) {
        loadQuestion();
        timer();
    }

    $(".hint").wrap('<div class="qmark">');
    $(".qmark").prepend('<i class="fa fa-question"></i>');
    $(".hint").closest('.input').addClass('hint_input');

    $(".select2").select2({
        matcher: function (params, data) {
            return matchStart(params, data);
        },
        language: "bg"
    });

    $(".select2_any").select2({
        language: "bg"
    });


    $('a[name]').each(function () {
        $(this).css('position', 'relative');
        $(this).css('top', '-100px');
    });




    $(document).keydown(function (e) {

        if (!$("#suggest").is(":visible")) return;

        if (e.which == 40) {
            var sp = suggest_pos + 1;
            if ($("#suggest").find("a[data-pos=" + sp + "]").length != 1) { e.preventDefault(); return; }
            $("#suggest").find("a[data-pos=" + sp + "]").focus();
            suggest_pos = sp;
            e.preventDefault();
        }

        if (e.which == 38) {
            var sp = suggest_pos - 1;
            if ($("#suggest").find("a[data-pos=" + sp + "]").length != 1) { e.preventDefault(); return; }
            $("#suggest").find("a[data-pos=" + sp + "]").focus();
            suggest_pos = sp;
            e.preventDefault();
        }


    });
});


$(window).load(function () {
    syncLicense();
});


function deleteConfirm() {
    var answer = confirm("Сигурен ли си, че искаш да продължиш?")
    if (answer) {
        return true;
    }
    else {
        return false;
    }
}



function matchStart(params, data) {
    params.term = params.term || '';
    if (data.text.toUpperCase().indexOf(params.term.toUpperCase()) == 0) {
        return data;
    }
    return false;
}


function format(s) {
    var h = Math.floor(s / 3600); //Get whole hours
    s -= h * 3600;
    var m = Math.floor(s / 60); //Get remaining minutes
    s -= m * 60;
    return (m < 10 ? '0' + m : m) + ":" + (s < 10 ? '0' + s : s); //zero padding on minutes and seconds
}


function timer() {

    if (stopTimer) return;

    var r = (1800 - s) / 1800;
    $("#timerFill").width(1035 * r);


    $("#timer").html(format(s));
    s--;

    if (s < 0) {
        window.location = finish;
        return;
    }
    setTimeout('timer()', 1000);
}

$(window).load(function () {
    resize();
});

$(window).resize(function () {
    resize();
});


function go_to_page(p) {
    document.form.page.value = p;
    document.form.submit();
}

function check(el) {
    $(el).closest('.check').find('input').prop('checked', true);
}

function checkBox(el) {
    if ($(el).closest('.check').find('input').is(':checked'))
        $(el).closest('.check').find('input').prop('checked', false);
    else
        $(el).closest('.check').find('input').prop('checked', true);
}


function toggleType() {
    var type = $("#type").val();

    if (type == 'payer') {
        $("#register .student,#register .teacher").hide();
        $("#register .payer").show();
    }

    if (type == 'student') {
        $("#register .teacher,#register .payer").hide();
        $("#register .student").show();
    }

    if (type == 'teacher') {
        $("#register .student,#register .payer").hide();
        $("#register .teacher").show();
    }

    if (type == 'parent') {
        $("#register .student,#register .payer, #register .teacher").hide();
        $("#register .parent").show();
    }
}

function loginHeader() {

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "loginUser", "username": $("#header_username").val(), "password": $("#header_password").val() },
        success: function (data) {
            if (data.url) {
                window.location = data.url;
                return;
            }

            if (data.error) {
                $("#login_error").html(data.error);
                $("#login_error").show();
            }
        }
    });
}

function loginPayer() {
    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "loginPayer", "email": $("#header_username").val(), "password": $("#header_password").val() },
        success: function (data) {
            if (data.url) {
                window.location = data.url;
                return;
            }
            if (data.error) {
                $("#login_error").html(data.error);
                $("#login_error").show();
            }
        }
    });
}


function setWishlist(el) {
    var book = $(el).attr('data-book');

    if ($(el).hasClass('active')) {
        var txt = 'Книгата е премахната от Набелязани';
        var action = 'remove';
        $(el).removeClass('active');
    }
    else {
        var txt = 'Книгата е набелязана';
        var action = 'add';
        $(el).addClass('active');
    }

    addNotification(el, txt);
    ajaxWishlist(action, book);
}

var nt = 0;
function addNotification(el, txt) {

    $('.notification').remove();
    $(el).after('<div class="notification">' + txt + '</div>');

    clearTimeout(nt);
    nt = setTimeout(function () { $(".notification").remove(); }, 2000);
}


function ajaxWishlist(action, book) {

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "setWishlist", "do": action, "book": book },
        success: function (data) { }
    });
}

function rateOver(el) {
    var r = parseInt($(el).attr('data-rate'));

    for (i = 1; i <= r; i++) {
        $(el).closest('.rate_book').find('i[data-rate=' + i + ']').removeClass('fa-star-o').addClass('fa-star');
    }
}

function rateOut(el) {
    $(el).closest('.rate_book').find('i').removeClass('fa-star').addClass('fa-star-o');
}


function rateBook(el) {

    var rate = $(el).attr('data-rate');
    var book = $(el).closest('.rate_book').attr('data-book');

    $.ajax({
        url: ajax_url,
        type: "POST",
        data: { "action": "rateBook", "rate": rate, "book": book },
        success: function (data) {
            location.reload(true);
        }
    });

}

/*
function updateCompare(el){
	if(el.value=='me')
		$(".chartArea").removeClass('compare');
	else
		$(".chartArea").addClass('compare');
}
*/

function subscribe() {

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "subscribe", "email": $("#subscribe_email").val() },
        success: function (data) {
            if (data.error) {
                $("#subscribe_error").html(data.error).show();
                $("#subscribe_success").html("").hide();
            }
            if (data.success) {
                $("#subscribe_error").html("").hide();
                $("#subscribe_success").html(data.success).show();
            }
        }
    });
}

function updateSchools() {
    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "updateSchools", "city": $("#register select[name=city]").val() },
        success: function (data) {
            if (data.results && data.results.length > 0) {
                html = '<option value="" selected>Избери училище...</option>';
                for (i = 0; i < data.results.length; i++)
                    html += '<option value="' + data.results[i].id + '" ' + (selected_school == data.results[i].id ? 'selected' : '') + '>' + data.results[i].title + '</option>';

                $("#register select[name=school]").html(html);
            } else {
                $("#register select[name=school]").html('');
            }
        }
    });
}

function updateCountry() {

    if ($("select[name=country]").length != 1) return;

    var c = $("select[name=country]").val();

    if (c == 'България') {
        $(".bulgaria").show();
        $(".abroad").hide();
    } else {
        $(".bulgaria").hide();
        $(".abroad").show();
    }
}

function toggleInvoice() {
    if ($('input[name=invoice]').is(':checked')) {
        $('#invoice').show();
    } else {
        $('#invoice').hide();
    }
}

function suggest() {
    var keywords = $("#header input[name=keywords]").val();

    if (ajax_suggest != '')
        ajax_suggest.abort();

    ajax_suggest = $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "suggest", "keywords": keywords },
        success: function (data) {
            if (data.results && data.results.length > 0) {
                html = '';
                for (i = 0; i < data.results.length; i++)
                    html += '<a href="' + data.results[i].url + '" data-pos="' + i + '">' + data.results[i].title + '</a>';
                $("#suggest").html(html);
                $("#suggest").show();
            } else {
                $("#suggest").hide();
            }
        }
    });
}

function shuffle(array) {
    for (var i = array.length - 1; i > 0; i--) {
        var j = Math.floor(Math.random() * (i + 1));
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

function loadQuestion() {

    var html = "";

    if (questions.length > 5) {
        if (q == 4) html += '<div style="color:#43925a;font-size:20px;font-weight:bold;margin-bottom:10px;">Много добре! Стигна до 5. въпрос.</div>';
        if (q == 10 && questions.length > 13) html += '<div style="color:#43925a;font-size:20px;font-weight:bold;margin-bottom:10px;">Продължавай! Остават само още 5 въпроса!</div>';
    }

    html += '<div class="questionTitle">' + questions[q]['title'] + '</div><div class="options" style="display:inline-block;position:relative;margin-top:5px;">';

    $(".dot").removeClass('active');
    for (i = 1; i <= q + 1; i++) {
        $(".dot" + i).addClass('active');
    }


    $(".quiz_popup").removeClass("correct");
    $(".quiz_popup").removeClass("wrong");
    $(".say").remove();

    if (questions[q]['type'] == 2) {
        stopTimer = true;
        html += '<textarea id="text" style="width:600px;height:200px;"></textarea><br>';
    } else {

        var nums = [1, 2, 3];
        shuffle(nums);

        for (i = 0; i < nums.length; i++)
            html += '<div class="quizAnswer" data-value="' + nums[i] + '" onclick="selectAnswer(this)">' + questions[q]['answer' + nums[i]] + '</div>';

    }

    html += '</div><div style="margin-top:30px;margin-bottom:40px;">';
    html += '<a href="javascript:answer()" class="button next disabled confirm_button" style="float:left;">ПОТВЪРДИ</a>';
    html += '<a href="javascript:loadQuestion();"  class="button continue" style="float:left;display:none;">СЛЕДВАЩ ВЪПРОС</a>';
    html += '<a href="javascript:skip()" class="button next" style="float:right;">ПРОПУСНИ</a>';
    html += '</div>';


    html += '</div><div style="color:red;" id="error"></div>';

    $("#question").html(html);
}

function skip() {
    $(".quizAnswer").removeClass('active');
    $(".confirm_button").removeClass('disabled');
    answer();
}


function selectAnswer(el) {

    if ($(el).hasClass("disabled")) return;
    $(el).siblings(".quizAnswer").removeClass('active');
    $(el).addClass('active');
    $(".confirm_button").removeClass('disabled');
}

function answer() {

    if ($(".confirm_button").hasClass('disabled')) return;
    $(".confirm_button").addClass('disabled');

    var answer = $(".quizAnswer.active").attr('data-value');
    if (answer != 1 && answer != 2 && answer != 3) answer = 0;

    $(".quizAnswer").addClass("disabled");
    $("#error").hide();

    if (answer == 1) {
        shuffle(texts_correct);
        $(".quiz_popup").addClass('correct');
        $("#dots").append('<div class="say correct">' + texts_correct[0] + '</div>');
        points += k;
    } else {
        if (answer != 0) {
            $(".quiz_popup").addClass('wrong');
            shuffle(texts_wrong);
            $(".quizAnswer[data-value=" + answer + "]").addClass("quizWrong");

            $("#dots").append('<div class="say wrong">' + texts_wrong[0] + '</div>');
            points -= (k / 2);
        }
    }


    display_points = Math.ceil(points);
    if (display_points < 0) display_points = 0;
    $("#counter").html(display_points);


    if (answer != 0) {
        $(".quizAnswer[data-value=1]").addClass("quizCorrect");
    }


    //console.log({"action": "answer", "qa": qa, "q": q,"answer": answer});

    $.ajax({
        url: ajax_url,
        type: "POST",
        timeout: 4000,
        dataType: "json",
        data: { "action": "answer", "qa": qa, "q": q, "answer": answer },
        success: function (data) {

            console.log(q);
            console.log(data);

            if (data.url) {
                window.location = data.url;
                return;
            }

            q++;

            if (answer == 0) {
                loadQuestion();
            } else {
                $("#question .next").hide();
                $("#question .continue").show();
            }
        }, error: function (XMLHttpRequest, textStatus, errorThrown) {

            $(".quiz_popup").removeClass("correct");
            $(".quiz_popup").removeClass("wrong");
            $(".say").remove();
            $(".questionWrap").html('<div style="font-size:20px;font-weight:bold;">Възникна проблем във връзката със сървъра. Моля, провери дали твоята интернет връзка работи и презареди страницата или натисни <a href="javascript:location.reload();">тук.</a></div>');

        }
    });



}


function sendReport() {

    var txt = $("#report textarea").val();
    var id = $("#report").attr('data-id');

    if (txt == '') return;

    $("#report").html('Благодарим ти за съобщението!');

    $.ajax({
        url: ajax_url,
        type: "POST",
        dataType: "json",
        data: { "action": "report", "text": txt, "quiz_id": id, "q": q },
        success: function (data) { }
    });
}



// Accordian Action
var action = 'click';
var speed = "500";

$(document).ready(function () {
    $('#faq li:even').addClass('q').prepend('<i class="fa fa-arrow-down"></i>&nbsp;');
    $('#faq li:odd').addClass('a');


    $('#faq li.q').on(action, function () {
        var answer = $(this).next();
        $(answer).slideToggle(speed)
        $('#faq li.a').not(answer).slideUp();

        //$('#faq li.q i').removeClass('fa-arrow-down');
        //$(this).find('i').addClass('fa-arrow-up');
    });

    $("#login input").each(function () {
        $(this).on('keyup', function (e) {
            var code = e.which;
            if (code == 13)
                loginHeader();
        });
    });


    /*
    if($(".chartArea").length==1){
      $("#chartSelect option[value='all']").prop("selected",true);  
    }
    */

    if (isMobile()) {
        $("body").addClass("mobile");
    }
});


var profileMenu = false;

function toggleProfileMenu() {

    closeNotifications();


    if (profileMenu) {
        $("#mobile_menu").hide();
        profileMenu = false;
    }
    else {
        $("#mobile_menu").show();
        profileMenu = true;
    }
}




function checkScroll() {
    var st = $(window).scrollTop();
    if (st > 0) $("body").addClass("scroll");
    //else $("body").removeClass("scroll");
}

function resize() {
    var ww = $(window).width();
    var wh = $(window).height();

    var header_height = $("#header").outerHeight();
    var footer_height = $("#footer").outerHeight() + $("#newsletter").outerHeight() + $("#copy").outerHeight();

    $("#content").css("min-height", (wh - header_height - footer_height) + "px");
}



function toggle(el) {
    var id = $(el).attr('data-id');
    if ($("#" + id).is(":visible")) {
        $("#" + id).hide();
    } else {
        if (id == 'search' || id == 'login') $("body").addClass("scroll");
        $("#" + id).show();
    }
}


function toggleSearch(el) {
    $(el).remove();
    $("#header").append($("#search_input"));
    $("#search_input").removeClass('invisible-mobile').show();
    $("#search_input input[type=text]").focus();
}


// +
function licensePopup(el) {
    $(el).closest('.license').find('.vote_shadow').show();
}
