(function () {
    "use strict";

    /**
     * Header scroll efekti (sayfa aşağı kaydırıldığında body'ye .scrolled ekler)
     */
    function toggleScrolled() {
        const body = document.querySelector('body');
        const header = document.querySelector('.header');
        if (!header) return;
        window.scrollY > 100
            ? body.classList.add('scrolled')
            : body.classList.remove('scrolled');
    }

    document.addEventListener('scroll', toggleScrolled);
    window.addEventListener('load', toggleScrolled);

    /**
     * AOS animasyon başlatma
     */
    function aosInit() {
        if (typeof AOS !== "undefined") {
            AOS.init({
                duration: 600,
                easing: 'ease-in-out',
                once: true,
                mirror: false
            });
        }
    }
    window.addEventListener('load', aosInit);

    /**
     * Glightbox başlatma
     */
    if (typeof GLightbox !== "undefined") {
        GLightbox({
            selector: '.glightbox'
        });
    }

})();
