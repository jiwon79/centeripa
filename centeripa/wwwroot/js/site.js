// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const startAnimation = (entries, observer) => {
    entries.forEach(entry => {
      entry.target.classList.toggle("slide-in-from-right", entry.isIntersecting);
    });
  };
  
const observer = new IntersectionObserver(startAnimation);
const options = { root: null, rootMargin: '0px', threshold: 1 }; 
  
const elements = document.querySelectorAll('.appear-left');
elements.forEach(el => {
    observer.observe(el, options);
});