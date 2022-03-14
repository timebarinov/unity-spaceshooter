using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayUIController : MonoBehaviour
{

    public static GameplayUIController instance;

    [SerializeField]
    private Text waveInfoTxt, shipsDestroyedInfoTxt, meteorsDestroyedInfoTxt;

    private int waveCount, shipsDestroyedCount, meteorsDestroyedCount;

    private void Awake()
    {
        if(instance == null)
           instance = this;
    }

    public void SetWave()
    {
        waveCount++;
        waveInfoTxt.text = "Wave: " + waveCount;
    }

    public void SetShipsDestroyed()
    {
        shipsDestroyedCount++;
        shipsDestroyedInfoTxt.text = shipsDestroyedCount + "x";
    }

    public void SetMeteorsDestroyed()
    {
        meteorsDestroyedCount++;
        meteorsDestroyedInfoTxt.text = meteorsDestroyedCount + "x";
    }

    public int GetShipsDestroyedCount()
    {
        return shipsDestroyedCount;
    }

    public int GetMeteorsDestroyedCount()
    {
        return meteorsDestroyedCount;
    }

    public int GetWaveCount()
    {
        return waveCount;
    }

    public void SetInfo(int infoType)
    {
        switch (infoType)
        {

            case 1:
                waveCount++;
                waveInfoTxt.text = "Wave: " + waveCount;
                break;
                
            case 2:
                shipsDestroyedCount++;
                shipsDestroyedInfoTxt.text = shipsDestroyedCount + "x";
                break;

            case 3:
                meteorsDestroyedCount++;
                meteorsDestroyedInfoTxt.text = meteorsDestroyedCount + "x";
                break;

        }
    }

} // class
