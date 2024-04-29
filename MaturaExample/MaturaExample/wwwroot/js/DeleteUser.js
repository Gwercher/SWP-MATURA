function DeleteUser(e){
    const xml = new XMLHttpRequest();

    xml.open("POST", "http://localhost:5003/api/deleteUser?Email="+e, true);
    xml.send();
    xml.onload = function() {
        let select = document.getElementById("AllRolesSelect");
        getUserByRole(select.value);
    }
}