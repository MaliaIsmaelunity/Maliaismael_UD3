using System.Collections;
using UnityEngine;

public class Controladordelacamara : MonoBehaviour
{
    public GameObject jugador;//objeto a perseguir
    private Vector3 posicionRelativa;

    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position - jugador.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = jugador.transform.position + posicionRelativa;

    }
}
