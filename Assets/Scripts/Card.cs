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
    private void Awake() => _cellImage = GetComponent<Image>();
    
    /*
    поля спрайт, значение, (ид)
    метод нажатия 

    (подумать как можно правильно зарефакторить код, что бы можно было добавлять данные - например звук)
    */
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
