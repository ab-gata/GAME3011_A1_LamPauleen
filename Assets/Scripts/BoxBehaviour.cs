using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    private Vector2 positionVector = Vector2.zero;

    private int value = 0;
    public int Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public void setPositionVector(int x, int y)
    {
        positionVector = new Vector2(x, y);
    }

    private void OnMouseDown()
    {
        Debug.Log(positionVector.x + ", " + positionVector.y);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
