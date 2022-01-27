using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    [SerializeField]
    private int dimentions;

    [SerializeField]
    private float distanceBetween = 4;

    private int[,] gridArray;
    private List<BoxBehaviour> boxArray;

    // Start is called before the first frame update
    void Start()
    {
        gridArray = new int[dimentions, dimentions];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                GameObject temp = Instantiate(boxPrefab);
                temp.transform.parent = gameObject.transform;
                temp.transform.position = new Vector3(x * distanceBetween, y * distanceBetween, 0);
                temp.GetComponent<BoxBehaviour>().setPositionVector(x, y);
                Debug.Log("made a box");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
