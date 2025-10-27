using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    //Public Attributes
    public Transform camara;
    public Transform jugador;
    //Private Attributes
    private Vector3 _vistaHombro = new Vector3(12.5f, 4.6f, 1.4f);
    private Vector3 _vistaLateral = new Vector3(9f, 4.5f, 3f);
    private Vector3 _vistaCenital = new Vector3(13f, 12f, 3.6f);
    
    private int _vistaActual = 0; // 0 = Hombro, 1 = Lateral, 2 = Cenital
    //Methods

    void Start()
    {
        camara.position = _vistaHombro;
    }
        
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0) 
        { 
            _vistaActual++;
            if (_vistaActual > 2) _vistaActual = 0;
        }

        if (scroll < 0) 
        { 
            _vistaActual--;
            if (_vistaActual < 0) _vistaActual = 2;
        }



        Vector3 nuevaPosicion = Vector3.zero;

        if (_vistaActual == 0) 
            nuevaPosicion = _vistaHombro;
            camara.rotation = jugador.rotation;


        if (_vistaActual == 1) nuevaPosicion = _vistaLateral;
        if (_vistaActual == 2) nuevaPosicion = _vistaCenital;

        
        camara.position = nuevaPosicion;
        
        if (_vistaActual != 0) camara.LookAt(jugador);


    }
}
        
        
            
                
            
        
        
            
        

        
        

        
