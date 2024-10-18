using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : SingletonAutoMono<InputManager>
{
    public UnityAction MouseDownLeftAction;
    public UnityAction MouseDownRightAction;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MouseDownLeftAction != null) 
            {
                MouseDownLeftAction();  
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (MouseDownRightAction != null)
            {
                MouseDownRightAction();
            }
        }
    }
}
