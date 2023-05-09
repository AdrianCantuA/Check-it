import React, { useEffect, useState } from 'react'
import './Chart3.css'


import {
  Chart as ChartJS,
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  Title,
  Tooltip,
  Legend,
  Filler,
  BarElement,
} from 'chart.js';
import { fetchData } from '../../../../../contexts/APIPres';

ChartJS.register(
  CategoryScale,
  LinearScale,
  PointElement,
  LineElement,
  BarElement,
  Title,
  Tooltip,
  Legend,
  Filler
);

function Chart3() {  

    const [users, setUsers] = useState([]);    

    
    useEffect(() => {
        fetchData('users/').then((response)=>{
            setUsers(response);
            console.log("DATOS",response)
        });
        
    
    }, []);
  
  
    return (
      <>
        <div className='numero'>
          <strong>{users.length}</strong>
        </div>
       
      </>
    );
  }
  
  export default Chart3;