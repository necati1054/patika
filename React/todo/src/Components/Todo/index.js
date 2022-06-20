import { useState } from 'react'
import Form from 'react-bootstrap/Form';

function Todo({ addNot, not }) {
  const [todoText, setTodoText] = useState({ text: "", done: false, id: 4 })

  const onSubmit = (e) => {
    e.preventDefault();

    if (todoText.text === "") {
      return false
    }

    setTodoText({ text: todoText.text, done: todoText.done, id: todoText.id + 1 })
    addNot([...not, todoText]);
  }

  const doneTrue = (i) => {
    addNot(not.map((item) => {
      item.done = i
      return item;
    }))
  };

  return (
    <form onSubmit={onSubmit}>
        <Form.Group className="mb-3 d-flex flex-wrap" controlId="formBasicEmail"  >
          <Form.Check type="checkbox" className="w-auto" onChange={(e)=>doneTrue(e.target.checked)} />
          <Form.Control className="ms-1 w-auto" placeholder='What needs to be done?' onChange={(e)=>setTodoText({...todoText,text:e.target.value})} value={todoText.text}  />
        </Form.Group>
    </form>
  )
}

export default Todo