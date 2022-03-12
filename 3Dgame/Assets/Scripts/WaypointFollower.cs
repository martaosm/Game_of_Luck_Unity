using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentIndex = 0;
    [SerializeField] float speed = 2f;
  
    void Update()
    {
        if (Vector3.Distance(waypoints[currentIndex].transform.position, transform.position) < .1f)
        {
            currentIndex++;
            if (currentIndex >= waypoints.Length)
            {
                currentIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentIndex].transform.position, Time.deltaTime * speed);
    }
}
