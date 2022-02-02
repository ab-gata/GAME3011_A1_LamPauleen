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
    // Stats
    private int playerScanCount = 6;
    private int playerExtractCount = 3;
    private float gold = 0;
    private float silver = 0;
    private float bronze = 0;

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
    [SerializeField]
    private TMPro.TextMeshProUGUI infoText;

    public void setScanMode()
    {
        currentMode = PlayerMode.SCAN;
        modeText.text = "MODE\nScan";
        infoText.text = "Scans Left [" + playerScanCount + "]";
    }
    public void setExtractMode()
    {
        currentMode = PlayerMode.EXTRACT;
        modeText.text = "MODE\nExtract";
        infoText.text = "Extracts Left [" + playerExtractCount + "]";
    }

    private void refreshResourceText()
    {
        resourceText.text = "RESOURCES\nGold [" + gold + "]\nSilver [" + silver + "]\nBronze [" + bronze + "]";
    }
    public bool canScan()
    {
        if (playerScanCount > 0)
        {
            playerScanCount--;
            infoText.text = "Scans Left [" + playerScanCount + "]";
            return true;
        }
        return false;
    }

    public bool canExtract()
    {
        if (playerExtractCount > 0)
        {
            playerExtractCount--;
            infoText.text = "Extracts Left [" + playerExtractCount + "]";
            return true;
        }
        return false;
    }

    public void extract(Metal m, Cut c)
    {
        // set resource value
        float value = 1.0f; 
        if (c == Cut.HALF)
        {
            value = 0.5f;
        }
        else if (c == Cut.QUARTER)
        {
            value = 0.25f;
        }

        //Add to player's resource count
        if (m == Metal.GOLD)
        {
            gold += value;
        }
        else if (m == Metal.SILVER)
        {
            silver += value;
        }
        else if (m == Metal.BRONZE)
        {
            bronze += value;
        }

        // refresh text
        refreshResourceText();
    }
}
