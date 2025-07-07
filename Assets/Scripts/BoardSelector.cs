using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
namespace Board
{
    public class BoardSelector : MonoBehaviour
    {
        [SerializeField] private Camera camera;
        [SerializeField] private int matchNumber;

        private List<Tile.Tile> _selectedTiles = new List<Tile.Tile>();

        void Update()
        {
            if(Input.GetMouseButtonDown(0))
            {
                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                if(Physics.Raycast(ray,out RaycastHit hit))
                {
                    Tile.Tile tile = hit.collider.GetComponent<Tile.Tile>();
                    //if(boardmatcher.canBeSelected())
                    SelectedTile(tile);
                }
                else UnselectTiles();
            }
        }

        private void SelectedTile(Tile.Tile tile)
        {
            if (_selectedTiles.Count == matchNumber && !_selectedTiles.Contains(tile))
                    UnselectTiles();

            if (!_selectedTiles.Contains(tile))
            {
                _selectedTiles.Add(tile);
                tile.Selected(true);
            }
            else
            {
                _selectedTiles.Remove(tile);
                tile.Selected(false);
            }
            if (_selectedTiles.Count == matchNumber)
                MatchTiles();
        }
        private void MatchTiles()
        {
            /*if(boardMatcher.Match(_selectedTiles)) проверка на одинаковость
             
             else UnselectTiles(); */
        }
        private void UnselectTiles()
        {
            foreach(Tile.Tile t in _selectedTiles)
            {
                t.Selected(false);
            }
            _selectedTiles.Clear();
        }
        public void ShowHint()
        {
            /*List<Tile.Tile> match = _boardMatcher.GetPossibleMatch();
            if(match.Count > 0)
            {
                foreach (Tile.Tile t in match)
                    t.SetHint();
            }*/
        }
    }
}
