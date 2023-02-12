"use strict"
window.JGGrid = {
    init(){
        console.log("JGGrid Init")
    },
    
    setupDragAndDrop() {
        console.log("drag and drop");
        const rows = document.querySelectorAll('table tbody tr');
    
        rows.forEach(row => {
            row.addEventListener('dragstart', e => {
                const rowData = JSON.stringify({
                    id: row.cells[0].textContent,
                    name: row.cells[1].textContent,
                    value: row.cells[2].textContent
                });
    
                e.dataTransfer.setData('text/plain', rowData);
            });
        });
    
        document.addEventListener('dragover', e => {
            e.preventDefault();
        });
    
        document.addEventListener('drop', e => {
            e.preventDefault();
    
            const targetRow = e.target.closest('tr');
    
            if (targetRow) {
                const targetRowIndex = Array.from(targetRow.parentNode.children).indexOf(targetRow);
    
                const rowData = JSON.parse(e.dataTransfer.getData('text/plain'));
    
                const sourceRowIndex = Array.from(rows).findIndex(row => row.cells[0].textContent === rowData.id);
    
                const tableBody = targetRow.parentNode;
    
                tableBody.insertBefore(rows[sourceRowIndex], tableBody.children[targetRowIndex]);
            }
        });
    }
}