import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import FavList from './Favs/FavList';

function App() {
  return (
    <div className="App">
      <Header title="Em's Stuff and Things!" />
      <FavList/>
    </div>
  );
}

export default App;
