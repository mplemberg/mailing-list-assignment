import { Message } from 'semantic-ui-react';

const ContactFormMessage = ({errorMessage, successMessage}) => {
    const isNegative = errorMessage.length > 0;
    const isPositive = successMessage.length > 0;
    const displayMessage = isPositive || isNegative;
    const messageValue = isPositive ? successMessage : errorMessage;

    return (
        <>
            {displayMessage ? <Message negative={isNegative} positive={isPositive}>
                <Message.Header>{messageValue}</Message.Header>
            </Message> : null }
        </>
    );
}


export default ContactFormMessage;
