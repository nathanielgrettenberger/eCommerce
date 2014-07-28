
//when the image is clicked

$('.imageView .imageTabs img').on('click', function () {

    //do this
    //set a variable to the src value

    var url = $(this).attr('src');

    //change the attr: src to the value url

    $('.imageView .mainImage img').attr('src', url)});