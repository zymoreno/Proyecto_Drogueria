const movPag = document.querySelector(".movPag");
const btn_adelante2 = document.querySelector(".sigPag");

const btn_atras1 = document.querySelector(".volver-pagina-1");   
const btn_adelante3 = document.querySelector("adelante-pagina-3");   
const btn_atras2 = document.querySelector(".volver-pagina-2");   
const btn_adelante4 = document.querySelector(".adelante-pagina-4");   
const btn_atras3 = document.querySelector(".volver-pagina-3");   
const btn_final = document.querySelector(".fin");   

btn_adelante2.addEventListener("click", function(e) {
 e.preventDefault();
 movPag.style.marginLeft = "-25%;"
});

btn_adelante3.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-25%;"
   });

   btn_adelante4.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-25%;"
   });
   
   btn_final.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-25%;"
    alert ("Aqui finaliza el registro.");
   });

   btn_atras1.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-0%;"
    });

   btn_atras2.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-25%;"
    alert ("Aqui finaliza el registro.");
   });

   btn_atras3.addEventListener("click", function(e) {
    e.preventDefault();
    movPag.style.marginLeft = "-50%;"
    alert ("Aqui finaliza el registro.");
   });

  