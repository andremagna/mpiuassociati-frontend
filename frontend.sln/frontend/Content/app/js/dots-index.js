var introCarousel = $(".carousel");
var introCarouselIndicators = $(".carousel-indicators");
introCarousel.find(".carousel-inner").children(".carousel-item").each(function (index) {
    (index === 0) ?
        introCarouselIndicators.append("<li data-target='#introCarousel' data-slide-to='" + index + "' class='active'></li>") :
        introCarouselIndicators.append("<li data-target='#introCarousel' data-slide-to='" + index + "'></li>");

    $(this).css("background-image", "url('" + $(this).children('.carousel-background').children('img').attr('src') + "')");
    $(this).children('.carousel-background').remove();
});
