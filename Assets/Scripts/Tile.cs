using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Board.Tile
{
    public class Tile : MonoBehaviour
    {
        [SerializeField] private Color selected;
        [SerializeField] private Color unselected;
        [SerializeField] private Color hint;
        [SerializeField] private GameObject card;

        private SpriteRenderer _spriteRenderer;

        private void Awake() 
        {
             _spriteRenderer = card.GetComponent<SpriteRenderer>();
        }
        private void Start()
        {
            Selected(false);
        }
        public void Selected(bool value)
        {
            _spriteRenderer.color = value ? selected : unselected;
        }
        public void SetHint()
        {
            _spriteRenderer.color = hint;
        }
        public void SetImage(Sprite sprite)
        {
            _spriteRenderer.sprite = sprite;
        }

        public TileIndex Index { get; set; }
    }
}
