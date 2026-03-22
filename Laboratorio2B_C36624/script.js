var fondoCambiado = false; //Estado del Fondo

//Funciones

//Agrega un nuevo elemento a la lista con el texto "Elemento" seguido del número de elementos actuales + 1
function agregar() {
    var lista = document.getElementById("lista");
    var totalElementos = lista.getElementsByTagName("li").length;
    var nuevoElemento = document.createElement("li");
    nuevoElemento.innerHTML = "Elemento" + (totalElementos + 1);
    lista.appendChild(nuevoElemento);
}

//Cambia el fondo de la página entre blanco y azul cada vez que se llama a la función
function cambiarFondo() {
    if (fondoCambiado) { //Si el fondo es azul, lo cambia a blanco
        document.body.style.backgroundColor = "white";
        fondoCambiado = false;
    } else {
        document.body.style.backgroundColor = "blue"; //Si el fondo es blanco, lo cambia a azul
        fondoCambiado = true;
    }
}

// Elimina el último elemento de la lista si hay al menos un elemento 
function borrar() {
    var lista = document.getElementById("lista");
    var elementos = lista.getElementsByTagName("li");
    if (elementos.length > 0) {
        lista.removeChild(elementos[elementos.length - 1]);
    }
}