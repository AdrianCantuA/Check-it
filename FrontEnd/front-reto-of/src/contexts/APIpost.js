

export const fetchData = async (route, body, onError=()=>{}) => {
  let headers = {"Content-Type": "application/json"}
  if (localStorage.getItem("token")){
    headers["Authorization"]=`Token ${localStorage.getItem("token")}`
  }
    try {
      const response = await fetch(`http://presno2112.pythonanywhere.com/api/${route}`,{
        method:"POST",
        body: JSON.stringify(body),
        headers: headers
      });
      
      const data = await response.json();
      console.log("data", data)
      return data;
      
      
    } catch (error) {
      console.log(error);
      onError(error);
    }
  };
  
 