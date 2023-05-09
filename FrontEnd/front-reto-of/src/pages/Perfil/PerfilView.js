import { useEffect, useState } from 'react';
import Navbar from '../../components/Navbar';
import './Perfil.css'
import { fetchData } from "../../contexts/APIPres";
import Spinner from '../../components/Spinner';


function PerfilView () {
  const [userData, setUserData ] = useState([]);
  const [userAct, setUserAct ] = useState([]);
  const [isLoading, setLoading ] = useState(false);
  const [filteredResults, setFilteredResults] = useState([]);


  useEffect(() => {
    const token = localStorage.getItem('token');

  if (token){
    fetchData('/users/current_user/', (error) => {
      console.log(error);
    }).then((response) => {
      console.log("RESP",response);
      setUserAct(response);

    });
  }
}, []);

useEffect(() => {
  fetchData('users/').then((response)=>{
      setUserData(response);
      console.log("ListaUsuarios",response);

      if (userAct.id) {
      const filtered = response.filter((item) => item.id === userAct.id);
      setFilteredResults(filtered);
      console.log("FILTRO", filtered);
    }


  });
  

}, [userAct]);
  

return(
  <>
   {isLoading ? 
   <Spinner msg = "Loading..."/> : 

    <>
    <div className='fondo'>
      <Navbar/>
      <div>
      <h1 className="Titulo-perfil"><strong>Perfil</strong></h1>
      <div className="container">
        <div className="main-body">
          
          <div className='col'>
            <div className="row gutters-sm">
              <div className="col-md-4 mb-3">
                <div className="card">
                  <div className="card-body">
                    <div className="d-flex flex-column align-items-center text-center">
                      <img src="https://img.freepik.com/vector-gratis/ilustracion-empresario_53876-5856.jpg?w=740&t=st=1682756670~exp=1682757270~hmac=6c753eaf9437be2e89f973eea27d92d6357c0b1f03b4ff237f31c0866ed91ab8" alt="Admin" className="rounded-circle" width="150"/>

                      <div className="mt-3">
                        <h4></h4>
                        <p className="text-secondary mb-1">Full Stack Developer</p>
                        <p className="text-muted font-size-sm">Bay Area, San Francisco, CA</p>
                  
                      </div>

                    </div>
                  </div>
                </div>
                </div>


              <div className="col mb-3">
                <div className="card mb-3">
                  <div className="card-body">

                    <div className="row">
                      <div className="col-sm-3">
                        <h6 className="mb-0">Full Name</h6>
                      </div>

                      <div className="col-sm-9 text-secondary">
                        {userData.email}
                      </div>
                    </div>

                    <div className="row">
                      <div className="col-sm-3">
                        <h6 className="mb-0">Email</h6>
                      </div>

                      <div className="col-sm-9 text-secondary">
                        fip@jukmuh.al
                      </div>
                    </div>

                    <div className="row">
                      <div className="col-sm-3">
                        <h6 className="mb-0">Phone</h6>
                      </div>
                      <div className="col-sm-9 text-secondary">
                        (239) 816-9029
                      </div>
                    </div>

                    <div className="row">
                      <div className="col-sm-3">
                        <h6 className="mb-0">Mobile</h6>
                      </div>
                      <div className="col-sm-9 text-secondary">
                        (320) 380-4539
                      </div>
                    </div>

                    <div className="row">
                      <div className="col-sm-3">
                        <h6 className="mb-0">Address</h6>
                      </div>
                      <div className="col-sm-9 text-secondary">
                        Bay Area, San Francisco, CA
                      </div>
                    </div>

                    <div className="row">
                      <div className="col-sm-12">
                        <a className="btn btn-info " target="__blank" href="#">Edit</a>
                      </div>
                    </div>

                  </div>
                </div>
              </div>
              </div>
            </div>

          </div>
      </div>
    </div>
    </div>

    </>
    }
  </>
  )
};
 export default PerfilView;
