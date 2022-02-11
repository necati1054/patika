const myName = document.querySelector("#myName")
const Clock = document.querySelector("#myClock")
const günler = ["pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar"]
let Name = prompt("Lütfen isminizi giriniz", "guest");
if (Name.length > 0) {
    myName.innerHTML = Name;
}

function zaman(){
    let tarih = new Date();
    let gün = tarih.getDay();
    let saat = tarih.getHours();
    let dakika = tarih.getMinutes();
    let saniye = tarih.getSeconds();
    let anlık = saat + ":" + dakika + ":" + saniye + " " + günler[gün-1];
    return anlık;
}

function showTime(){
    Clock.innerHTML=zaman();    
    setTimeout(showTime,1000);
}


