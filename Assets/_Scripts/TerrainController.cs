using UnityEngine;
using System.Collections;



public class TerrainController : MonoBehaviour {
    // PUBLIC INSTANCE VARIABLES
    public float speed;
    public Boundary boundary;

    // PRIVATE INSTANCE VARIABLES

    // Use this for initialization
    void Start()
    {
        this._Reset();// at the very start of the game all fire boars and bunnys won't be able to spawn in the middle of the screen
    }

    // Update is called once per frame
    void Update () {
        Vector2 currentPosition = gameObject.GetComponent<Transform>().position;

        currentPosition.x -= speed;
        gameObject.GetComponent<Transform>().position = currentPosition;

        // Check Left boundary
        if (currentPosition.x <= boundary.xMin)
        {
            this._Reset();// Reset makes the objects go back to right side of the screen 
        }
    }
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2( boundary.xMax, Random.Range(boundary.yMin, boundary.yMax));//This makes it spawn on the xMax(-80) always and random on the Y (from its min (-150) to its max (150)
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}//Jefferson Chin 300787653 COMP305 
