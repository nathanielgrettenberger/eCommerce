
$(document).ready(function () {
    $('.thumbnails img').on('click', function () {
        var thumbImg = $(this).attr('src');
        $('.productimg').attr('src', thumbImg);
        $('.thumbnails img').removeClass('active');
        $(this).addClass('active');
    });
});
//$('.imageView .imageTabs img').on('click', function () {

//when the image is clicked
    //do this
    //set a variable to the src value

   

    //change the attr: src to the value url

 