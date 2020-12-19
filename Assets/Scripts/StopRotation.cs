using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class StopRotation : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<NavMeshAgent>().updateRotation = false;
        gameObject.GetComponent<NavMeshAgent>().updateUpAxis = false;


    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<NavMeshAgent>().SetDestination(target.transform.position);
    }
}
