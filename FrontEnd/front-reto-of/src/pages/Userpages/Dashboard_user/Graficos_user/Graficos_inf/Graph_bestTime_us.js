import React, { useEffect, useState } from 'react'


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
import { Bar, Line } from 'react-chartjs-2';

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

function Graph_bestTime_us() {  

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

var opciones ={
  responsive: true,
  animation: false,
  plugins:{
    Legend:{
        display: true,
        labels: {
          font: {
            size: 16,
            weight: 'bold'
          }
        }
    },
    title: {
        display: true,
        text: 'Tiempo por juego',
        font: {
          family: 'Poppins',
          size: 18,
          weight: 'bold',
          
        },
        

    },
    layout: {
      padding: {
        bottom: 20, // ajusta el espacio entre la leyenda y la gráfica
      },
    },
}
};



const datos = {
  labels: filteredResults.map((juego) => juego.game),
  datasets: [
    {
      label: 'Tiempo en juego (Segundos)',
      data: filteredResults.map((user) => user.time),
      backgroundColor: filteredResults.map((user) => (user.time === Math.min(...filteredResults.map((user) => user.time)) ? 'rgba(255, 99, 132, 0.2)' : 'rgba(75, 192, 192, 0.2)')),
        borderColor: filteredResults.map((user) => (user.time === Math.min(...filteredResults.map((user) => user.time)) ? 'rgba(255, 99, 132, 1)' : 'rgba(75, 192, 192, 1)')),
      borderWidth: 1,
    },
  ],
};



  


  return (
    <>
      <div className='numero'>
        
      <Bar data={datos} options={opciones} style={{ width: '600px', height: '600px' }}/>
      </div>
     
    </>
  );
}
  export default Graph_bestTime_us;