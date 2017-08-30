import React, { Component } from 'react';


function SendData() {
    fetch('http://localhost:52307/api/Person', {
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            id: 0,
            name: document.getElementById("Name").value,
            age: parseInt(document.getElementById("Age").value,10)
        })
    });
}

class AddPerson extends Component {

    render() {
        return (
            <div>
                <div>
                    <input type="text" id="Name" />
                </div>
                <div>
                    <input type="number" id="Age"/>
                </div>
                <button className="btn-action" onClick={SendData}>Add person</button>
            </div>
        );
    }
}

export default AddPerson;