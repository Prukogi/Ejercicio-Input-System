using UnityEngine;

public class InputController : MonoBehaviour
{
    //Public Attributes
    public Transform playerCylinder;
    public float movementSpeed = 3;
    
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        

        playerCylinder.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        playerCylinder.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }
}
