import { React, useEffect } from 'react';
import { Grid, Header, Image } from 'semantic-ui-react';
import 'semantic-ui-css/semantic.min.css';
import ContactForm from './components/ContactForm';
import ContactsState from './context/ContactsState';

const App = () => {
    useEffect(() => {
        
    }, [])

    return (
        <ContactsState>
            <Grid textAlign='center' style={{ height: '100vh' }} verticalAlign='middle'>
                <Grid.Column style={{ maxWidth: 450 }}>
                    <Header as='h2'  textAlign='center'>
                        <Image src='/logo.png' /> Sign Up For Our Mailing List
                    </Header>
                    <ContactForm />
                </Grid.Column>
            </Grid>
        </ContactsState>
    );
}


export default App;
