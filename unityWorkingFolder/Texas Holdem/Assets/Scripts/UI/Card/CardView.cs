using QTBlue.CardGame;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
     public string name;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
    [SerializeField] private string suit;
    [SerializeField] private float rankValue;
    private Image img;
    private Card currentCard;
    private int childIndex;

    public CardView(Card card)
    {
        this.currentCard = card;
        this.name = card.name;
        this.suit = card.suit;
        this.rankValue = card.rankValue;
    }
    public int ChildIndex { get => childIndex; set => childIndex = value; }

    private void Awake()
    {
        img = GetComponent<Image>();
    }

    public void SetCardImg(Sprite sprite)
    {
        img.sprite = sprite;
    }
    public void SetCardImg(Card card)
    {
        img.sprite = card.image;
    }

    public void SetCardInfo(Card card)
    {
        this.currentCard = card;
        this.name = card.name;
        this.suit = card.suit;
        this.rankValue = card.rankValue;
        this.img.sprite = card.image;
    }

}
