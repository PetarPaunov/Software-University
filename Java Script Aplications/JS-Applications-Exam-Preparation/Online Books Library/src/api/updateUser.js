export function updateUserNav(){
    const userData = JSON.parse(localStorage.getItem('user'));
    if(userData){
        document.getElementById('user').style.display = 'block';
        document.getElementById('guest').style.display = 'none';
        document.getElementById('welcome').textContent = `Welcome, ${userData.email}`;
    }else{
        document.getElementById('guest').style.display = 'block';
        document.getElementById('user').style.display = 'none';
    }
}


