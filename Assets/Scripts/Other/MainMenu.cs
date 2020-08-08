using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] private Slider musicSlider, effectsSlider;

    void Start()
    {
        if(GameObject.Find("Music: " + backgroundMusic.name) == null)
            AudioManager.Instance.PlayMusic(backgroundMusic);

        musicSlider.GetComponent<Sliders>().setSettings(); 
        effectsSlider.GetComponent<Sliders>().setSettings();
    }

    public void OpenMapScene()
    {
        SceneManager.LoadScene("Map");
    }

    public void ExitGame()
    {
    	Application.Quit();
    }
}