using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellCollector : MonoBehaviour
{
    private List<GameObject> cells = new List<GameObject>();
    void Start()
    {
        GetAllCells();
    }
    private void GetAllCells()
    {
        cells.Clear();
        foreach (Transform child in transform)
        {
            cells.Add(child.gameObject);
        }
    }
    public List<GameObject> GetCells()
    {
        return cells;
    }
   
}
