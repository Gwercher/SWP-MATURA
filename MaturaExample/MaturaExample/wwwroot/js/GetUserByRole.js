var RoleEnum = new Object();

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
            RoleEnum[i] = roles[i];
        }
        select.innerHTML = option;
    }
}

function getUserByRole(e) {
    const xml = new XMLHttpRequest();

    if(e == -1){
        xml.open("POST", "http://localhost:5003/api/getAllUsers");
    }else {
        xml.open("POST", "http://localhost:5003/api/getUserByRole?Role="+e);
    }
    xml.send();
    xml.onload = function() {
        let users = JSON.parse(this.responseText);
        let tbody = document.getElementById("AllUsersTableBody");

        let body = "";
        for (let i = 0; i < users.length; i++) {
            let u = users[i];
            let splitDate = u.birthdate.split("-");
            let dateFormat = splitDate[1].replace("0", "") + "/" + splitDate[2].slice(0, 2).replace("0", "") + "/" + splitDate[0];
            body += "<tr>";
            body += "<td>"+ u.email +"</td>";
            body += "<td>"+ dateFormat +"</td>";
            body += "<td>"+ RoleEnum[u.role] +"</td>";
            body += "<td><form action='/user/changeUser' method='post'> <input type='hidden' value='"+ u.email +"' name='Email'> <input type='submit' value='Change Data'></form></td>";
            body += "<td><button onclick='DeleteUser(this.value)' value='"+ u.email+"'>Delete</button></td>";
            body += "</tr>";
        }
        tbody.innerHTML = body;
    }
}