using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spike : MonoBehaviour
{
    public Transform defLook;
    public Transform[] wayPoints;
    public int activeDistance = 10;
    public float stoppingDistance = 5;
    public float timeWait = 3;
    public float rotationSpeed = 5;

    private NavMeshAgent agent;
    private Transform target;
    private float curTimeout;
    private int wayCount;
    private bool isTarget;

    private void Start()
    {
        agent.updateRotation = false;
    }
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        Quaternion rotation = Quaternion.Euler(90, 0, 0);
        float dis = Vector3.Distance(transform.position, target.position);

        if (dis < activeDistance)
        {
            isTarget = true;
        }

        if (dis > activeDistance)
        {
            isTarget = false;
        }

        if (wayPoints.Length >= 2 && !isTarget)
        {
            agent.stoppingDistance = 0;
            agent.SetDestination(wayPoints[wayCount].position);

            if (!agent.hasPath)
            {
                SetRotation(defLook.position);
                curTimeout += Time.deltaTime;

                if (curTimeout > timeWait)
                {
                    curTimeout = 0;

                    if (wayCount < wayPoints.Length - 1)
                    {
                        wayCount++;
                    }
                    else
                    {
                        wayCount = 0;
                    }
                }
            }
        }
        else if (wayPoints.Length == 0 || isTarget)
        {
            agent.stoppingDistance = stoppingDistance;
            agent.SetDestination(target.position);

            if (agent.velocity == Vector3.zero)
            {
                SetRotation(target.position);
            }
        }
    }
 void SetRotation(Vector3 lookAt)
    {
        Vector3 lookPos = lookAt - transform.position;
        lookPos.y = 0;
        Quaternion rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}

