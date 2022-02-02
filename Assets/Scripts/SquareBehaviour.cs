using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public enum Cut
{
    NONE,
    FULL,
    HALF,
    QUARTER
}

[System.Serializable]
public enum Metal
{
    NONE,
    GOLD,
    SILVER,
    BRONZE
}

public class SquareBehaviour : MonoBehaviour
{
    [SerializeField]
    private Color goldColour;
    [SerializeField]
    private Color goldColour1;
    [SerializeField]
    private Color goldColour2;
    [SerializeField]
    private Color silverColour;
    [SerializeField]
    private Color silverColour1;
    [SerializeField]
    private Color silverColour2;
    [SerializeField]
    private Color bronzeColour;
    [SerializeField]
    private Color bronzeColour1;
    [SerializeField]
    private Color bronzeColour2;

    private Color squareColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    private Vector2 positionVector = Vector2.zero;
    public Vector2 PositionVector { get { return positionVector; } }

    // The value of the resources in the square
    private Metal metal = Metal.NONE;
    private Cut cut = Cut.NONE;

    // Vector to keep track of the square's position in the grid
    public void setPositionVector(int x, int y)
    {
        positionVector = new Vector2(x, y);
    }

    public void setValue(Metal m, Cut c)
    {
        metal = m;
        cut = c;

        // Prepare the square's reveal colour
        if (metal == Metal.GOLD)
        {
            if (cut == Cut.FULL)
            {
                squareColor = goldColour;
            }
            else if (cut == Cut.HALF)
            {
                squareColor = goldColour1;
            }
            else if (cut == Cut.QUARTER)
            {
                squareColor = goldColour2;
            }
        }
        if (metal == Metal.SILVER)
        {
            if (cut == Cut.FULL)
            {
                squareColor = silverColour;
            }
            else if (cut == Cut.HALF)
            {
                squareColor = silverColour1;
            }
            else if (cut == Cut.QUARTER)
            {
                squareColor = silverColour2;
            }
        }
        if (metal == Metal.BRONZE)
        {
            if (cut == Cut.FULL)
            {
                squareColor = bronzeColour;
            }
            else if (cut == Cut.HALF)
            {
                squareColor = bronzeColour1;
            }
            else if (cut == Cut.QUARTER)
            {
                squareColor = bronzeColour2;
            }
        }
    }

    public void Reveal()
    {
        SquareBehaviour[] squares = FindObjectsOfType<SquareBehaviour>();

        foreach (var item in squares)
        {
            if (item.PositionVector.x >= (positionVector.x -2) && item.PositionVector.x <= (positionVector.x+2))
            {
                if (item.PositionVector.y >= (positionVector.y-2) && item.PositionVector.y <= (positionVector.y+2))
                {
                    item.GetComponent<Image>().color = item.squareColor;
                }
            }
            if (item.PositionVector.x >= (positionVector.x-1) && item.PositionVector.x <= (positionVector.x+1))
            {
                if (item.PositionVector.y >= (positionVector.y-1) && item.PositionVector.y <= (positionVector.y+1))
                {
                    item.GetComponent<Image>().color = item.squareColor;
                }
            }
        }
        gameObject.GetComponent<Image>().color = squareColor;
    }
}
