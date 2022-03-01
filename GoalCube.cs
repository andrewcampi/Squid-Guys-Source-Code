using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCube : MonoBehaviour
{
    public int numQualified = 0;

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        // If guy collides with goal cube ...
        if (collision.gameObject.name == "mixamorig:Spine1")
        {
            // Destroy guy entirely
            Destroy(collision.gameObject.transform.parent.parent.parent.gameObject);
            // Add 1 to qualified
            numQualified += 1;
        }
    }
}
