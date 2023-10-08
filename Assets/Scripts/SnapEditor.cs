using TMPro;
using UnityEngine;


[ExecuteInEditMode]
public class SnapEditor : MonoBehaviour
{
    TextMeshPro m_TextMeshPro;
    private void Start()
    {
        m_TextMeshPro = GetComponentInChildren<TextMeshPro>();
    }
    void Update()
    {
        float sizeX = transform.localScale.x;
        float sizeZ = transform.localScale.z;
        float positionX = transform.localPosition.x;
        float positionZ = transform.localPosition.z;

        float PositionSnapX = Mathf.RoundToInt(positionX / sizeX) * sizeX;
        float PositionSnapZ = Mathf.RoundToInt(positionZ / sizeZ) * sizeZ;

        string cubeCoordinateText = $"{(PositionSnapX / sizeX).ToString()} , {(PositionSnapZ / sizeZ).ToString()}";
        m_TextMeshPro.text = cubeCoordinateText;
        gameObject.name = cubeCoordinateText;

        transform.localPosition = new Vector3(PositionSnapX, transform.localPosition.y, PositionSnapZ);
    }

}

