"use strict"
window.JGCard = {

    init(){
        console.log("Init Card")
        window.addEventListener("DOMContentLoaded", () => {
            const element = document.getElementById("Card1")
            element.addEventListener("dragstart", this.dragStart_handler);
        })
    },
    dragStart_handler(ev) {
        ev.dataTransfer.setData("text/plain", ev.target.id);
    }
}


