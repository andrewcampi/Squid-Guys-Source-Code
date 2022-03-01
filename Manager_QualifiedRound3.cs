using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_QualifiedRound3 : MonoBehaviour
{
    public AudioSource qualifiedAudio;
    public AudioSource excitedYellAudio;
    public AudioSource loadingAudio;
    public Button nextRoundButton;
    public GameObject nextRoundButtonGameObject;
    public GameObject loadingCircles;
    public GameObject logo;
    public GameObject qualifiedText;
    public GameObject victoryGuy;
    public GameObject strechingGuy;
    public GameObject jumpShowdownLoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        // Play qualified music
        qualifiedAudio.Play();
        // Hide the loading circles
        loadingCircles.SetActive(false);
        // Get ready to click start
        Button btn = nextRoundButton.GetComponent<Button>();
        btn.onClick.AddListener(pressNextRound);
    }

    public void pressNextRound()
    {
        StartCoroutine("pressNextRound2");
    }

    IEnumerator pressNextRound2()
    {
        // Play exctied yell audio
        excitedYellAudio.Play();
        // Hide the next round button, logo, and qualified text
        nextRoundButton.enabled = false;
        nextRoundButtonGameObject.SetActive(false);
        logo.SetActive(false);
        qualifiedText.SetActive(false);
        // Hide the victory guy and show the streching guy
        victoryGuy.SetActive(false);
        strechingGuy.SetActive(true);
        // Show the loading circles
        loadingCircles.SetActive(true);
        // Wait 4 seconds for guy to strech
        yield return new WaitForSeconds(4);
        // Play the loading music
        loadingAudio.Play();
        // Select a map and show its loading screen
        StartCoroutine("selectMap");
    }

    public IEnumerator selectMap()
    {
        // Round 4
        // (Only 1 map to select as of now)
        // Show Jump Showdown loading screen
        jumpShowdownLoadingScreen.SetActive(true);
        // Wait for 10 seconds while loading audio plays
        yield return new WaitForSeconds(10);
        // Switch scene to Jump Showdown
        SceneManager.LoadScene("Jump_Showdown");
    }
}
