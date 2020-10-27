import User from './User.js';
class Email {

    constructor(user_senter, user_reciever, subject, context) {
        this.user_reciever = user_reciever;
        this.user_senter = user_senter;
        this.subject = subject;
        this.context = context;
    }

}
export { Email }