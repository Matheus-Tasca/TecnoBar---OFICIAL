document.addEventListener('DOMContentLoaded', function () {
    const owlCarousel = document.querySelector('.owl-carousel');

    if (owlCarousel) { // Verifica si se encontró un elemento con la clase "owl-carousel"
        // Configura el carrusel utilizando el método Owl Carousel
        const owl = $(owlCarousel);
        owl.owlCarousel({
            loop: true,
            margin: 10,
            nav: true,
            responsive: {
                0: {
                    items: 1
                }
            }
        });
    }
    
    
});
