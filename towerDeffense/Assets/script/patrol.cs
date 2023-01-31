
using UnityEngine;

public class patrol: MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;
    public GameObject waypointsManager;
    private Transform target;
    private int destPoint;

    void Start()
    {
        waypointsManager = GameObject.FindGameObjectWithTag("waypointsManager");
        waypoints = waypointsManager.GetComponentsInChildren<Transform>();
        waypoints[0] = waypoints[1];
        target = waypoints[0];
    }


    void Update()
    {
        Vector3 dir = target.position - transform.position;

        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        //si l ennemi est quasiment arrivé à sa destination
        if (Vector3.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
