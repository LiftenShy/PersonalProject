import React, { Component } from 'react';

function Delete() {
    fetch('http://localhost:52307/api/Person/' + JSON.stringify(id), {
        method: 'delete',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json',
        }
    });
}

class DeletePerson extends Component {
    render() {
        return (
            <button className="btn-action" onClick={Delete(persone.id)}>Delete</button>
        );
    }
}

export default DeletePerson;