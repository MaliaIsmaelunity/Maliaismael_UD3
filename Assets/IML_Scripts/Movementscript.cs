using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movementscript : MonoBehaviour
{

    public GameObject destino;
    private UnityEngine.AI.NavMeshAgent agenteDeNavegacion;

    // Use this for initialization
    void Start()
    {
        agenteDeNavegacion = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        agenteDeNavegacion.SetDestination(destino.transform.position);
    }

}