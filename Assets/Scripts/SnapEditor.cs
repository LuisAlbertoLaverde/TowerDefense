using UnityEngine;


[ExecuteInEditMode]
public class SnapEditor : MonoBehaviour
{
    void Update()
    {
        float sizeX = transform.localScale.x;
        float sizeZ = transform.localScale.z;
        float positionX = transform.localPosition.x;
        float positionZ = transform.localPosition.z;

        float PositionSnapX = Mathf.RoundToInt(positionX / sizeX) * sizeX;
        float PositionSnapZ = Mathf.RoundToInt(positionZ / sizeZ) * sizeZ;

        transform.localPosition = new Vector3(PositionSnapX, transform.localPosition.y, PositionSnapZ);
    }
}
