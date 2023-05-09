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

function Graph_Completados_user() {  

    const [user, setUser] = useState([]);
    const [completos, setCompletos] = useState(0);
    const [noCompletos, setNoCompletos] = useState(0);
    const [total, setTotal] = useState(0);
    const [results, setResults] = useState([]);    
    const [filteredResults, setFilteredResults] = useState([]);

    
    useEffect(() => {
      const token = localStorage.getItem('token');

    if (token){
      fetchData('/users/current_user/', (error) => {
        console.log(error);
      }).then((response) => {
        console.log("Usuarios",response);
        setUser(response);

      });
    }
  }, []);


  useEffect(() => {
    fetchData('results/').then((response)=>{
        setResults(response);
        console.log("Resultados",response)
        // Filtrar los resultados por el id de users
        const filtered = response.filter((item) => item.user === parseInt(user.id));
        setFilteredResults(filtered);

        console.log("FILTRO",filtered)

    });

    
    

}, [user]);


  useEffect(() => {
    let completados = 0;
    let noCompletados = 0;
    let totlaJuegos = 0;

    filteredResults.map((user) => {
      user.completed ? completados = completados + 1 : noCompletados = noCompletados + 1; 
      setCompletos(completados);
      setNoCompletos(noCompletados);

      totlaJuegos = totlaJuegos + 1;
      setTotal(totlaJuegos)

    });

    console.log("completo:", completos)
    console.log("NO completo:", noCompletos)
  }, [user]);


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
          text: 'Número de juegos completados',
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
    labels:["Completado","No Completado"],
    datasets: [
      {
        label: 'Numero de juegos',
        data: [completos, noCompletos],
        backgroundColor: 'rgba(75, 192, 192, 0.2)',
        borderColor: 'rgba(75, 192, 192, 1)',
        borderWidth: 1,
      },
    ],
  };


  return (
    <>
    {(filteredResults.length > 0) ? (
      <Line data={datos} options={opciones} />
    ) : (
      <p>Cargando datos...</p>
    )}
    </>
  );
}
  export default Graph_Completados_user;