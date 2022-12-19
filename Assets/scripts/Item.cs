using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        SpeedPotion,
        HealthPotion,
        Bomb,
        HealthRing,
        SpeedNecklace,
        HeavySword,
        FastSword,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Bomb:          return ItemAssets.Instance.bombSprite;
            case ItemType.SpeedNecklace: return ItemAssets.Instance.speedNecklaceSprite;
            case ItemType.SpeedPotion:   return ItemAssets.Instance.speedPotionSprite;
            case ItemType.HealthPotion:  return ItemAssets.Instance.healthPotionSprite;
            case ItemType.HealthRing:    return ItemAssets.Instance.healthRingSprite;
            case ItemType.HeavySword:    return ItemAssets.Instance.heavySwordSprite;
            case ItemType.FastSword:     return ItemAssets.Instance.fastSwordSprite;
        }
    }
}
