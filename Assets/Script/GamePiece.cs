using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiece : MonoBehaviour
{
    private int x_;
    private int y_;

    public int X
    {
        get { return x_; }
        set
        {
            if (IsMovable()) 
            {
                x_ = value;
            }
        }
    }

    public int Y
    {
        get { return y_; }
        set
        {
            if (IsMovable())
            {
                y_= value;
            }
        }
    }

    private GameGrid.PieceType type_;//資料封裝，限制更改內部數值

    public GameGrid.PieceType Type//property 常為公用，並控制著一個私用的欄位。
    {
        get { return type_; }
    }

    private GameGrid grid_;

    public GameGrid GridRef
    {
        get { return grid_; }
    }

    private MoveablePiece movableComponent;

    public MoveablePiece MovableComponent
    {
        get { return movableComponent;}
    }

    private ColorPiece colorComponent;

    public ColorPiece ColorComponent
    {
        get { return colorComponent; }
    }

    private ClearablePiece clearableComponent_;

    public ClearablePiece ClearableComponent
    {
        get { return clearableComponent_; }
    }

    void Awake()
    {
        movableComponent = GetComponent<MoveablePiece>();
        colorComponent = GetComponent<ColorPiece>();
        clearableComponent_ = GetComponent<ClearablePiece>();
    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    //Piece變量初始化
    public void Init(int _x,int _y, GameGrid _grid, GameGrid.PieceType _type) 
    {
        x_ = _x;
        y_ = _y;
        grid_ = _grid;
        type_ = _type;
    }

    void OnMouseEnter()
    {
        grid_.EnterPiece(this);
    }

    void OnMouseDown()
    {
        grid_.PressPiece(this);
    }

    void OnMouseUp()
    {
        grid_.ReleasePiece();
    }

    //檢測物件是否移動
    public bool IsMovable()
    {
        return movableComponent!=null; //不是void的話就必須用return回傳值
    }

    //檢查顏色
    public bool IsColored()
    {
        return colorComponent!=null;
    }

    public bool IsClearble()
    {
        return clearableComponent_!= null;
    }

}
