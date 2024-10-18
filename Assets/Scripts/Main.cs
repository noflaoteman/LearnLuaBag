using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Main : MonoBehaviour
{
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("Main");
        InputManager.GetInstance();   
    }
}
