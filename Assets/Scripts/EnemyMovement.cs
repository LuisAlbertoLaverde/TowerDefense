using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Cell> m_Road;
    void Start()
    {
        PrintRoad();
    }

    void PrintRoad()
    {
        foreach (Cell cell in m_Road)
        {
            print(cell.gameObject.name);
        }
    }

}
