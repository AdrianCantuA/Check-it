using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    public InputField emailInput;
    public InputField passwordInput;

    public void LogIn() {
        string email = emailInput.text;
        string password = passwordInput.text;

        //Aquí puedes agregar el código para validar las credenciales del usuario.
        //Por ejemplo, puedes enviar una solicitud a un servidor para verificar el correo electrónico y la contraseña.

        //Una vez que se verifican las credenciales, puedes cargar la siguiente escena o realizar otras acciones.
    }
}
