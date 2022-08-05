using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour
{
    // Assign Cube1 to this variable GO before running the example
    public GameObject GO;

    void Awake()
    {
        Debug.Log("Example2.Awake() was called");
    }

    void Start()
    {
        Debug.Log("Example2.Start() was called");
    }

    // track if Cube1 was already activated
    private bool activateGO = true;

    void Update()
    {
        if (activateGO == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("space key was pressed");
                GO.SetActive(true);
                activateGO = false;
            }
        }
    }
}
