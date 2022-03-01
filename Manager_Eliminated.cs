using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager_Eliminated : MonoBehaviour
{
    public AudioSource eliminatedAudio;
    public AudioSource excitedYellAudio;
    public AudioSource loadingAudio;
    public Button mainMenuButton;
    public GameObject mainMenuButtonGameObject;
    public GameObject loadingCircles;
    public GameObject logo;
    public GameObject eliminatedText;
    public GameObject defeatGuy;
    public GameObject strechingGuy;

    // Start is called before the first frame update
    void Start()
    {
        // Play qualified music
        eliminatedAudio.Play();
        // Hide the loading circles
        loadingCircles.SetActive(false);
        // Get ready to click start
        Button btn = mainMenuButton.GetComponent<Button>();
        btn.onClick.AddListener(returnToMainMenu);
    }

    public void returnToMainMenu()
    {
        StartCoroutine("returnToMainMenu2");
    }

    IEnumerator returnToMainMenu2()
    {
        // Play exctied yell audio
        excitedYellAudio.Play();
        // Hide the main menu button, logo, and eliminated text
        mainMenuButton.enabled = false;
        mainMenuButtonGameObject.SetActive(false);
        logo.SetActive(false);
        eliminatedText.SetActive(false);
        // Hide the defeat guy and show the streching guy
        defeatGuy.SetActive(false);
        strechingGuy.SetActive(true);
        // Show the loading circles
        loadingCircles.SetActive(true);
        // Wait 4 seconds for guy to strech
        yield return new WaitForSeconds(4);
        // Play the loading music
        loadingAudio.Play();
        // Return to Main Menu
        SceneManager.LoadScene("MainMenu");
    }
}
