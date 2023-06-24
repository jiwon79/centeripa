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