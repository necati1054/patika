let counter = localStorage.getItem('counter') ? Number(localStorage.getItem('counter')) : 0;
let namee = document.querySelector('#Name')
let counterDOM = document.querySelector('#counter')
let increaseDOM = document.querySelector('#increase')
let decreaseDOM = document.querySelector('#decrease')
let Rname = document.querySelector('#Rname')
let sill = document.querySelector('#sill')

function why(){
    let Nname=prompt('isminiz-soyisminiz')
    localStorage.setItem('FulName',Nname)
    return Nname;
}

namee.innerHTML = localStorage.getItem('FulName') ? localStorage.getItem('FulName') : why();

counterDOM.innerHTML = counter

increaseDOM.addEventListener("click", clickEvent)
decreaseDOM.addEventListener("click", clickEvent)

function clickEvent() {
    this.id == "increase" ?  counter += 1 : counter -= 1
    localStorage.setItem('counter',counter)
    counterDOM.innerHTML = counter
}

Rname.addEventListener('click',sil)

function sil(){
    localStorage.removeItem('FulName')
}

sill.addEventListener('click', counterremove)

function counterremove(){
    localStorage.setItem('counter',0)
    counterDOM.innerHTML = 0
}
