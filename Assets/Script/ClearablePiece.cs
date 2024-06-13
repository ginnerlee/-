using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearablePiece : MonoBehaviour
{
    public AnimationClip clearAnimation;

    private bool isBeingCleared=false;

    public bool IsBeingCleared
    {
        get { return isBeingCleared; } 
    }

    //**
    protected GamePiece piece;

    void Awake()
    {
      piece=GetComponent<GamePiece>();  
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Clear()//**在void前面加入virtual，表示這段程式碼允許在其他派生類別中被覆寫，好處是可以讓程式有更多擴展性和可維護性
    {
        isBeingCleared=true;
        StartCoroutine(ClearCoroutine());
    }

    //清除時播放動畫
    private IEnumerator ClearCoroutine()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play(clearAnimation.name);//播放動畫

            yield return new WaitForSeconds(clearAnimation.length);

            Destroy(gameObject);
        }
    }
}
