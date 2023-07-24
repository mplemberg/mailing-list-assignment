import {
    SET_STATE_VALUE
} from "./Types";

export default (state, action) => {
    switch (action.type) {
        case SET_STATE_VALUE:
            let newState = { ...state };
            newState[action.payload.property] = action.payload.value;
            return newState;
    }
};