using Unity.VisualScripting;
using UnityEngine;


public class AntorchaInteraccion : MonoBehaviour
{
    //Public Attributes
    //Private Attributes
    private bool _JugadorCerca = false;
    private bool _AntorchaEncendida = false;
    private Renderer _renderer;

    //Methods
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = Color.black;
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.E))
            Interaccion();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador"))
            _JugadorCerca = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
            _JugadorCerca = false;
    }

    private void Interaccion() 
    {
        if (_JugadorCerca == true)
        {
            _AntorchaEncendida = !_AntorchaEncendida;
            if (_AntorchaEncendida == false)
            {
                _renderer.material.color = Color.black;
                Debug.Log("Antorcha apagada");
            }
            else 
            { 
                _renderer.material.color = Color.yellow;
                Debug.Log("Antorcha encendida");
            }
        }
        else 
            Debug.Log("No hay nada con lo que interactuar.");

    }
}



     
