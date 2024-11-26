using UnityEngine;

public class CollisionHandle : MonoBehaviour
{
    //Variables
    public bool IsColliding;
    public Collider2D DetectedObject;


    public bool CollisionDetectation(Vector3 Coords) 
    {
        DetectedObject = Physics2D.OverlapPoint(Coords);

        if (DetectedObject != null) 
        {
            return IsColliding = true;
        }
        else
        {
            return IsColliding = false;
        }
    }
}