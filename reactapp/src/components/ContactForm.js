import React, { useContext } from "react"
import { Button, Form, Segment } from 'semantic-ui-react';
import ContactsContext from '../context/ContactsContext';
import ContactFormMessage from './ContactFormMessage';

const ContactForm = () => {
    const contactsContext = useContext(ContactsContext);
    const {
        setFirstName,
        setLastName,
        setEmail,
        errorMessage,
        successMessage,
        add
    } = contactsContext;
    return (
        <>
            <ContactFormMessage errorMessage={errorMessage} successMessage={successMessage } />
            <Form size='large'>
                <Segment stacked>
                    <Form.Input
                        fluid icon='user'
                        iconPosition='left'
                        placeholder='E-mail address'
                        onChange={e => setEmail(e.target.value)}
                    />
                    <Form.Input
                        fluid
                        placeholder='First Name'
                        onChange={e => setFirstName(e.target.value)}
                    />
                    <Form.Input
                        fluid
                        placeholder='Last Name'
                        onChange={e => setLastName(e.target.value)}
                    />
                    <Button fluid size='large' onClick={add}>
                        Sign Up
                    </Button>
                </Segment>
            </Form>
        </>
        
    );
}


export default ContactForm;
