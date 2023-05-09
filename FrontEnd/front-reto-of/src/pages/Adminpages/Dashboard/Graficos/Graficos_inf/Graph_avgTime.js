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

function Graph_avgTime() {  

    const [users, setUsers] = useState([]);

  useEffect(() => {
    fetchData('users/').then((response) => {
      setUsers(response);
    });
  }, []);

  // Extraer los tiempos promedio de sesión de cada usuario
  const averageTimes = users.map((user) => user.avg_time);
  //console.log("AVERAGE",averageTimes)


  //opciones del grafico
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
          text: 'Tiempo promedio por usuario',
          font: {
            family: 'Poppins',
            size: 18,
            weight: 'bold'
          }
      }
  }
  };

  // Configuración del gráfico
  const datos = {
    labels: users.map((user) => user.first_name),
    datasets: [
      {
        label: 'Tiempo promedio en juego (Segundos)',
        data: users.map((user) => user.avg_time),
        backgroundColor: 'rgba(75, 192, 192, 0.2)',
        borderColor: 'rgba(75, 192, 192, 1)',
        borderWidth: 1,
      },
    ],
  };


  return (
    <>
    {users.length > 0 ? (
      <Bar data={datos} options={opciones} />
    ) : (
      <p>Cargando datos...</p>
    )}
    </>
  );
}
  export default Graph_avgTime;