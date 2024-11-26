using Unity.VisualScripting;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    //References of classes
    private CollisionHandle CCollisionHandle;

    //Variables
    public Vector3 Mouse_Position;

    private void Awake()
    {
        CCollisionHandle = GetComponent<CollisionHandle>();;
    }


    public void HandleMovent(bool CanMove, Vector3 ConversionCoords) 
    {
        if (CanMove == true && CCollisionHandle.DetectedObject != null)
        {
            CCollisionHandle.DetectedObject.transform.position = ConversionCoords;
        }
    }
}
