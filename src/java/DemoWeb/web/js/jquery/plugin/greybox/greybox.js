/* Greybox Redux
 * Required: http://jquery.com/
 * Written by: John Resig
 * Based on code by: 4mir Salihefendic (http://amix.dk)
 * License: LGPL (read more in LGPL.txt)
 * 
 * Mejorado por Tito Suarez
 * 
 */

var GB_DONE = false;
var GB_HEIGHT = 400;
var GB_WIDTH = 400;

function GB_show(caption, url, height, width, callback) {
    
    GB_HEIGHT = height || 400;
    GB_WIDTH = width || 400;
  
    if(!GB_DONE) {
    
        var strHTML = "<div id='GB_overlay'></div><div id='GB_window'><div id='GB_header'><div id='GB_caption'></div><div id='GB_close'>[ Cerrar ]</div></div><div id='GB_content'></div></div>"
        
        $(document.body).append(strHTML);
        $("#GB_close").click(function() {
            /**
             * Se implementa la funcionalidad de callback
             * @author Alvaro José Agámez Licha
             */
            GB_hide(callback);
        });
        
        $(window).resize(GB_position);
        $(window).scroll(GB_position);
        
        GB_DONE = true;
    
    }
    
    $("#GB_content").html("<iframe id='GB_frame' ></iframe>");

    $("#GB_frame").attr("src",url);
    
    $("#GB_caption").html(caption);
  
    $("#GB_overlay").show();
  
    GB_position();

    if (GB_ANIMATION) {
        $("#GB_window").slideDown("slow");
    } else {
        $("#GB_window").show();
    } 
    
}

function GB_hide(callback) {
  $("#GB_window,#GB_overlay").hide();
  $("#GB_frame").remove();
  if (typeof callback == 'function') {
      callback();
  }
}

function GB_position() {
 
    var docHeight = $(document).height();
    var docWidth = $(document).width();
    
    var winHeight;
    var winWidth;
    
    if( window.innerHeight || window.innerWidth ){
        winHeight = window.innerHeight;
        winWidth = window.innerWidth;
    }else{
        winWidth = document.documentElement.clientWidth;
        winHeight= document.documentElement.clientHeight;
    }
 
//	var winHeight = $(window).height();
//	var winWidth = $(window).width();
    var scrolTop = $(window).scrollTop();

    $("#GB_window").css({
        width: GB_WIDTH+"px",
        height: GB_HEIGHT+"px",
        left: ((winWidth - GB_WIDTH)/2)+"px",
        marginTop: ( scrolTop + 10) + "px"
    });
    
    $("#GB_frame").css("height",GB_HEIGHT - 30 +"px");
    
    $("#GB_overlay").css({
        height: docHeight + "px",
        width: docWidth + "px"
    });
  
}

function GB_showFullScreen(caption,url, callback){
    
    var winHeight = $(window).height() - 40 ;
    var winWidth = $(window).width() - 40 ;

    GB_show(caption,url,winHeight,winWidth, callback);

}