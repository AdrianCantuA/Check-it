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
import { Bar, Doughnut, Line } from 'react-chartjs-2';

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

function Graph_JuegosCompletados_total() {  

    const [users, setUsers] = useState([]);
    const [completos, setCompletos] = useState(0);
    const [noCompletos, setNoCompletos] = useState(0);
    const [total, setTotal] = useState(0);

  useEffect(() => {
    fetchData('users/').then((response) => {
      setUsers(response);
      console.log("RESPONSE",response)
    });
  }, []);

  const Juegos_Completados = users.map((user) => user.games_completed);
  console.log("Juegos",Juegos_Completados)


  useEffect(() => {
    let completados = 0;
    let noCompletados = 0;
    let totlaJuegos = 0;
    users.forEach((user) => {
      user.games_completed > 0? completados = completados + 1 : noCompletados = noCompletados + 1; 
      totlaJuegos++;
    });
    setCompletos(completados);
    setNoCompletos(noCompletados);
    setTotal(totlaJuegos)
    console.log("completo:", completos)
    console.log("NO completo:", noCompletos)
  }, [users]);


  //opciones del grafico
  var opciones ={
    responsive: true,
    animation: false,
    plugins:{
      Legend:{
          display: true,
          labels: {
            font: {
            family: 'Poppins',
              size: 16,
              weight: 'bold'
            }
          }
      },
      title: {
          display: true,
          text: 'Interacción de jugadores',
          font: {
            family: 'Poppins',
            size: 18,
            weight: 'bold',
          }
      }
  }
  };

  // Configuración del gráfico
  const datos = {
    labels:["Han jugado","No han jugado"],
    datasets: [
      {
        label: 'Número de jugadores',
        data: [completos, noCompletos],
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
  export default Graph_JuegosCompletados_total;