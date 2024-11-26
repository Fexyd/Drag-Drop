using UnityEngine;

public class MousePosition : MonoBehaviour
{
    public Vector3 CoordsConvertion;
    [SerializeField] private Vector3 ZPosition;

    private void Update()
    {
        ValorAsignation();
    }
    public Vector3 ScreenToWorldCoords(Vector3 ScreenPosition)
    {
        return Camera.main.ScreenToWorldPoint(ScreenPosition);
    }
    public void ValorAsignation() 
    {
        CoordsConvertion = ScreenToWorldCoords(Input.mousePosition);
        CoordsConvertion.z = ZPosition.z;
    }


}
