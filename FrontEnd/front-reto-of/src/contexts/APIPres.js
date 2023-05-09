

export const fetchData = async (route, onError=()=>{}) => {
  let headers = {"Content-Type": "application/json"}
  if (localStorage.getItem("token")){
    headers["Authorization"]=`Token ${localStorage.getItem("token")}`
  }
    try {
      const response = await fetch(`http://presno2112.pythonanywhere.com/api/${route}`,{headers:headers});
      
      const data = await response.json();
      console.log("dataa", data)
      return data;
      
      
    } catch (error) {
      console.log(error);
      onError(error);
    }
  };
  
 