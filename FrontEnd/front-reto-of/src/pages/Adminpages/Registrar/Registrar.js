import React, { useState } from "react";
import * as RiIcons from "react-icons/ri"
import * as FaIcons from "react-icons/fa"
import * as MdIcons from "react-icons/md"
import { Link } from "react-router-dom";
import Navbar from "../../../components/Navbar";
import { fetchData } from "../../../contexts/APIpost";
import './Registrar.css'
import * as AiOutlineIcons from "react-icons/ai";


export function Registrar() {
  const[admin, setAdmin]= useState(false)
  const[username, setUsername] = useState("")
  const[lastname, setLastname] = useState("")
  const[email, setEmail] = useState("")
  const[password, setPassword] = useState("")
  const [showPass, setShowPass] = useState(false);

    
  const handleAdminChange = () => {
    setAdmin(!admin);
  };

  function Guardar(e){

    fetchData('users/',{
      "last_login": "",
      "email": email,
      "first_name": username,
      "last_name": lastname,
      "is_admin": admin,
      "password": password
  }).then((response)=>{
  
      console.log("DATOS",response)
  });

    if (admin === true) {
      console.log("es admin");
    } else {
      console.log("NO es admin");
    }
    console.log("Datos guardados:", { username, lastname, email, password, admin });
    alert("Usuario Guardado")
    
    const data = { username, lastname, email, password, admin };
    localStorage.setItem('datos', JSON.stringify(data));
    
    }


    return(
        <div className="fondo_registrar">
        <Navbar/>
        <div >
        <h1 className='Titulo-reg'>Registrar Nuevo Usuario</h1>
        <img className="imagen" src="https://cdn-icons-png.flaticon.com/512/306/306232.png?w=740&t=st=1683275128~exp=1683275728~hmac=c0bfd2a10e276482fec524827315fe89a19808d99b068c9442261648eced3eec"/>
        <div className="container_card ">
          <div className="container_datos">
            <div className="row row-cols-1">

                <div className="input-group mb-5 datos row">
                    <span className="input-group-text" id="username"><FaIcons.FaUserAlt/></span>
                    <input type="text" className="form-control" placeholder="Username" value={username} onChange={(e) => setUsername(e.target.value)} />
                </div>

                <div className="input-group mb-5 datos row">
                    <span className="input-group-text" id="lastname"><FaIcons.FaUserAlt/></span>
                    <input type="text" className="form-control" placeholder="Lastname" value={lastname} onChange={(e) => setLastname(e.target.value)}/>
                </div>

                <div className="input-group mb-5 datos row">
                    <span className="input-group-text" id="email"><MdIcons.MdEmail/></span>
                    <input type="email" className="form-control" placeholder="Email" value={email} onChange={(e) => setEmail(e.target.value)}/>
                </div>

                {/*<div className="input-group mb-5 datos row">
                    <span className="input-group-text" id="basic-addon1"><RiIcons.RiLockPasswordFill /></span>
                    <input type="password" className="form-control" placeholder="Password"  value={password} onChange={(e) => setPassword(e.target.value)}/>
                </div>*/}

                {/*Prueba con icono */}
                <div className="mb-3 col-auto">
                
                  <div className="input-group mb-3 datos row Password_reg">
                      <span className="input-group-text" id="basic-addon1" onClick={()=>setShowPass(!showPass)}> { showPass ? <AiOutlineIcons.AiOutlineEye/>: <AiOutlineIcons.AiOutlineEyeInvisible/>}</span>
                      <input type={showPass? "text" : "password"}  className="form-control" placeholder="Password"  value={password} onChange={(e) => setPassword(e.target.value)} required/>
                  </div>

                  <div className="text-muted texto-bajo-reg">
                      Mínimo 6 caracteres
                  </div>
                </div>

                {/*Prueba con icono 
            <div className="mb-3 col-auto">
                
                <label className="form-label labels" htmlFor="txtpass"><strong>Password</strong></label>
                <div className="input-group Password">
                    <span className="input-group-text" onClick={()=>setShowPass(!showPass)}> { showPass ? <AiOutlineIcons.AiOutlineEye/>: <AiOutlineIcons.AiOutlineEyeInvisible/>}</span>
                    <input type={showPass? "text" : "password"} id="txtpass" style={{textAlign:"center"}} className="form-control" onChange={event => setPass(event.target.value)} required/>
                </div>
                <div className="text-muted texto-bajo">
                    Minimo 6 caracteres
                </div>
            </div>*/}

                <div className="input-group mb-3">
                    <div className="input-group-text">
                        <input className="form-check-input mt-0-lg" type="checkbox" checked={admin} onChange={handleAdminChange}/>
                        Is Admin?
                    </div>
                    
                </div>

                <div className="botones">
                  <button className="btn btn-primary " onClick={Guardar}>
                    Guardar
                  </button>

                  <Link to ="/lista_usuarios" className="ml-3 mt-2">Ver en lista</Link>
                </div>



                
                </div>   

            </div>
            </div>
            
        </div>
        </div>
        
    )
}