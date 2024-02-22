import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import './index.css'
import { createStore } from 'redux'
import { Provider } from 'react-redux'

import coordinatesReducer from './reducers/coordinatesReducer'

const store = createStore(coordinatesReducer)

ReactDOM.createRoot(document.getElementById('root')).render(
  <Provider store={store}>
    <App />
  </Provider>,
)
