window.onload = () => {
    const xml = new XMLHttpRequest();

    xml.open("GET", "http://localhost:5003/api/getAllRoles");
    xml.send();
    xml.onload = function() {
        let options = JSON.parse(this.responseText);
        let select = document.getElementById("AllRolesSelect");
        
        for(let i = 0; i < options.length; i++){
            let opt = new Option();
            opt.text = options[i];
            opt.value = i;
            select.appendChild(opt);
        }
    }
}