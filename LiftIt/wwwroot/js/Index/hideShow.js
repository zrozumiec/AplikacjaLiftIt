function showLogin() {
    document.getElementById('login').style.display = 'block';
    document.getElementById('opisHero').style.display = 'none';
    document.getElementById('register').style.display = 'none';
}

function showRegister() {
    document.getElementById('register').style.display = 'block';
    document.getElementById('opisHero').style.display = 'none';
    document.getElementById('login').style.display = 'none';
}

function hideLogin() {
    document.getElementById('login').style.display = 'none';
    document.getElementById('opisHero').style.display = 'block';
}

function hideRegister() {
    document.getElementById('register').style.display = 'none';
    document.getElementById('opisHero').style.display = 'block';
}
