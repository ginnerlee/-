using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearLinePiece : ClearablePiece//��M������u���}���@��Clearablepiece����k���@�A���}���|�~��Clearablepiece���Ҧ��\��A�P�ɲM������u
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
        base.Clear();//������쥻��Clear���禡�A�p�G���gbase���ܴN�|�����мg

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
