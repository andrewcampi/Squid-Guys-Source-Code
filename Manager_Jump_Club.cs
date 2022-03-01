using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_Jump_Club : MonoBehaviour
{
    public AudioSource roundIntroductionAudio;
    public AudioSource fallForTheTeamAudio;
    public int numEliminated = 0;
    public int maxEliminated = 6;
    public Text numEliminatedText;
    public GameObject characterCamera;
    public GameObject startGuard;
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
        fallForTheTeamAudio.Play();
        // Disable start guard
        startGuard.SetActive(false);
    }

    void Update()
    {
        // Update number eliminated int
        numEliminated = deathCube.GetComponent<Death_Cube>().guys_eliminated;
        // Update number eliminated UI 
        numEliminatedText.text = numEliminated.ToString();
        // if number eliminated is greater than or equal to the maximum number of guys eliminated...
        if (numEliminated >= maxEliminated)
        {
            // Player survived long enough. Player is qualified
            // Switch scene to Eliminated
            SceneManager.LoadScene("Qualified_Round3");
        }
        // if player camera does not exist in scene...
        if (GameObject.Find("Character Camera") == null)
        {
            // Player fell to their death. Player is eliminated.
            SceneManager.LoadScene("Eliminated");
        }
    }
}
