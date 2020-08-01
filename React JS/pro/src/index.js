import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import TodoList from "./component/TodoList";

var destination = document.querySelector("#container")


ReactDOM.render(
  <React.StrictMode>
    <div>
        <TodoList/>
    </div>
  </React.StrictMode>,
  document.getElementById('root')
);

serviceWorker.unregister();
