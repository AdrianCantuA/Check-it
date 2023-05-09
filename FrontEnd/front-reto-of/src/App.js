import './App.css';
import { Home } from './pages/HomeView';
import LoginView from './pages/Login/LoginView';
import {BrowserRouter, Route, Routes} from 'react-router-dom'
import Dashboard from './pages/Adminpages/Dashboard/Main/DashboardAdmin';
import Dashboard_user from './pages/Userpages/Dashboard_user/Dashboard_user';
import PruebaAPI from './pages/Adminpages/Lista de usuarios/UsuariosAPI';
import PerfilView from './pages/Perfil/PerfilView';
import { Registrar } from './pages/Adminpages/Registrar/Registrar';


function App() {
  return (
    <>
      
      <BrowserRouter >
          
          <Routes> 
            <Route exact path="/" element = {<LoginView/>}></Route>
            <Route path="/home" element = {<Home/>}></Route>
            <Route path="/registrar" element = {<Registrar/>}></Route>
            <Route path="/dashboards" element = {<Dashboard/>}></Route>
            <Route path="/dashboard" element = {<Dashboard_user/>}></Route>
            <Route path="/perfil" element = {<PerfilView/>}></Route>
            <Route path="/lista_usuarios" element = {<PruebaAPI/>}></Route>


          </Routes>
        
      </BrowserRouter>

      
    </>
  );
}

export default App;
