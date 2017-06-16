import React from 'react';
import ReactDOM from 'react-dom';
import { Provider } from 'react-redux'
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import './index.css';

import { createStore } from 'redux'
import { banzaiApp } from './reducers'
//import { GameStatus, changeStatus } from './actions'

let store = createStore(banzaiApp)
// store.dispatch(changeStatus(GameStatus.NOT_STARTED))
// console.log(store.getState())
// store.dispatch(changeStatus(GameStatus.IN_PROGRESS))
// console.log(store.getState())
// store.dispatch(changeStatus(GameStatus.COMPLETE))
console.log(store.getState())

store.subscribe(() =>
{
  var currentState = store.getState();
  console.log(currentState)
})

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  document.getElementById('root')
);
registerServiceWorker();
