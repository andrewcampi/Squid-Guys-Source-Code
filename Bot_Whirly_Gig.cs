using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.Demos;

public class Bot_Whirly_Gig : MonoBehaviour
{
    public GameObject waypoint1_1;
    public GameObject waypoint1_2;
    public GameObject waypoint1_3;
    public GameObject waypoint1_4;
    public GameObject waypoint2_1;
    public GameObject waypoint2_2;
    public GameObject waypoint2_3;
    public GameObject waypoint2_4;
    public GameObject waypoint3_1;
    public GameObject waypoint3_2;
    public GameObject waypoint3_3;
    public GameObject waypoint3_4;
    public GameObject goal;
    public int goingToWaypointSet = 1;
    public int waypointSet1Selection = 1;
    public int waypointSet2Selection = 1;
    public int waypointSet3Selection = 1;


    // Start is called before the first frame update
    void Start()
    {
        // Pick a random waypoint for set 1 (1-4)
        waypointSet1Selection = Random.Range(1, 5);
        // Pick a random waypoint for set 2 (1-4)
        waypointSet2Selection = Random.Range(1, 5);
        // Pick a random waypoint for set 3 (1-4)
        waypointSet3Selection = Random.Range(1, 5);
        // Start coroutine "play"
        StartCoroutine("play");
    }

    IEnumerator play()
    {
        // Disable navigation component
        gameObject.GetComponent<UserControlAI>().enabled = false;
        // At start, bot waits for "go"
        yield return new WaitForSeconds(10);
        // Enable navigation component
        gameObject.GetComponent<UserControlAI>().enabled = true;
    }

    void Update()
    {
        // If bot is traveling to waypoint set 1...
        if (goingToWaypointSet == 1)
        {
            // If waypointSet1Selection is 1 ...
            if (waypointSet1Selection == 1)
            {
                // Go to waypoint1_1
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_1.transform;
            }
            // If waypointSet1Selection is 2 ...
            else if (waypointSet1Selection == 2)
            {
                // Go to waypoint1_2
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_2.transform;
            }
            // If waypointSet1Selection is 3 ...
            else if (waypointSet1Selection == 3)
            {
                // Go to waypoint1_3
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_3.transform;
            }
            // If waypointSet1Selection is 4 ...
            else if (waypointSet1Selection == 4)
            {
                // Go to waypoint1_4
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_4.transform;
            }
        }
        // If bot is traveling to waypoint set 2...
        else if (goingToWaypointSet == 2)
        {
            // If waypointSet2Selection is 1 ...
            if (waypointSet2Selection == 1)
            {
                // Go to waypoint2_1
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint2_1.transform;
            }
            // If waypointSet2Selection is 2 ...
            else if (waypointSet2Selection == 2)
            {
                // Go to waypoint2_2
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint2_2.transform;
            }
            // If waypointSet2Selection is 3 ...
            else if (waypointSet2Selection == 3)
            {
                // Go to waypoint2_3
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint2_3.transform;
            }
            // If waypointSet2Selection is 4 ...
            else if (waypointSet2Selection == 4)
            {
                // Go to waypoint2_4
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint2_4.transform;
            }
        }
        // If bot is traveling to waypoint set 3...
        else if (goingToWaypointSet == 3)
        {
            // If waypointSet3Selection is 1 ...
            if (waypointSet3Selection == 1)
            {
                // Go to waypoint3_1
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint3_1.transform;
            }
            // If waypointSet3Selection is 2 ...
            else if (waypointSet3Selection == 2)
            {
                // Go to waypoint3_2
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint3_2.transform;
            }
            // If waypointSet3Selection is 3 ...
            else if (waypointSet3Selection == 3)
            {
                // Go to waypoint3_3
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint3_3.transform;
            }
            // If waypointSet3Selection is 4 ...
            else if (waypointSet3Selection == 4)
            {
                // Go to waypoint3_4
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint3_4.transform;
            }
        }
        // If bot is not going to waypoint set 1, 2, or 3, the bot is going to the goal
        else if (goingToWaypointSet == 4)
        {
            gameObject.GetComponent<UserControlAI>().moveTarget = goal.transform;
        }
        // Get distance to "moveTarget"
        float distanceToMoveTarget = Vector3.Distance(transform.position, gameObject.GetComponent<UserControlAI>().moveTarget.position);
        // If distance to "moveTarget" is less than 3, increase "goingToWaypointSet" by 1
        if (distanceToMoveTarget < 3f)
        {
            goingToWaypointSet += 1;
        }
    }
}
