using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GuardMovement : MonoBehaviour
{
    // Waypoints
    public Transform[] waypoints;

    // Settings
    public float moveSpeed = 4f;
    public float pauseSeconds = 1f;
    public float arriveDistance = 0.1f;

    private int nextIndex = 0;
    private bool isPaused = false;
    private float pauseUntilTime;
    
    // TWIST
    private int direction = 1;

    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = waypoints[0].position;
        AdvanceToNextWaypoint();

        BeginPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            direction *= -1;
        }
        if (isPaused)
        {
            if (Time.time >= pauseUntilTime)
            {
                isPaused = false;
            }
            else
            {
                return;
            }
        }
        
        Transform nextWaypointTransform = waypoints[nextIndex];
        if (nextWaypointTransform == null)
        {
            Debug.LogError("No next waypoint found.");
            return;
        }


        gameObject.transform.position = UnityEngine.Vector2.MoveTowards(
            transform.position, 
            nextWaypointTransform.position, 
            moveSpeed * Time.deltaTime);


        if (UnityEngine.Vector2.Distance(transform.position, nextWaypointTransform.position) < arriveDistance)
        {
            AdvanceToNextWaypoint();
            BeginPause();
        }

    }

    private void AdvanceToNextWaypoint()
    {
        nextIndex += direction;
        if (nextIndex >= waypoints.Length)
        {
            nextIndex = 0;
        } else if (nextIndex < 0)
        {
            nextIndex = waypoints.Length - 1;
        }
    }

    private void BeginPause()
    {
        isPaused = true;
        pauseUntilTime = Time.time + pauseSeconds; 
    }
}
