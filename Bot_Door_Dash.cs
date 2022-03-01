using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.Demos;

public class Bot_Door_Dash : MonoBehaviour
{
    public GameObject waypoint1_1;
    public GameObject waypoint1_2;
    public GameObject waypoint1_3;
    public GameObject waypoint1_4;
    public GameObject waypoint1_5;
    public GameObject waypoint1_6;
    public GameObject waypoint2_1;
    public GameObject waypoint2_2;
    public GameObject waypoint2_3;
    public GameObject waypoint2_4;
    public GameObject waypoint2_5;
    public GameObject waypoint3_1;
    public GameObject waypoint3_2;
    public GameObject waypoint3_3;
    public GameObject waypoint3_4;
    public GameObject waypoint4_1;
    public GameObject waypoint4_2;
    public GameObject waypoint4_3;
    public GameObject waypoint5_1;
    public GameObject waypoint5_2;
    public GameObject goal;
    public int goingToWaypointSet = 1;
    public int waypointSet1Selection = 1;
    public int waypointSet2Selection = 1;
    public int waypointSet3Selection = 1;
    public int waypointSet4Selection = 1;
    public int waypointSet5Selection = 1;

    void Start()
    {
        // Pick a random waypoint for set 1 (1-6)
        waypointSet1Selection = Random.Range(1, 7);
        // Pick a random waypoint for set 2 (1-5)
        waypointSet2Selection = Random.Range(1, 6);
        // Pick a random waypoint for set 3 (1-4)
        waypointSet3Selection = Random.Range(1, 5);
        // Pick a random waypoint for set 4 (1-3)
        waypointSet4Selection = Random.Range(1, 4);
        // Pick a random waypoint for set 5 (1-2)
        waypointSet5Selection = Random.Range(1, 3);
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
            // If waypointSet1Selection is 5 ...
            else if (waypointSet1Selection == 5)
            {
                // Go to waypoint1_5
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_5.transform;
            }
            // If waypointSet1Selection is 6 ...
            else if (waypointSet1Selection == 6)
            {
                // Go to waypoint1_6
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint1_6.transform;
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
            // If waypointSet2Selection is 5 ...
            else if (waypointSet2Selection == 5)
            {
                // Go to waypoint2_5
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint2_5.transform;
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
        // If bot is traveling to waypoint set 4...
        else if (goingToWaypointSet == 4)
        {
            // If waypointSet3Selection is 1 ...
            if (waypointSet4Selection == 1)
            {
                // Go to waypoint4_1
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint4_1.transform;
            }
            // If waypointSet4Selection is 2 ...
            else if (waypointSet4Selection == 2)
            {
                // Go to waypoint4_2
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint4_2.transform;
            }
            // If waypointSet4Selection is 4 ...
            else if (waypointSet4Selection == 3)
            {
                // Go to waypoint4_3
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint4_3.transform;
            }
        }
        // If bot is traveling to waypoint set 5...
        else if (goingToWaypointSet == 5)
        {
            // If waypointSet5Selection is 1 ...
            if (waypointSet5Selection == 1)
            {
                // Go to waypoint5_1
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint5_1.transform;
            }
            // If waypointSet5Selection is 2 ...
            else if (waypointSet5Selection == 2)
            {
                // Go to waypoint4_2
                gameObject.GetComponent<UserControlAI>().moveTarget = waypoint5_2.transform;
            }
        }
        // If bot is not going to waypoint set 1, 2, 3, 4, or 5, the bot is going to the goal
        else if (goingToWaypointSet == 6)
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
