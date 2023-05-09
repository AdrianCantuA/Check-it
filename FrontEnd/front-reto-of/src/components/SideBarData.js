import React from 'react'
import * as FaIcons from "react-icons/fa"
import * as AiIcons from "react-icons/ai"
import * as CgIcons from "react-icons/cg"


export const SideBarData = [
    
    
    {
        title: 'Home',
        path: '/home',
        icon: <AiIcons.AiFillHome/>,
        cName: 'nav-text'
    },

    {
        forAdmin: true,
        title: 'Dashboard',
        path: '/dashboards',
        icon: <AiIcons.AiOutlineDashboard/>,
        cName: 'nav-text'
    },

    {
        hiddenForAdmin: true,
        title: 'Dashboard',
        path: '/dashboard',
        icon: <AiIcons.AiOutlineDashboard/>,
        cName: 'nav-text'
    },

    {
        forAdmin: true,
        title: 'Lista de Jugadores',
        path: '/lista_usuarios',
        icon: <FaIcons.FaRegListAlt/>,
        cName: 'nav-text'
    },


   /* {
        title: 'Perfil',
        path: '/perfil',
        icon: <CgIcons.CgProfile/>,
        cName: 'nav-text'
    },*/


    {
        title: 'Cerrar Sesion',
        path: '/',
        icon: <AiIcons.AiOutlineLogout/>,
        cName: 'nav-text',
    }
]