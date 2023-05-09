import React from "react";

function Spinner(props){
    return (<>
    <div className="spinner-border text-primary" role="status">
            <span className="visually-hidden"></span>
        </div> 
        {props.msg}
    </>)
}

export default Spinner;