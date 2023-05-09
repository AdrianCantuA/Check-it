import React, { useEffect, useState } from 'react'
import * as FaIcons from "react-icons/fa"
import * as AiIcons from "react-icons/ai"
import { Link, useNavigate } from 'react-router-dom'
import { SideBarData } from './SideBarData'
import './Navbar.css';
import { IconContext } from 'react-icons'
import { fetchData } from '../contexts/APIPres'


function Navbar() {

    const[sidebar, setSideBar] = useState(false)
    const[isAdmin, setIsAdmin] = useState(false)

    const showSideBar = () => setSideBar(!sidebar)

    useEffect(() => {
        fetchData(`users/current_user/`).then((response)=>{
        console.log(response)
        setIsAdmin(response.is_admin)
    
        });
      }, []);
    


    function cerrarSesion(){
        document.getElementById("form_login").style.display = "block";
        document.getElementById("txtuser").value = "";
        document.getElementById("txtpass").value = "";
        document.getElementById("txtuser").focus(); 
        localStorage.clear()
    }



  return (
    <>
    <IconContext.Provider value={{color: '#fff'}}>
    <div className='navbar'>
        <Link to = '#' className='menu-bars'>
            <FaIcons.FaBars onClick={showSideBar}/>
        </Link>
    </div>

        <nav className={sidebar ? 'nav-menu active' : 'nav-menu'}>
            <ul className='nav-menu-items' onClick={showSideBar}>
                <li className='navbar-toggle'>
                    <Link to = "#" className='menu-bars'>
                        <AiIcons.AiOutlineClose />
                    </Link>
                </li>
                
                

                {SideBarData.map((item, index) => {
                    if(item.forAdmin && !isAdmin || (item.hiddenForAdmin && isAdmin)){
                        return null;
                    }
                    
                    return(
                        
                        
                        <li key = {index} className={item.cName}>
                            
                            <Link to = {item.path} onClick={()=>{
                                if (item.title === "Cerrar Sesion") {
                                    cerrarSesion();}
                            }}>
                                {item.icon}
                                <span>{item.title}</span>
                            </Link>

                            


                        

                        </li>
                    )
                    
                })}


            </ul>
        </nav>
        </IconContext.Provider>


    </>
  )
}

export default Navbar;
