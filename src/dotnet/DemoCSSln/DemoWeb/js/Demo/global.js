/*----------------------------------------------------------------------------*/
/* File:           GLOBAL.JS                                                  */
/* Description:    JavaScript routines. Relies on jQuery 1.4.x                */
/* Author:         Carlos Adolfo Ortiz Quirós (COQ)                           */
/* Date:           Dec.07/2010                                                */
/* Last Modified:  Dec.07/2010                                                */
/* Version:        1.1                                                        */
/* Copyright (c), 2010 CSoftZ                                                 */
/*----------------------------------------------------------------------------*/

/*-----------------------------------------------------------------------------
History
Dec.07/2010 COQ  File Created. 
------------------------------------------------------------------------------*/

function jQuerySetupEnvironmentForGridPages() {
    // Used in index pages where a grid is placed.
    $('#PageSize').change(function () {
        $('#PreserveCriteria').val('1');
        $.blockUI({ message: 'Processing. Hold on a moment please..' });
        $('form').submit();
    });
    $('#SearchCriteria').change(function () {
        var element = $(this);
        $('#PreserveCriteria').val('0');
        if (element.val() == 0) {
            $('#SearchData').val('');
            $('#SearchData').attr('disabled', true);
        }
        else {
            $('#SearchData').attr('disabled', false);
        }
    });
    if ($('#SearchCriteria').val() == 0) {
        $('#SearchData').attr('disabled', true);
    } else {
        $('#SearchData').attr('disabled', false);
    }
    $("#chkAll").click(function () {
        var checked_status = this.checked;
        $("input[name=recToDel]").attr('checked', checked_status);
    });
    processingData('search');
    processingDataWithCheckboxesVerification('delRecs');
}

function jQuerySetupEnvironmentForEditPages() {
    processingData('cmd');
}

function jQuerySetupWithGreybox() {
    $('#Menu').tMenu();
    processingData('cmd');
    $("a.greybox").click(function () {
        var t = this.title || $(this).text() || this.href;
        GB_show(t, this.href, 580, 800);
        return false;
    });
}

function processingDataWithCheckboxesVerification(cmd) {
    $('#' + cmd).click(function () {

        var l = $(':checkbox[name="recToDel"]:checked').length;
        if (l > 0) {
            var val = confirm('Are you sure you want to remove the selected recors?');
            if (val) {
                $('#delRecsUsed').val('1');
                $.blockUI({ message: 'Processing. Hold on a moment please..' });
                $('form').submit();
                return true;
            } else {
                // So user decided to cancel, then all checkboxes selected must be 
                // unchecked.
                $("input[name=recToDel]").attr('checked', false);
                return false;
            }
        } else {
            // So user decided to cancel, then all checkboxes selected must be 
            // unchecked.
            $("input[name=recToDel]").attr('checked', false);
            return false;
        }
    });
}

function showMessage(msg, msgClass, delayMilSecs) {
    /* Do nothing if msg is empty. */
    if (msg != "") {
        $('#msg-box').removeClass().addClass(msgClass)
                    .html(msg)
                    .fadeIn().delay(delayMilSecs).fadeOut();
    }
}

function processingData(cmd) {
    $('#' + cmd).click(function () {
        $.blockUI({ message: 'Processing. Hold on a moment please...' });
    });
}

function jQuerySetupLightboxGallery() {
    $('#gallery a').lightBox({
        overlayBgColor: '#000',
        overlayOpacity: 0.8,
        imageLoading: '/js/jquery/plugin/lightbox/lightbox-ico-loading.gif',
        imageBtnClose: '/js/jquery/plugin/lightbox/lightbox-btn-close.gif',
        imageBtnPrev: '/js/jquery/plugin/lightbox/lightbox-btn-prev.gif',
        imageBtnNext: '/js/jquery/plugin/lightbox/lightbox-btn-next.gif',
        imageBlank: '/js/jquery/plugin/lightbox//lightbox-blank.gif',
        containerResizeSpeed: 350,
        txtImage: 'Imagen',
        txtOf: 'de'
    });
}

function setFormTooltips(formName) {
    $('#' + formName + ' :input').tooltip({

        // place tooltip on the right edge
        position: "center right",

        // a little tweaking of the position
        offset: [-2, 10],

        // use the built-in fadeIn/fadeOut effect
        effect: "fade",

        // custom opacity setting
        opacity: 1

    });
}