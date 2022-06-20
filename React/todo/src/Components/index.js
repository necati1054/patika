import {useState} from "react";
import Todo from "./Todo";
import List from "./list";
import "../App.css"

function Not() {
  const [not,setNot] = useState([
    {
      text:"Todo Yapılacak",
      done:false,
      id:1
    },
    {
      text:"react uygulaması klonlanacak",
      done:false,
      id:2
    },
    {
      text:"dosyaları düzenlencek",
      done:false,
      id:3
    },
  ]);

  return (
    <div>
      <h1 className="ms-5" >TODO</h1>
      <Todo addNot={setNot} not={not}/>
      <List filterNot={setNot} not={not}/>
    </div>
  );
}

export default Not;