using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Exit()
    {
#if UNITY_EDITOR
        // �p�G�b Unity �s�边���B��A�����Ҧ�
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // �p�G�b�c�ث�B��A�h�X���ε{��
            Application.Quit();
#endif
    }
}
