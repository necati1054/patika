const getButton=document.querySelector("button");
getButton.addEventListener("click",function(){
const divEl=document.querySelector("div");
const yas =document.querySelector("input[name='yas']").value; 
 let result=2022-yas; 
 divEl.innerHTML= `Yaşınız ${result}`; 
  
//input sadece number olmalı string olmamalı bunu sağlayan kodu ifin içerisine yazınız yazınız
 if(isNaN(yas)){
    divEl.innerHTML= `Sadece Sayı Giriniz`;
 }
  
  
if(result<0){
  divEl.innerHTML= `Yaşınız - sayı olamaz`;
}
  if(result>110){
    divEl.innerHTML= `Ölmüş olmalıydınız`;
   
  }

});