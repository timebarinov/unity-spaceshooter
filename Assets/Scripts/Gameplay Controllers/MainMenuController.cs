using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    [SerializeField]
    private Canvas mainMenuCanvas, highscoreCanvas, controlsCanvas;

    [SerializeField]
    private Text shipsDestroyedHighscore, meteorsDestroyedHighscore, wavesSurvivedHighscore;

    public void PlayGame()
    {
        SceneManager.LoadScene(TagManager.GAMEPLAY_LEVEL_NAME);
    }

    public void OpenCloseHighscoreCanvas(bool open)
    {
        mainMenuCanvas.enabled = !open;
        highscoreCanvas.enabled = open;

        if (open)
            DisplayHighscore();
    }

    public void OpenCloseControlsCanvas(bool open)
    {
        mainMenuCanvas.enabled = !open;
        controlsCanvas.enabled = open;
    }

    void DisplayHighscore()
    {
        shipsDestroyedHighscore.text = "x" + DataManager.GetData(TagManager.SHIPS_DESTROYED_DATA);
        meteorsDestroyedHighscore.text = "x" + DataManager.GetData(TagManager.METEORS_DESTROYED_DATA);
        wavesSurvivedHighscore.text = "Waves Survived: " + DataManager.GetData(TagManager.WAVE_NUMBER_DATA);
    }
} // class
