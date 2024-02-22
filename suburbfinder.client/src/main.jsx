import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import { combineReducers, createStore } from 'redux'
import { Provider } from 'react-redux'

import coordinatesReducer from './reducers/coordinatesReducer'
import suburbsReducer from './reducers/suburbsReducer.js'

const reducer = combineReducers({
    coordinates: coordinatesReducer,
    suburbs: suburbsReducer
})

const store = createStore(reducer)

ReactDOM.createRoot(document.getElementById('root')).render(
  <Provider store={store}>
    <App />
  </Provider>,
)
