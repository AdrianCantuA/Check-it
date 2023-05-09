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

function Avg_time() {  

    const [users, setUsers] = useState([]);    
    const [averageTime, setAverageTime] = useState(0);


    
    useEffect(() => {
        fetchData('users/').then((response)=>{
            setUsers(response);
            console.log("DATOS",response)
        });
        
    
    }, []);
  
    useEffect(() => {
        let totalTime = 0;
        let count = 0;
        users.forEach((user) => {
          totalTime += user.avg_time;
          count++;
        });
        const avgTime = totalTime / count;
        setAverageTime(avgTime);
        console.log(averageTime)
      }, [users]);
  
    return (
      <>
        <div className='numero'>
          <strong>{averageTime.toFixed(2)}</strong>
        </div>
       
      </>
    );
  }
  
  export default Avg_time;