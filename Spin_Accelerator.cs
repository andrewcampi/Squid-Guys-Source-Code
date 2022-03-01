using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin_Accelerator : MonoBehaviour
{
    public float startingAndCurrentSpinSpeed = 25f;
    public float finalSpinSpeed = 150f;
    public bool startSpinning = false;
    // Next update in second
    private int nextUpdate = 1;

    public void Start()
    {
        // Start coroutine "play"
        StartCoroutine("play");
    }

    IEnumerator play()
    {
        // At start, bot waits for "go"
        yield return new WaitForSeconds(10);
        // Start spinning
        startSpinning = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (startSpinning == true)
        {
            // If the next update is reached
            if (Time.time >= nextUpdate)
            {
                // Change the next update (current second+1)
                nextUpdate = Mathf.FloorToInt(Time.time) + 1;
                // Call your fonction
                UpdateEverySecond();
            }
        }
    }

    // Update is called once per second
    void UpdateEverySecond()
    {
        // While current speed is less than final speed
        if (finalSpinSpeed >= startingAndCurrentSpinSpeed)
        {
            // Make the spin go faster
            startingAndCurrentSpinSpeed += 4f;
        }
        // Update spin speed
        gameObject.GetComponent<Rotation_script>()._rotation = new Vector3(0f, startingAndCurrentSpinSpeed, 0f);
    }
}
