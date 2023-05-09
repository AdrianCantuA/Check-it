import React, { useEffect, useState } from "react";
import { Form, useNavigate } from "react-router-dom";
import * as AiOutlineIcons from "react-icons/ai";
import './Login.css'
import { fetchData } from "../../contexts/APIpost";




function LoginView(e){

    const [loginact, setLoginact] = useState("false");
    const [user, setUser] = useState('');
    const [pass, setPass] = useState("");
    const [userList, setUserList ] = useState([]);
    const [showPass, setShowPass] = useState(false);
    const [usuario, setUsuario] = useState('');
    const [currentUser, setCurrentUser] = useState('');


    const navigate = useNavigate();
    localStorage.clear()

    

function iniciarSesion(e){

    e.preventDefault();
    fetchData('users/login/',
        { "email": user, password: pass },()=>{
            setLoginact("false");
            alert("Usuario Incorrecto!");
            document.getElementById("txtuser").value = "";
            document.getElementById("txtpass").value = "";
            document.getElementById("txtuser").focus();
        }).then((response)=>{
        setUserList(response);
        console.log("DATOS",response)
        localStorage.setItem("token", response.token)
        console.log("LOCAL", localStorage)

        setLoginact("true")
        navigate(`/home`);
        document.getElementById("form_login").style.display = "none";

    });


}

    
    return(

        <div className="main-container fondo_login" >
        
        <form id="form_login" className="login">
            
        

            <div>
            <img className="imagen-logo" src="https://es.rexnord.com/Rexnord/media/Rexnord-Images/Logos/regalrexnord-logo.png" />
            <h1 className="titulo">LOGIN</h1>

            <div className="mb-3 col-auto">
                <label className="form-label labels" htmlFor="txtuser"><strong>Email</strong></label>
                <input type="email" id="txtuser" style={{textAlign:"center"}} className="form-control" onChange={event => setUser(event.target.value)} required/>
                
            </div>



            {/*Prueba con icono */}
            <div className="mb-3 col-auto">
                
                <label className="form-label labels" htmlFor="txtpass"><strong>Password</strong></label>
                <div className="input-group Password">
                    <span className="input-group-text" onClick={()=>setShowPass(!showPass)}> { showPass ? <AiOutlineIcons.AiOutlineEye/>: <AiOutlineIcons.AiOutlineEyeInvisible/>}</span>
                    <input type={showPass? "text" : "password"} id="txtpass" style={{textAlign:"center"}} className="form-control" onChange={event => setPass(event.target.value)} required/>
                </div>
                <div className="text-muted texto-bajo">
                    Minimo 6 caracteres
                </div>
            </div>



            



            <div className="boton-submit">
            <input type="submit"  className="btn btn-primary boton" value="Login" onClick={iniciarSesion}/>
            </div>

            </div>
        </form>

    </div>
    
    )
}

export default LoginView;