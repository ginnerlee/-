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

    public virtual void Clear()//**�bvoid�e���[�Jvirtual�A��ܳo�q�{���X���\�b��L�������O���Q�мg�A�n�B�O�i�H���{������h�X�i�ʩM�i���@��
    {
        isBeingCleared=true;
        StartCoroutine(ClearCoroutine());
    }

    //�M���ɼ���ʵe
    private IEnumerator ClearCoroutine()
    {
        Animator animator = GetComponent<Animator>();

        if (animator)
        {
            animator.Play(clearAnimation.name);//����ʵe

            yield return new WaitForSeconds(clearAnimation.length);

            Destroy(gameObject);
        }
    }
}
