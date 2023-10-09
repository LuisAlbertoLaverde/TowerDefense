using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Cell> m_Road;
    void Start()
    {
        StartCoroutine(PrintRoad());
    }

    IEnumerator PrintRoad()
    {
        print("Enemy siguiendo camino...");

        foreach (Cell cell in m_Road)
        {
            //print(cell.gameObject.name);
            transform.position = cell.transform.position;
            yield return new WaitForSeconds(1.0f);
            print($"Celda: {cell.gameObject.name}");
        }
        print("Enemigo llego al destino");
    }
}
