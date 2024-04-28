var RoleEnum = new Object();

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
            RoleEnum[i] = options[i];
        }
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
            console.log(u.birthdate.split("-"));
            let splitDate = u.birthdate.split("-");
            let dateFormat = splitDate[1].replace("0", "") + "/" + splitDate[2].slice(0, 2).replace("0", "") + "/" + splitDate[0];//parseInt(u.birthdate.getMonth()) + 1; 
            body += "<tr>";
            body += "<td>"+ u.email +"</td>";
            body += "<td>"+ dateFormat +"</td>";
            body += "<td>"+ RoleEnum[u.role] +"</td>";
            body += "<form action='/user/ChangeUser' method='post'>"
            body += "<td><form action='/user/changeUser' methode?'post'> <input type='hidden' value='"+ u.email +"' name='Email'> <input type='submit' value='Change Data'></td>";
            body += "</form>"
            body += "<td><button onclick='DeleteUser(this.value)' value='"+ u.email+"'>Delete</button></td>";
            body += "</tr>";
        }
        tbody.innerHTML = body;
    }
}