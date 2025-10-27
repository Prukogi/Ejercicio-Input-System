using UnityEngine;


public class ControladorIman : MonoBehaviour
{
    //Public Attributes
    public Transform Player;
    public Transform[] ObjetoMovible;
    public float movementSpeed = 3;
    public float fuerzaGravedad = 5;
    //Private Attributes
    private Vector3 _PlayerPosition;
    //Methods
    void Update()
    {
        //Movimiento del iman
        Player.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        Player.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        Player.Translate(Vector3.up * Input.GetAxis("Jump") * Time.deltaTime * movementSpeed);


        if (Input.GetKey(KeyCode.LeftControl))
        {
            Player.Translate(Vector3.down * Time.deltaTime * movementSpeed);
        }


        //Atraccion del iman
        if (Input.GetMouseButton(0))
        {
            foreach (Transform obj in ObjetoMovible)
            {
                _PlayerPosition = Player.position - obj.position;
                obj.Translate(_PlayerPosition * Time.deltaTime * fuerzaGravedad);
            }
            print("Atrayendo objetos");
        }

        //Repulsion del iman
        if (Input.GetMouseButton(1)) 
        {
            foreach(Transform obj in ObjetoMovible) 
            {
                _PlayerPosition = Player.position - obj.position;
                obj.Translate(-_PlayerPosition * Time.deltaTime * fuerzaGravedad);
            }
            print("Repeliendo objetos");
        }

    }



}
            
