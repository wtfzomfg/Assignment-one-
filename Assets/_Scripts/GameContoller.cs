using UnityEngine;
using System.Collections;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

[System.Serializable]
public class End
{
public bool dead;
}


public class GameContoller : MonoBehaviour {

    // PUBLIC INSTANCE VARIABLES
    public int TerrainCount;
    public GameObject Terrain;

    public int PickUpCount;
    public GameObject PickUp;

    // Use this for initialization
    void Start()
    {
        
        this._GenerateTerrain();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))//input is "press "r" for restart
        {
            Debug.Log("Restarted!");// for console input to see if it was working
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    // generate Terrain
    private void _GenerateTerrain()
    {
        for (int count = 0; count < this.TerrainCount; count++)
        {
            Instantiate(Terrain);
        }
    }
    // generate Pick ups
    private void _GeneratePickUp()
    {
        for (int count = 0; count < this.PickUpCount; count++)
        {
            Instantiate(PickUp);
        }
    }
}//Jefferson Chin 300787653 COMP305 
