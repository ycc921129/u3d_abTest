//------------------------------
// Author: yangchengchao
// Data:   2021
//------------------------------

using UnityEngine;

public static class Laugch 
{
    private const string TAG = "[Laugch] ";
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void StartScene()
    {
        Debug.Log(TAG + "Enter.");
        //TODO 改为AB加载
        //GameObject.Instantiate<GameObject>(Resources.Load<GameObject>("GameRoot"));
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void EndScene()
    {
        Debug.Log(TAG + "End.");
    }
}
