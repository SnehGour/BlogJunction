import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Home from './pages/Home'
import Login from './pages/Login'
import Register from './pages/Register'
import Contact from './pages/Contact'
import About from './pages/About'
import Admin from './pages/Admin'


import './App.css';
import Header from './components/Header'

function App() {
  return (
    <BrowserRouter>
          <Header/>
       <Routes>
          <Route path="/" element={<Home/>} />
          <Route path="/login" element={<Login/>} />
          <Route path="/regsiter" element={<Register/>} />
          <Route path="/contact" element={<Contact/>} />
          <Route path="/about" element={<About/>} />
          <Route path="/admin" element={<Admin/>} />
       </Routes>
    </BrowserRouter>
  );
}

export default App;
