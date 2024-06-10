using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPiece : MonoBehaviour
{
    public enum ColorType 
    {
        Yellow ,
        Purple ,
        Red,
        Blue,
        Green,
        Pink,
        Any,
        Count
    }

    [System.Serializable]
    public struct ColorSprite 
    {
        public ColorType color;
        public Sprite sprite;
    }


    public ColorSprite[] colorSprites;

    private ColorType color_;

    public ColorType Color 
    {
        get { return color_; }
        set { SetColor(value); }
    }

    public int NumColors
    {
        get { return colorSprites.Length; }
    }

    private SpriteRenderer sprite;
    private Dictionary<ColorType, Sprite> colorSpriteDict;//Dictionary字典功能

    void Awake()
    {
        sprite = transform.Find("piece").GetComponent<SpriteRenderer>();

        colorSpriteDict= new Dictionary<ColorType, Sprite>();//宣告Dictionary

        for (int i = 0; i < colorSprites.Length; i++)
        {
            if (!colorSpriteDict.ContainsKey(colorSprites[i].color))//ContainsKey跟Dictionary搭配使用，主要用來檢查
            {
                colorSpriteDict.Add(colorSprites[i].color, colorSprites[i].sprite);//Add最後加入
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetColor(ColorType newColor)
    {
        color_ = newColor;

        if (colorSpriteDict.ContainsKey(newColor)) 
        {
            sprite.sprite = colorSpriteDict[newColor];//指派保存新的顏色
        }
    }
}
