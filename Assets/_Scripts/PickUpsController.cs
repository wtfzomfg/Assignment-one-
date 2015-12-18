using UnityEngine;
using System.Collections;

public class PickUpsController : MonoBehaviour
{
    // PUBLIC INSTANCE VARIABLES
    public float speed;
    public Boundary boundary;

    // PRIVATE INSTANCE VARIABLES

    // Use this for initialization
    void Start()
    {
        this._Reset();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = gameObject.GetComponent<Transform>().position;

        currentPosition.x -= speed;
        gameObject.GetComponent<Transform>().position = currentPosition;

        // Check Left boundary
        if (currentPosition.x <= boundary.xMin)
        {
            this._Reset();
        }
    }
    private void _Reset()
    {
        Vector2 resetPosition = new Vector2(boundary.xMax, Random.Range(boundary.yMin, boundary.yMax));//This makes it spawn on the xMax(-80) always and random on the Y (from its min (-150) to its max (150)
        gameObject.GetComponent<Transform>().position = resetPosition;
    }
}
