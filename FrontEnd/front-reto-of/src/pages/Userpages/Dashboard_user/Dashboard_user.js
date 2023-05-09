import Navbar from '../../../components/Navbar';
import './Dashboard_user.css'
import Avg_time_user from './Graficos_user/Graficos_sup/Avg_time_user';
import Graph_Completados_user from './Graficos_user/Graficos_inf/Graph_PastelCompletado';
import Graph_bestTime_us from './Graficos_user/Graficos_inf/Graph_bestTime_us';
import ScoreBoard from './Graficos_user/Graficos_inf/Score Board/tabla';



const Dashboard_user = () => (
  <>
  <div className='container-general'>
    <div className='fondo_dashuser'>
      <Navbar/>
      <h1 className='Title-dashUser'>DASHBOARD USUARIO</h1>

      <div className='container-sup'> 

        <div className='graph-mini-1' id='num_usuarios'>
          <Avg_time_user/>
          <div className='mb-3 texto'>
            Tiempo Promedio
          </div>
          
        </div>

        

      </div>




      <div className='container-bajo'> 

        <div className='graph-1'>
          <ScoreBoard/>
          
        </div>

        <div className='graph-2'>
          <Graph_Completados_user/>
        </div>

        <div className='graph-4'>
          <Graph_bestTime_us/>
        </div>

      </div> 
          
    </div>
  </div>

  </>
);
 export default Dashboard_user;
