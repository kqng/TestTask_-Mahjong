using Board;
using Board.Tile;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Boat {
    public class BoardMatcher : MonoBehaviour
    {
        /* boardCreator получить инфу о доске*/
        private BoardSelector _boardSelector;

        private void Awake()
        {

        }
        public bool CanBeSelected(Tile tile)
        {
            TileIndex index = tile.Index;

            GetNeighbours(index, out Tile top, out Tile right, out Tile left);

            if (!top && (!right || !left)) 
                return true;

            return false;
        }

        private void GetNeighbours(TileIndex index, out Tile top, out Tile right, out Tile left)
        {
            /*boardCreator  - инфа о тайлах
             и о количестве тайлов*/
            top = null;
            right = null;
            left = null;


            /*if (ti.floor < (int)boardSize.z - 1)
                top = boardTiles[ti.x, ti.y, ti.floor + 1];

            if (ti.x > 0)
                left = boardTiles[ti.x - 1, ti.y, ti.floor];

            if (ti.x < (int)boardSize.x - 1)
                right = boardTiles[ti.x + 1, ti.y, ti.floor];*/
        }
    } 
}
