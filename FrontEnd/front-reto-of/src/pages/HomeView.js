import React from "react";
import Navbar from "../components/Navbar";
import './Home.css'


console.log("LOCAL", localStorage)




export const Home = () => {
    return(

        <>
            <div className="fondo_home">
                <div>
                    <Navbar/>
                    <div className="container-cont">
                        <h1 className="titulo-home">Bienvenidos</h1>
                        <img className="imagen_pr" src="https://i.ytimg.com/vi/BBGux_NIF1s/maxresdefault.jpg"/>
                    </div>
                </div>
            </div>
        </>
        
        
    )
}