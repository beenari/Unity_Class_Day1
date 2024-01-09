using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);              //x를 5까지 2초 안에 이동
        //transform.DORotate(new Vector3(0, 0, 180), 2);      //z갑을 2초 안에 180동 회전
        //transform.DOScale(new Vector3(2, 2, 2), 2);             //오브젝트가 x, y, x축으로 각각 2배만큼 2초안에 증가

        Sequence sequence = DOTween.Sequence();

        sequence.Append(transform.DOMoveX(5, 2));
        sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));
        sequence.Append(transform.DOScale(new Vector3(2, 2, 2), 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
