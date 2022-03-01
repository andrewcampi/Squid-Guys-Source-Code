using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.Demos;

public class Bot_Jump_Club : MonoBehaviour
{
    public GameObject waypoint1_1;
    public GameObject waypoint1_2;
    public GameObject waypoint1_3;
    public GameObject waypoint1_4;
    public GameObject waypoint1_5;
    public GameObject waypoint1_6;
    public int waypointSet1Selection = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random waypoint for set 1 (1-6)
        waypointSet1Selection = Random.Range(1, 7);
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

    // Update is called once per frame
    void Update()
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
        // Get distance to "moveTarget"
        float distanceToMoveTarget = Vector3.Distance(transform.position, gameObject.GetComponent<UserControlAI>().moveTarget.position);
        // If distance to "moveTarget" is less than 3, pick a new waypoint in set 1
        if (distanceToMoveTarget < 3f)
        {
            waypointSet1Selection = Random.Range(1, 7);
        }
    }
}
