using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellCollector : MonoBehaviour
{
    [SerializeField] private string layer;
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
    public string GetLayer()
    {
        return layer;
    }
    public List<GameObject> GetCells()
    {
        return cells;
    }
   
}
