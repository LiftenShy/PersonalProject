import React, { Component } from 'react';
import Add from './Add';
import Delete from './Delete';

class App extends Component {

    state = {
        persons: null
    };

    componentDidMount() {
        const url = 'http://localhost:52350/api/Person';
        fetch(url)
            .then(function (response) {
                return response.json();
            })
            .then(persons => {
                this.setState({
                    persons: persons
                })

            });
    }

    render() {
        return (
            <div>
                <table>
                    <thead>
                    <tr>
                        <th>Name</th>
                        <th>Age</th>
                    </tr>
                    </thead>
                    <tbody>
                    {this.state.persons ?
                        this.state.persons.map(person => {
                            return (
                                <tr key={person.id}>
                                    <td>{person.name}</td>
                                    <td>{person.age}</td>
                                    <Delete />
                                </tr>);
                        }) : <tr>
                            <td>Loading...</td>
                        </tr>
                    }
                    </tbody>
                </table>
                <Add />
            </div>
        );
    }
}

export default App;


