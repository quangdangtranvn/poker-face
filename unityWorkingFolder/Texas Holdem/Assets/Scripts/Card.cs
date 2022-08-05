using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QTBlue.CardGame
{
    [CreateAssetMenuAttribute(fileName = "New Card", menuName = "Card/New")]
    public class Card : ScriptableObject
    {
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        [SerializeField] public string name;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        [SerializeField] public string suit;
        [SerializeField] public float rankValue;
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public Sprite? image;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.



    }

}

