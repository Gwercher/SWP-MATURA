function validateLogin(){
    let isValidated = true;

    if(!validateEmail()) isValidated = false;
    if(!validatePassword()) isValidated = false;

    return isValidated;
}

function validateRegister(){
    let isValidated = true;

    if(!validateEmail()) isValidated = false;
    if(!validatePassword()) isValidated = false;
    if(!validatePasswordRetype()) isValidated = false;
    if(!validateBirthdate()) isValidated = false;
 
    return isValidated;
}

function validateEmail(){
    let email = document.getElementById("Email").value;
    let isValidated = true;

    if(!email) isValidated = false;
    if(!email.includes("@")) isValidated = false;

    let err = document.getElementById("EmailErr");
    if(!isValidated){
        err.innerText = "Email must contain @ (js error)";
    }
    else{
        err.innerText = "";
    }

    return isValidated;
}

function validatePassword(){
    let password = document.getElementById("Password").value;
    let isValidated = true;

    if(!password) isValidated = false;
    if(password.length <= 3) isValidated = false;

    let err = document.getElementById("PasswordErr");
    if(!isValidated){
        err.innerText = "Password is too short! (js error)";
    }
    else {
        err.innerText = "";
    }

    return isValidated;
}

function validatePasswordRetype(){
    let password = document.getElementById("Password").value;
    let passwordRetype = document.getElementById("PasswordRetype").value;
    let isValidated = true;

    if(!passwordRetype) isValidated = false;
    if(!password === passwordRetype) isValidated = false;

    let err = document.getElementById("PasswordRetypeErr");
    if(!isValidated){
        err.innerText = "Passwords are not equal! (js error)";
    }
    else {
        err.innerText = "";
    }

    return isValidated;
}

function validateBirthdate(){
    let birth = document.getElementById("Birthdate").value;
    isValidated = true;

    if(!birth) isValidated = false;

    let birthdate = new Date(birth);
    let now = new Date();
    if(birthdate >= now) isValidated = false;


    let err = document.getElementById("BirthdateErr");
    if(!isValidated){
        err.innerText = "Birthdate has to be in the past (js error)";
    }
    else {
        err.innerText = "";
    }
    return isValidated;
}