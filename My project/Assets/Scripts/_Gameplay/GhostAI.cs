using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostAI : MonoBehaviour
{

    [SerializeField] public Transform target;
    NavMeshAgent NavMeshAgent;

   

    public float moveSpeed = 3.5f;
    private Rigidbody rb;
    Vector3 targetMain;
    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Play").transform;
      
    }

    // Update is called once per frame
    void Update()
    {
        targetMain = target.position;
        NavMeshAgent.SetDestination(target.position);
    }
}
