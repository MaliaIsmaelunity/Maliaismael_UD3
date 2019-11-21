using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Controladordeljugador : MonoBehaviour
{

    public void Update()
    {

    }
    //Almacena componente Rigibody del personaje del jugador
    Rigidbody rb;
    public float velocidad;
    int contador;
    //Define variables para almacenar items recogidos
    int numitems_1;
    int numitems_2;


    public Text marcador;
    public Text finJuego;
    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        marcador.text = "Puntos:" + contador;
        finJuego.gameObject.SetActive(false);
    }
    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);
    }
    public void OnTriggerEnter(Collider other)
    //El fin de juego es cuando recoge todos los items de los dos tipos
    {
        if (other.tag == "Suma1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numitems_1 = numitems_1 + 1;
        }
        else if (other.tag == "Suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numitems_2 = numitems_2 + 1;
       }

        if (other.tag == "Resta 1")

        {
            contador = contador - 1;
        }

        ActualizaMarcador();
        if (numitems_1 >= 3 && numitems_2 >= 3)

        {
            finJuego.gameObject.SetActive(true);
            Time.timeScale = 0;

        }

       
    }
    void ActualizaMarcador()
    {
         marcador.text = "Puntos:" + contador;
       
         }
}

