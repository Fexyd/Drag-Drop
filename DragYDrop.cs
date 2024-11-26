using Unity.VisualScripting;
using UnityEngine;


public class DragYDrop : MonoBehaviour
{
    // Reference of Classes
    private MoveObject CMoveObject;
    private MousePosition CMousePosition;
    private CollisionHandle CCollisionHandle;


    private void Awake()
    {
         CMousePosition = GetComponent<MousePosition>();
         CCollisionHandle = GetComponent<CollisionHandle>();
         CMoveObject = GetComponent<MoveObject>();
    }
    private void Update()
    {

        CCollisionHandle.CollisionDetectation(CMousePosition.CoordsConvertion);

        if (Input.GetKey(KeyCode.Mouse0))
        {
            CMoveObject.HandleMovent(true, CMousePosition.CoordsConvertion);
        }
        else
        {
            CMoveObject.HandleMovent(false, CMousePosition.CoordsConvertion);
        }

    }

}



