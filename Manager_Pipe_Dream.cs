using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_Pipe_Dream : MonoBehaviour
{
    public AudioSource roundIntroductionAudio;
    public AudioSource surviveTheFallAudio;
    public int numQualified = 0;
    public int maxQualified = 12;
    public Text numQualifiedText;
    public GameObject characterCamera;
    public GameObject startGuard;
    public GameObject goalCube;
    public GameObject deathCube;

    // Start is called before the first frame update
    void Start()
    {
        // Start "play" coroutine
        StartCoroutine("play");
    }

    IEnumerator play()
    {
        // Play round introduction audio
        roundIntroductionAudio.Play();
        // Wait 10 seconds
        yield return new WaitForSeconds(10);
        // Play race audio
        surviveTheFallAudio.Play();
        // Disable start guard
        startGuard.SetActive(false);
    }

    void Update()
    {
        // Update number qualified int
        numQualified = goalCube.GetComponent<GoalCube>().numQualified;
        // Update number qualified UI 
        numQualifiedText.text = numQualified.ToString();
        // if number qualified is greater than or equal to the maximum number of qualifiers...
        if (numQualified >= maxQualified)
        {
            // Player did not make it to the goal line in time. Player is eliminated.
            // Switch scene to Eliminated
            SceneManager.LoadScene("Eliminated");
        }
        // if player camera does not exist in scene...
        if (GameObject.Find("Character Camera") == null)
        {
            // if player has been eliminated by the death cube...
            if (deathCube.GetComponent<Death_Cube>().player_eliminated == true)
            {
                // Player fell to their death. Player is eliminated.
                SceneManager.LoadScene("Eliminated");
            }
            else
            {
                // Player made it to the goal line in time. Player is qualified.
                // Switch scene to Qualified_Round1
                SceneManager.LoadScene("Qualified_Round2");
            }
        }
    }
}
