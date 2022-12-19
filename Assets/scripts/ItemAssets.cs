using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
   public static ItemAssets Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite healthPotionSprite;
    public Sprite speedPotionSprite;
    public Sprite bombSprite;
    public Sprite healthRingSprite;
    public Sprite speedNecklaceSprite;
    public Sprite heavySwordSprite;
    public Sprite fastSwordSprite;

   

}
