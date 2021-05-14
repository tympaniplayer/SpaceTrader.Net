import {Action, Reducer} from 'redux';
import {AppThunkAction } from './';

//STATE

export interface UserState {
   isLoading: boolean;
   user: User;
}

export interface UserAuthorization {
    token: string;
    username: string;
}

export interface User {
    credits: number;
    ships: UserShip[];
    loans: UserLoan[];
}

export interface UserShip {
    
}

export interface UserLoan {
    
}


// ACTIONS

interface RequestUserInformation {
   type: 'REQUEST_USER_INFORMATION';
   auth: UserAuthorization;
}

interface ReceiveUserInformation {
   type: 'RECEIVE_USER_INFORMATION';
   user: User;
}

// Discriminated union type
type KnownAction = RequestUserInformation | ReceiveUserInformation;

// Action Creators - Functions exposed to UI components that trigger state transition.
export const actionCreators = {
    requestUserInformation: (auth: UserAuthorization): AppThunkAction<KnownAction> => (dispatch, getState) => {
        const appState = getState();
        if (appState && appState.UserInfo) {
            const requestHeaders: HeadersInit = new Headers();
            requestHeaders.set('Authorization', `bearer ${auth.token}`);
            fetch(`userinfo?user=${auth.username}`, {
                method: 'GET',
                headers: requestHeaders,
            })
                .then(response => response.json() as Promise<User>)
                .then(data => {
                    dispatch({type: 'RECEIVE_USER_INFORMATION', user: data});
                });
            
            dispatch({type: 'REQUEST_USER_INFORMATION', auth});
        }
    }
};