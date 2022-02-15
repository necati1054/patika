let list = document.querySelector('#list')
let sill = document.querySelector('#clear')
let yapilacakk = document.querySelector('#task')
let yazii = yapilacakk.value;

const liste = (yazii,index) =>`
    <li id="${index}" onclick="ciz(${index})">${yazii}<button class="sil float-right" onclick="indexsil(${index})">x</button></li>
`
let listtoplam;
function localoku(){
    listtoplam = localStorage.getItem('Not') ? JSON.parse(localStorage.getItem('Not')) : [];
}

function newElement(){
    let yapilacak = document.querySelector('#task')
    if(yapilacak.value==0){
        $("#liveToastt").toast("show")
        // alert("lütfen boş değer girmeyiniz")
    }
    else{
        $("#liveToast").toast("show")
        let yazı = yapilacak.value
        yapilacak.value = "";
        // let Lidom = document.createElement('li')
        // Lidom.innerHTML=`${yazı}`      
        // list.append(Lidom)
        list.innerHTML+=liste(yazı)
        listtoplam.push(yazı)
        localStorage.setItem('Not',JSON.stringify(listtoplam))
    }

}

function oku(){
    localoku();
    list.innerHTML="";
    listtoplam.forEach((element,value) => {
        // let ekle = document.createElement('li')
        // ekle.innerHTML=element
        // list.append(ekle)
        list.innerHTML+=liste(element,value)
    });
}

sill.addEventListener('click',fulsil)

function fulsil(){
    listtoplam="";
    localStorage.removeItem("Not")
    list.innerHTML = ""
    localoku();
}


function indexsil(index){
    let getLocalStorage = localStorage.getItem("Not");
    let a = JSON.parse(getLocalStorage);
    a.splice(index, 1);
    localStorage.setItem("Not", JSON.stringify(a));
    oku();
}

function ciz(index){
    let a = document.getElementById(index)
    a.style.textDecoration="line-through"
    a.style.backgroundColor="red"
}
