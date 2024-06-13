using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLinePiece : ClearablePiece//把清除整條線的腳本作為Clearablepiece的方法之一，此腳本會繼承Clearablepiece的所有功能，同時清除整條線
{
    public bool isRow;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Clear()
    {
        base.Clear();//先執行原本的Clear的函式，如果不寫base的話就會直接覆寫

        if (isRow )//Clear row
        {
            piece.GridRef.ClearRow(piece.Y);
        }
        else//Clear column
        {
            piece.GridRef.ClearColumn(piece.X);
        }
    }
}
