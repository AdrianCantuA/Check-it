import React, {useEffect, useState} from "react";
import { fetchData } from "../../../contexts/APIPres";
import Spinner from "../../../components/Spinner";
import Navbar from "../../../components/Navbar";
import * as FcIcons from "react-icons/fc"
import './ListaUsuarios.css'


function PruebaAPI(){

    //hooks
    const [data, setData] = useState([]);
    const [isLoading, setLoading ] = useState(false)
    


    
    useEffect(() => {
        setLoading(true)
        fetchData('users/').then((response)=>{
            setData(response);
            console.log("DATOS",response)
            setLoading(false)

        });
        
    
    }, []);

    console.log("datos", data)

    const columns = [
        { title: "ID",key: "id",}, 
        {title: "First Name", key: "first_name",},   
        {title: "Last Name",key: "last_name",},
        {title: "Email",key: "email",},
        {title: "Is Admin",key: "is_admin",}     
     
       ];
   

    return(
        <>
        <div>

      <div className="fondo_lista">
        <div className="container-lista">
        <Navbar/>

        <div>
        <h1 className="Title-listUser"><strong>Lista de Jugadores</strong></h1>

        <div className="mb-3 mt-1 mr-4">
          <button className="btn btn-primary float-right mb-3 mt-1 mr-4" onClick={() => window.location.replace('/registrar')}>
            Registrar Usuario
          </button>
        </div>
        
          

          {isLoading ? 

              <Spinner msg = "Loading..."/> : 
              <div className="table-container">
              <table className="tabla_lista_usuarios table table-striped table-hover table-bordered">
                <thead>
                  <tr>
                    {columns.map(column =>(
                      <th key={column.key}>{column.title}</th>
                      
                    ))}
                  </tr>
                </thead>

                <tbody>
                  {data.map(user =>(
                    <tr key={user.id}>
                        <td>{user.id}</td>
                      <td>{user.first_name}</td>
                      <td>{user.last_name}</td>
                      <td>{user.email}</td>
                      <td>{user.is_admin ? <FcIcons.FcCheckmark/> : <FcIcons.FcCancel/>}</td>
                    </tr>
                  ))}
                </tbody>
              </table>
              </div>
          }
          
          </div>
          </div>
          </div>
        </div>
        
        </>
        )
}

export default PruebaAPI;