import React, { useReducer } from "react"
import ContactsContext from "./ContactsContext"
import Reducer from "./Reducer";
import apiClient from "../utils/ApiClient"
import {
    SET_STATE_VALUE,
} from "./Types";

const ContactsState = props => {
    const initialState = {
        firstName: '',
        lastName: '',
        email: '',
        errorMessage: '',
        successMessage: ''
    };

    const [state, dispatch] = useReducer(Reducer, initialState);

    const setFirstName = (value) => {
        dispatch({
            type: SET_STATE_VALUE,
            payload: { property: 'firstName', value}
        });
    }

    const setLastName = (value) => {
        dispatch({
            type: SET_STATE_VALUE,
            payload: { property: 'lastName', value }
        });
    }

    const setEmail = (value) => {
        dispatch({
            type: SET_STATE_VALUE,
            payload: { property: 'email', value }
        });
    }

    const setErrorMessage = (value) => {
        dispatch({
            type: SET_STATE_VALUE,
            payload: { property: 'errorMessage', value }
        });
    }

    const setSuccessMessage = (value) => {
        dispatch({
            type: SET_STATE_VALUE,
            payload: { property: 'successMessage', value }
        });
    }

    const add = async () => {
        const contact = {
            firstName: state.firstName,
            lastName: state.lastName,
            email: state.email
        }

        try {
            await apiClient.addContact(contact).then((response) => {
                if (response.ok) {
                    setSuccessMessage('You have been added to our mailing list!');
                } else {
                    response.json().then((errorJson) => {
                        let errorMessage = errorJson.errors[Object.keys(errorJson.errors)[0]];
                        setErrorMessage(errorMessage);
                    });
                }
            });
        } catch (error) {
            setErrorMessage('Network Error. Please Try Again.')
        }
    };

    return (
        <ContactsContext.Provider
            value={{
                //expose to all applications
                successMessage: state.successMessage,
                errorMessage: state.errorMessage,
                setFirstName,
                setLastName,
                setEmail,
                add
            }}
        >
            {props.children}
        </ContactsContext.Provider>
    )
}

export default ContactsState;