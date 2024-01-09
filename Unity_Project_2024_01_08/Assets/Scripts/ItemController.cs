using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int amount = 10;

    public enum ITEMTYPE : int
    {
        HP_ITEM,
        EXP_ITEM
    }

    public ITEMTYPE itemtype = ITEMTYPE.HP_ITEM;
}
