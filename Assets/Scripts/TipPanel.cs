using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class TipPanel : MonoBehaviour
{
    public EventTrigger eventTrigger;
    //��ʼ��λ��
    //��������
    //�϶����߼�
    private void Start()
    {
        //�϶���
        EventTrigger.Entry entryJoy = new EventTrigger.Entry();
        entryJoy.eventID = EventTriggerType.Drag;
        entryJoy.callback.AddListener(JoyDrag);
        eventTrigger.triggers.Add(entryJoy);
    }

    //�϶�ҡ��
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

    //��ʾ����߼�
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
    /// ����λ�ã������������߽�
    /// </summary>
    /// <param name="clickPoint">UI����</param>
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
