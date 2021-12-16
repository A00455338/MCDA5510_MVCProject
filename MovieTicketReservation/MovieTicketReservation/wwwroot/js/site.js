// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function checkLogin() {
    var currentDate = new Date();
    var sessionObject = JSON.parse(sessionStorage.getItem('sessionObject'));
    var expirationDate = sessionObject ? sessionObject.expiresAt : 1639670826000;
    if (Date.parse(currentDate) < Date.parse(expirationDate)) {
        $("#mainlogin").hide();
        $("#profile").show();
    } else {
        //redirect users to login page or whatever logic you have in your app 
        //and remove the sessionStorage because it will be set again by previous logic
        sessionStorage.removeItem('sessionObject');
        console.log('session expired');
        $("#mainlogin").show();
        $("#profile").hide();
    }
}

function logout() {
    sessionStorage.removeItem("sessionObject");
    $("#mainlogin").show();
    $("#profile").hide();
}