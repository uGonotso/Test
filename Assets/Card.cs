using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : Button
{
    public int hp;
    public int power;
    public string special;
    public string cardtype;

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        GetComponent<CardProperties>().SetCardStats(this);
        CardManager.Instance.UpdateCardStats(this);  
    }
}
