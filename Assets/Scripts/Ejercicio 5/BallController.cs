using UnityEngine;

public class BallController : MonoBehaviour
{
    //Public Attributes
    
    public float movementSpeed;
    //Private Attributes
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed);
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Grava")) movementSpeed = 2;
        if (other.CompareTag("Metal")) movementSpeed = 10;
        if (other.CompareTag("Tierra")) movementSpeed = 5;
    }


}
