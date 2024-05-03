using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardProperties : MonoBehaviour
{
    public int hp;
    public int power;
    public string special;
    public string cardtype;


    public void SetCardStats(Card card)
    {
        card.hp = hp;
        card.power = power;
        card.special = special;
        card.cardtype = cardtype;
    }
}

