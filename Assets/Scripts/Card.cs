using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public bool isEnable;
    [SerializeField] private GameObject blackImg;
    [SerializeField] private Image cardImage;
    private Sprite _sprite;
    private string _value;
    private bool _isOpen;
    private Image _cellImage;
    private Collider2D _tileCollider;
    private int layer;

    public void SetCard(Sprite sprite, string value)
    {
        _sprite = sprite;
        _value = value;
        cardImage.sprite = _sprite;
    }
    public string GetValue()
    {
        return _value;
    }
    private void SetCardDisable()
    {
        cardImage.enabled = false;
        _cellImage.enabled = false;
    }
    private void SetBlackImg(bool value)
    {
        blackImg.SetActive(value);
    }
    private void OpenCheck()
    {
        /*
         1) проверка есть ли сверху карта
        2) проверка есть ли справа и слева карты
        1 или 2 то затемнить и _isOpen = false;
        иначе _isOpen = true;
         */
        if (!IsTileOpen()) SetBlackImg(true); 
    }
    private bool IsTileOpen()
    {
        //Vector2 checkPos = transform.localPosition;// + Vector3.up * 0.5f ;
        //Debug.Log(transform.localPosition);

        //Vector2 checkSize = new Vector2(50f,50f);
        // Debug.Log(Physics2D.OverlapBox(checkPos, _tileCollider.bounds.size, 0));
        /*     if (Physics2D.OverlapBox(checkPos, _tileCollider.bounds.size, 0) == null) return true;
            return false;
        /* Collider2D overlap = Physics2D.OverlapBox(checkPos, _tileCollider.bounds.size, 0);
        //Debug.Log(Physics2D.OverlapCollider(_tileCollider));
          return overlap == null || overlap.gameObject == this;
         Collider2D[] overlaps = Physics2D.OverlapBoxAll(checkPos, _tileCollider.bounds.size, 0);
         Debug.Log(overlaps.Length);
         return overlaps.Length  <= 1;*/
        
        //int layer = LayerMask.GetMask("Lvl_2","Lvl_3");
        //Debug.Log(transform.localPosition);
        //Debug.Log(_tileCollider.bounds.size);
        //Debug.Log(transform.position);
        //Collider2D hit = Physics2D.OverlapBox(transform.position,_tileCollider.bounds.size,0, layer);
        //if(hit != null)Debug.Log(hit.gameObject.name);
        Collider2D[] list = new Collider2D[10];
        ContactFilter2D contactFilter2D = new ContactFilter2D();
        contactFilter2D.SetLayerMask(layer);
        contactFilter2D.useLayerMask = true;
        int hit = Physics2D.OverlapCollider(_tileCollider, contactFilter2D, list);
        //if (hit > 0) Debug.Log(hit);
        return hit < 1;
       
    }
    private void UpdateCollider(GameObject tile)
    {
        var collider = tile.GetComponent<BoxCollider2D>();
        var rect = tile.GetComponent<RectTransform>().rect;
        collider.size = new Vector2(rect.width, rect.height);
    }
    private void Awake() => _cellImage = GetComponent<Image>();
    
    /*
    поля спрайт, значение, (ид)
    метод нажатия 

    (подумать как можно правильно зарефакторить код, что бы можно было добавлять данные - например звук)
    */
    void Start()
    {
        Canvas.ForceUpdateCanvases();
        layer = LayerMask.GetMask(GetComponentInParent<CellCollector>().GetLayer());
        //LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponentInParent<GridLayoutGroup>().GetComponent<RectTransform>());
        _tileCollider = GetComponent<Collider2D>();
        //UpdateCollider(this.gameObject);
        OpenCheck();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
