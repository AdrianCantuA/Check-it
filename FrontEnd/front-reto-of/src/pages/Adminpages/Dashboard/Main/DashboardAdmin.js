import Navbar from '../../../../components/Navbar';
import './Dashboard_admin.css'
import Graph_avgTime from '../Graficos/Graficos_inf/Graph_avgTime';
import Avg_time from '../Graficos/Graficos_sup/Avg_time';
import Chart3 from'../Graficos/Graficos_sup/Chart3'
import ScoreBoardAdmin from '../Graficos/Graficos_inf/Score Board Admin/tabla_scores_admin';
import Graph_JuegosCompletados_porUsuario from '../Graficos/Graficos_inf/JuegosCompletados_pUser';
import Graph_JuegosCompletados_total from '../Graficos/Graficos_inf/Graph_JuegosCompletado';


const Dashboard = () => (
  <>
  <div className='container-general'>
    <div className='fondo_dash'>
      <Navbar/>
      <h1 className='Title-dashAdmin'>DASHBOARD</h1>

      <div className='container-sup'> 

        <div className='graph-mini-1' id='num_usuarios'>
          <Chart3/>
          <div className='mb-3 texto'>
            Numero de usuarios
          </div>
          
        </div>

        <div className='graph-mini-2' id='avg_time'>
          <Avg_time/>
          <div className='mb-3 texto'>
            Tiempo promedio general
          </div>
        </div>

      </div>




      <div className='container-bajo_admin'> 

        <div className='graph-1-admin'>
          <ScoreBoardAdmin/>
        </div>

        <div className='graph-2'>
          <Graph_avgTime/>
        </div>

        <div className='graph-3'>
          <Graph_JuegosCompletados_total/>
        </div>

        <div className='graph-4'>
          <Graph_JuegosCompletados_porUsuario/>
        </div>

      </div> 
          
    </div>
  </div>

  </>
);
 export default Dashboard;
