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

function Graph_JuegosCompletados() {  

    const [users, setUsers] = useState([]);

  useEffect(() => {
    fetchData('users/').then((response) => {
      setUsers(response);
    });
  }, []);

  // Extraer los tiempos promedio de sesión de cada usuario
  const Juegos_Completados = users.map((user) => user.games_completed);
  console.log("Juegos",Juegos_Completados)


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
          text: 'Número de juegos completados por usuario',
          font: {
            family: 'Poppins',
            size: 18,
            weight: 'bold',
            
          }
      },
      layout: {
        padding: {
          bottom: 20, // ajusta el espacio entre la leyenda y la gráfica
        },
      },
  }
  };

  // Configuración del gráfico
  const datos = {
    labels: users.map((user) => user.first_name),
    datasets: [
      {
        label: 'Numero de juegos completados',
        data: Juegos_Completados,
        backgroundColor: 'rgba(75, 192, 192, 0.2)',
        borderColor: 'rgba(75, 192, 192, 1)',
        borderWidth: 1,
        fill: true,
        pointRadius:5,
        pointBorderColor: 'rgba(75, 192, 192, 0.2)',
      },
    ],
  };


  return (
    <>
    {users.length > 0 ? (
      <Line data={datos} options={opciones} />
    ) : (
      <p>Cargando datos...</p>
    )}
    </>
  );
}
  export default Graph_JuegosCompletados;