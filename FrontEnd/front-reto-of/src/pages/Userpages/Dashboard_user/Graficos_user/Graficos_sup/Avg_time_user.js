import React, { useEffect, useState } from 'react'
import './Chart3_user.css'

import { fetchData } from '../../../../../contexts/APIPres';



function Avg_time_user() {  

    const [userData, setUserData] = useState([]);
    const [results, setResults] = useState([]);    
    const [filteredResults, setFilteredResults] = useState([]);
    const [averageTime, setAverageTime] = useState(0);

    
    useEffect(() => {
      const token = localStorage.getItem('token');

    if (token){
      fetchData('/users/current_user/', (error) => {
        console.log(error);
      }).then((response) => {
        console.log("RESP",response);
        setUserData(response);

      });
    }
  }, []);


  useEffect(() => {
    fetchData('results/').then((response)=>{
        setResults(response);
        console.log("Resultados",response)
        // Filtrar los resultados por el id de userData
        const filtered = response.filter((item) => item.user === parseInt(userData.id));
        setFilteredResults(filtered);

        console.log("FILTRO",filtered)


    });
    

}, [userData]);



useEffect(() => {
  let totalTime = 0;
  let count = 0;
  filteredResults.forEach((user) => {
    totalTime += user.time;
    count++;
  });
  const avgTime = totalTime / count;
  setAverageTime(avgTime);
  console.log(averageTime)
}, [filteredResults]);



    

  
    return (
      <>
        <div className='numero'>
          
          <strong>{averageTime.toFixed(2)}</strong>
        </div>
       
      </>
    );
  }
  
  export default Avg_time_user;