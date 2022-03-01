using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_MainMenu : MonoBehaviour
{
    public AudioSource themeAudio;
    public AudioSource excitedYellAudio;
    public AudioSource loadingAudio;
    public Image blackBackground;
    public Image bigLogo;
    public Image logoImage;
    public GameObject loadingCircles;
    public Button startButton;
    public GameObject startButtonGameObject;
    public GameObject idleSquidGuy;
    public GameObject stretchingSquidGuy;
    public Image whirligigLoadingScreen;

    // Start is called before the first frame update
    void Start()
    {
        // Play theme music
        themeAudio.Play();
        // Start coroutine "play"
        StartCoroutine("play");
        // Get ready to click start
        Button btn = startButton.GetComponent<Button>();
        btn.onClick.AddListener(pressStart);
    }

    IEnumerator play()
    {
        // Show the initial loading screen and hide everything else
        bigLogo.enabled = true;
        blackBackground.enabled = true;
        loadingCircles.SetActive(true);
        startButton.enabled = false;
        startButtonGameObject.SetActive(false);
        logoImage.enabled = false;
        whirligigLoadingScreen.enabled = false;
        // Wait for beat drop
        yield return new WaitForSeconds(12); //12
        // Hide the intial loading screen and show everything else
        bigLogo.enabled = false;
        blackBackground.enabled = false;
        loadingCircles.SetActive(false);
        startButton.enabled = true;
        startButtonGameObject.SetActive(true);
        logoImage.enabled = true;
        //Show the idle squid guy and hide the streching squid guy
        idleSquidGuy.SetActive(true);
        stretchingSquidGuy.SetActive(false);

    }

    public void pressStart()
    {
        StartCoroutine("pressStart2");
    }

    IEnumerator pressStart2()
    {
        // Play exctied yell audio
        excitedYellAudio.Play();
        // Hide the start button and logo
        startButton.enabled = false;
        startButtonGameObject.SetActive(false);
        logoImage.enabled = false;
        // Hide the idle squid guy and show the streching squid guy
        idleSquidGuy.SetActive(false);
        stretchingSquidGuy.SetActive(true);
        // Show the loading circles
        loadingCircles.SetActive(true);
        // Wait 8 seconds for guy to strech
        yield return new WaitForSeconds(8);
        // Stop the theme music
        themeAudio.Stop();
        // Play the loading music
        loadingAudio.Play();
        // Select a map and show its loading screen
        StartCoroutine("selectMap");
    }

    public IEnumerator selectMap()
    {
        // (Only 1 map to select as of now)
        // Show whirligig loading screen
        whirligigLoadingScreen.enabled = true;
        // Wait for 10 seconds while loading audio plays
        yield return new WaitForSeconds(10);
        // Switch scene to whirligig
        SceneManager.LoadScene("Whirligig");
    }
}
