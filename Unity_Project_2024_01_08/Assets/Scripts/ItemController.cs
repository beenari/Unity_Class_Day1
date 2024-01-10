using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ItemController : MonoBehaviour
{
    public int amount = 10;

    Sequence sequence;

    public enum ITEMTYPE : int
    {
        HP_ITEM,
        EXP_ITEM
    }

    public ITEMTYPE itemtype = ITEMTYPE.HP_ITEM;

    public void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveY(0.01f, 1));

        sequence.Join(transform.DORotate(new Vector3(0, 180, 0), 1));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }

    public void OnDestroy()
    {
        sequence.Kill();
    }
}
