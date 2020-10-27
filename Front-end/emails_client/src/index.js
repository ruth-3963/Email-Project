import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import axios from '../node_modules/axios';

class GetAllEmails extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            listOfEmails: [],
        }
    }
    componentWillMount() {
        this.getDataAxios();
    }
    getDataAxios() {
        axios.get("https://localhost:44379/API/Email/AllEmails")
            .then((response) => {
                console.log(response.data);
                this.setState(
                    { listOfEmails: response.data }
                );
            });
    }


    render() {
        const list = this.state.listOfEmails.map((element) =>
            <EmailInList email={element} />)

        return (
            <div>{list}</div>
        );
    }
}

class EmailInList extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            email: {
                id_mail: this.props.email.id_mail,
                is_read: this.props.email.is_read,
                reciever: this.props.email.reciever,
                senter: this.props.email.senter,
                subject: this.props.email.subject,
                context: this.props.email.context,
            }
        }
    }
    render() {
        return (
            <div>
                <input type="checkbox" checked={this.state.email.is_read} />
                <span name="senter_name">{this.state.email.senter}</span>
                <span name="subject">{this.state.email.subject}</span>
                <p name="context">{this.state.email.context}</p>
            </div>
        );
    }
}
class GetAllUsers extends React.Component {
    render() {
        return (
            <button onClick={this.getDataAxios} > GetAllUsers </button>
        );
    }
    async getDataAxios() {
        const response =
            await axios.get("https://localhost:44379/API/User/AllUsers")
        console.log(response.data)
    }
}

class CreateNewEmail extends React.Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleSubmit(event) {
        axios.post('https://localhost:44379/API/Email/create',
            {
                subject: event.target.children["subject"].value,
                context: event.target.children["context"].value,
                senter: event.target.children["Senter_name"].value,
                reciever: event.target.children["Reciever_name"].value,
                is_read: false

            })
    }
    render() {
        return (
            <div>
                <p>-------------create new email-----------------------</p>
                <form onSubmit={this.handleSubmit} >
                    <label> subject </label>< input type="text" id="subject" name="subject" />
                    <label> context </label><input type="text" id="context" name="context" />
                    <label> Senter name </label><input type="text" id="Senter_name" name="Senter_name" />
                    <label> Reciever_name </label>< input id="Reciever_name" name="Reciever_name" type="text" />
                    <button > Sent email </button>
                </form >
            </div>
        );
    }
}
class CreateNewUser extends React.Component {
    constructor(props) {
        super(props);
        this.handleSubmit = this.handleSubmit.bind(this);
    }
    handleSubmit(event) {
        axios.post('https://localhost:44379/API/User/create',
            {
                user_name: event.target.children["user_name"].value,
                user_mail: event.target.children["user_mail"].value
            })
    }
    render() {
        return (
            <div>
                <p>-------------create new user-----------------------</p>
                <form onSubmit={this.handleSubmit}>
                    <label> name</label> < input type="text" id="user_name" name="user_name" />
                    <label> mail </label><input type="text" id="user_mail" name="user_mail" />
                    <button > Sent User </button>
                </form>
            </div>
        )
    }
}
let models = (
    <div >
        < GetAllUsers />
        <CreateNewUser />
        <CreateNewEmail />
        <GetAllEmails />
    </div>
);
ReactDOM.render(
    models,
    document.getElementById('root')
);