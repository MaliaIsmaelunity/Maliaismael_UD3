using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salirdeljuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); //sale del juego. No lo pausa.        }
        }

    }
}
