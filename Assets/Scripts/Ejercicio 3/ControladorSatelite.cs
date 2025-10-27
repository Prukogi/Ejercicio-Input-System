using UnityEngine;

public class ControladorSatelite : MonoBehaviour
{
    //Public Attributes
    public Transform Satelite;
    public Transform Planeta;
    public float VelocidadRotacion = 5;
    public float VelocidadOrbita = 2;
    //Private Attributes
    private Vector3 _PosicionDelPlaneta;
    //Methods



    void Update()
    {
        _PosicionDelPlaneta = (Planeta.position - Satelite.position).normalized;
        
        if (Input.GetKey(KeyCode.A)) 
        {
            Satelite.RotateAround(Planeta.position, Vector3.up, VelocidadRotacion * Time.deltaTime);
        }
            

        if (Input.GetKey(KeyCode.D))
        {
            Satelite.RotateAround(Planeta.position, Vector3.down, VelocidadRotacion * Time.deltaTime);
        }
            


        if (Input.GetKey(KeyCode.W))
        {
            Satelite.Translate(_PosicionDelPlaneta * Time.deltaTime * VelocidadOrbita, Space.World);
        }
            
            
        
        if (Input.GetKey(KeyCode.S))
        {
            Satelite.Translate(-_PosicionDelPlaneta * Time.deltaTime * VelocidadOrbita, Space.World);
        }
            
            
        
    }
}
            
