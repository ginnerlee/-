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
        // 如果在 Unity 編輯器中運行，停止播放模式
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // 如果在構建後運行，退出應用程序
            Application.Quit();
#endif
    }
}
