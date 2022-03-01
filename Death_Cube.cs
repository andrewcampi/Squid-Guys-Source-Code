using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_Cube : MonoBehaviour
{
    public bool player_eliminated = false;
    public int guys_eliminated = 0;

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        // If guy collides with goal cube ...
        if (collision.gameObject.name == "mixamorig:Spine1")
        {
            // If collied with player
            if (collision.gameObject.transform.parent.parent.parent.gameObject.name == "Third_Person_Puppet")
            {
                // mark player as eliminated
                player_eliminated = true;
            }
            // Destroy guy entirely
            Destroy(collision.gameObject.transform.parent.parent.parent.gameObject);
            // Add 1 to guys_eliminated
            guys_eliminated += 1;
        }
    }
}
