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

    private Grid.PieceType type_;//��ƫʸˡA�����鷺���ƭ�

    public Grid.PieceType Type//property �`�����ΡA�ñ���ۤ@�Өp�Ϊ����C
    {
        get { return type_; }
    }

    private Grid grid_;

    public Grid GridRef
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Piece�ܶq��l��
    public void Init(int _x,int _y, Grid _grid, Grid.PieceType _type) 
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

    //�˴�����O�_����
    public bool IsMovable()
    {
        return movableComponent!=null; //���Ovoid���ܴN������return�^�ǭ�
    }

    //�ˬd�C��
    public bool IsColored()
    {
        return colorComponent!=null;
    }

    public bool IsClearble()
    {
        return clearableComponent_!= null;
    }

}
