
$(document).ready(function () {
    $('.thumbnails img').on('click', function () {
        var thumbImg = $(this).attr('src');
        $('.productimg').attr('src', thumbImg);
        $('.thumbnails img').removeClass('active');
        $(this).addClass('active');
    });
    // ajax post for the add to cart
    //bind an event to the form
    $('.cartform').on('submit', fuction())
        // do the ajax post
        // make sure (convert to a string)the
        //
        $.post('/Cart/Add/', $(this).serialize(), function(data) {
            $('minicart').html(data)
        });
    });
    //$('.imageView .imageTabs img').on('click', function () {

    //when the image is clicked
    //do this
    //set a variable to the src value

   

    //change the attr: src to the value url

