window.onload = () => {
    const xml = new XMLHttpRequest();

    xml.open("GET", "http://localhost:5003/api/getAllRoles");
    xml.send();
    xml.onload = function() {
        let roles = JSON.parse(this.responseText);
        let select = document.getElementById("AllRolesSelect");
        
        let option = "<option value='-1'>All</option>";
        for(let i = 0; i < roles.length; i++){
            option += "<option value='" + i + "'>"+ roles[i] +"</option>";
        }
        select.innerHTML = option;
    }
}