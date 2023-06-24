// show animation
const startAnimation = (entries, observer) => {
    entries.forEach(entry => {
        if(entry.isIntersecting) {
            entry.target.classList.add("slide-in-from-right");
            observer.unobserve(entry.target);
        }
    });
};
  
const observer = new IntersectionObserver(startAnimation);
const options = { root: null, rootMargin: '0px', threshold: 1 }; 
  
const elements = document.querySelectorAll('.appear-left');
elements.forEach(el => {
    observer.observe(el, options);
});

// scroll transform animation
const scrollElements = document.querySelectorAll('.scroll-transform');

let ticking = false;

const transformByScroll = () => {
    scrollElements.forEach(el => {
        const rect = el.getBoundingClientRect();
        const elemTop = rect.top;
        const elemBottom = rect.bottom;
        const isVisible = (elemTop >= 0 && elemTop <= window.innerHeight) || (elemBottom >= 0 && elemBottom <= window.innerHeight);

        if(isVisible) {
            let distanceFromTop = (window.innerHeight - elemTop) / 10;
            el.style.transform = `translateX(${distanceFromTop}px)`;
        }
    });
}
transformByScroll();

window.addEventListener('scroll', function(e) {
    if (!ticking) {
        window.requestAnimationFrame(function() {
            transformByScroll();
            ticking = false;
        });

        ticking = true;
    }
});