import React, { useEffect, useState } from 'react'
import { fetchData } from '../../../../../../contexts/APIPres';
import Spinner from '../../../../../../components/Spinner';
import './tabla.css'

function ScoreBoard() {
  //hooks
  const [board, setBoard] = useState([]);
  const [isLoading, setLoading ] = useState(false);
  
  useEffect(() => {
      setLoading(true)
      fetchData('games/leaderboard/').then((response)=>{
          setBoard(response[0].leaderboard);

          console.log("RESPONSE",response);

          setLoading(false)


      });
      
  
  }, []);

  console.log("BOARD", board)




  const columns = [
      {title: "First Name", key: "first_name",},   
      {title: "Last Name",key: "last_name",},
      {title: "Time",key: "time",}     
     ];

 

  return(
      <>
      
        

        {isLoading ? 

            <Spinner msg = "Loading..."/> :

            <div>

              <div className='Titulo_tabla'><strong>Score Board</strong></div>
            
           <div className="table-container">
            <table className="tabla table table-striped table-bordered table-responsive">
              <thead>
                <tr>
                  {columns.map(column =>(
                    <th key={column.key} >{column.title}</th>
                    
                  ))}
                </tr>
              </thead>

              <tbody>
                {board.map(user =>(
                  <tr key={user.id}>
                    <td>{user.user_data.first_name}</td>
                    <td>{user.user_data.last_name}</td>
                    <td>{user.time}</td>
                  </tr>
                ))}
              </tbody>
            </table>
            </div>

            </div>
        }
        
        
      
      </>
      )
}

export default ScoreBoard;
