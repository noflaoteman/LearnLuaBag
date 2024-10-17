using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class TipPanel : MonoBehaviour
{
    public EventTrigger eventTrigger;
    //初始化位置
    //设置数据
    //拖动的逻辑
    private void Start()
    {
        //拖动中
        EventTrigger.Entry entryJoy = new EventTrigger.Entry();
        entryJoy.eventID = EventTriggerType.Drag;
        entryJoy.callback.AddListener(JoyDrag);
        eventTrigger.triggers.Add(entryJoy);
    }

    //拖动摇杆
    private void JoyDrag(BaseEventData data)
    {
        PointerEventData eventData = data as PointerEventData;

        Vector2 uiPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                                       transform.parent as RectTransform,
                                       eventData.position,
                                       Camera.main,
                                       out uiPos);
        SetPos(uiPos);
    }

    //显示面板逻辑
    public void ShowPanel(Vector2 screenPoint, int itemId)
    {
        RectTransform rectTransform = this.GetComponent<RectTransform>();
        Vector2 screenPosition = RectTransformUtility.WorldToScreenPoint(Camera.main, rectTransform.position);

        Vector2 uiPos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
                                       transform.parent as RectTransform,
                                       screenPosition,
                                       Camera.main,
                                       out uiPos);
        SetPos(uiPos);
    }


    /// <summary>
    /// 设置位置，尽量不超出边界
    /// </summary>
    /// <param name="clickPoint">UI坐标</param>
    public void SetPos(Vector2 clickPoint)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(this.transform.parent as RectTransform,
                                                new Vector2(Screen.width, Screen.height),
                                                Camera.main,
                                                out Vector2 rightTopUIpoint);
        float screenWidth = rightTopUIpoint.x;
        float screenHeight = rightTopUIpoint.y;

        RectTransform rect = transform.GetComponent<RectTransform>();
        float imgHalfWidth = rect.sizeDelta.x / 2;
        float imgHalfHeight = rect.sizeDelta.y / 2;

        Vector3 rectLocalPosition = new(clickPoint.x, clickPoint.y, rect.localPosition.z);

        if (rectLocalPosition.x > (screenWidth - imgHalfWidth))
        {
            rectLocalPosition.x = screenWidth - imgHalfWidth;
        }
        if (rectLocalPosition.y > screenHeight - imgHalfHeight)
        {
            rectLocalPosition.y = screenHeight - imgHalfHeight;
        }

        if (rectLocalPosition.x < -screenWidth + imgHalfWidth)
        {
            rectLocalPosition.x = -screenWidth + imgHalfWidth;
        }
        if (rectLocalPosition.y < -screenHeight + imgHalfHeight)
        {
            rectLocalPosition.y = -screenHeight + imgHalfHeight;
        }

        this.transform.localPosition = rectLocalPosition;
    }
}
