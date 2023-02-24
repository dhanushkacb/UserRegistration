
document.addEventListener('DOMContentLoaded', () => {

});

async function loadData() {
    fetch('https://localhost:7119/api/User')
        .then(respose => respose.json())
        .then(data => {
            console.log(data);
        }).catch(error => {
            console.log('Error: ', error);
        });
}


loadData();