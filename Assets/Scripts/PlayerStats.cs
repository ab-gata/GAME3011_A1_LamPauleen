using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Enums for each player mode
[System.Serializable]
public enum PlayerMode
{
    SCAN,
    EXTRACT
}

public class PlayerStats : MonoBehaviour
{
    // Mode for click behaviour
    private PlayerMode currentMode = PlayerMode.SCAN;
    public PlayerMode CurrentMode { 
        get { return currentMode; }
    }

    // UI References
    [SerializeField]
    private TMPro.TextMeshProUGUI resourceText;
    [SerializeField]
    private TMPro.TextMeshProUGUI modeText;

    public void setScanMode()
    {
        currentMode = PlayerMode.SCAN;
        modeText.text = "MODE\nScan";
    }
    public void setExtractMode()
    {
        currentMode = PlayerMode.EXTRACT;
        modeText.text = "MODE\nExtract";
    }

}
