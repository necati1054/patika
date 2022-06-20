import { useState } from 'react'

function List({ not, filterNot }) {
    const [filter, setFilter] = useState("all");

    const filtered = not.filter((item) => {
        if (filter === "all") {
            return item;
        }
        else if (filter === "active" && item.done === false) {
            return item
        }
        else if (filter === "complated" && item.done === true) {
            return item
        }
        return null;
    });

    const doneFilter = (i) => {
        filterNot(not.map((item) => {
            if (item.id === i) {
                item.done = !item.done;
            }
            return item;
        }))
    };

    const textFilter = (i, yazi) => {
        filterNot(not.map((item) => {
            if (item.id === i) {
                item.text = yazi;
            }
            return item;
        }))
    };

    const deleteNot = (i) => {
        filterNot((p) => p.filter((item) => item.id !== i));
    }

    const allDelete = () => {
        filterNot([]);
    }

    return (
        <>
            <ul style={{padding:0}}>
                {
                    filter === "all" ? filtered.map((notcuk) => (
                        <li typeof='Item' key={notcuk.id}>
                            <div>
                                <input property='done' type="checkbox" checked={notcuk.done} onChange={() => doneFilter(notcuk.id)} />
                                <label property='text'>
                                    <input className='mb-2 ms-1 form-control form-control-lg' placeholder="(text)" defaultValue={notcuk.text} onChange={(e) => textFilter(notcuk.id, e.target.value)} />
                                </label>
                                <button className='ms-2 btn btn-outline-danger' onClick={() => deleteNot(notcuk.id)} >x</button>
                            </div>
                        </li>
                    )) : null
                }{
                    filter === "active" ? filtered.map((notcuk) => (
                        <li typeof='Item' key={notcuk.id}>
                            <div>
                                <input property='done' type="checkbox" checked={notcuk.done} onChange={() => doneFilter(notcuk.id)} />
                                <label property='text'>
                                    <input className='mb-2 ms-1 form-control form-control-lg' placeholder="(text)" defaultValue={notcuk.text} onChange={(e) => textFilter(notcuk.id, e.target.value)} />
                                </label>
                                <button className='ms-2 btn btn-outline-danger' onClick={() => deleteNot(notcuk.id)} >x</button>
                            </div>
                        </li>
                    )) : null
                }{
                    filter === "complated" ? filtered.map((notcuk) => (
                        <li typeof='Item' key={notcuk.id}>
                            <div>
                                <input property='done' type="checkbox" checked={notcuk.done} onChange={() => doneFilter(notcuk.id)} />
                                <label property='text'>
                                    <input className='mb-2 ms-1 form-control form-control-lg' placeholder="(text)" defaultValue={notcuk.text} onChange={(e) => textFilter(notcuk.id, e.target.value)} />
                                </label>
                                <button className='ms-2 btn btn-outline-danger' onClick={() => deleteNot(notcuk.id)} >x</button>
                            </div>
                        </li>
                    )) : null
                }
            </ul>
            <footer>
                <span>
                    <strong>{not.length}</strong> items left
                </span>
                <ul className='pt-2 d-flex' style={{padding:0}}>
                    <li><button className='btn btn-success ms-1' onClick={() => setFilter("all")}>All</button></li>
                    <li><button className='btn btn-success ms-1' onClick={() => setFilter("active")}>Active</button></li>
                    <li><button className='btn btn-success ms-1' onClick={() => setFilter("complated")}>Complated</button></li>
                    <li><button className='btn btn-danger ms-1' onClick={allDelete}>all Delete</button></li>
                </ul>
            </footer>
        </>
    )
}

export default List