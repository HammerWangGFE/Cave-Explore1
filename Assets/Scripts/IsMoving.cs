using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IsMoving : MonoBehaviour
{
    //public Transform endNode;
    public NavMeshAgent NMA;
    public GameObject player;
    public bool isMoving = false;

    void Start()
    {
        NMA = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isMoving)
        {
            NMA.destination = player.transform.position;
        }
    }
}
