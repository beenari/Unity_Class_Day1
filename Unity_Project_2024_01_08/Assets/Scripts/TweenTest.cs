using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);              //x�� 5���� 2�� �ȿ� �̵�
        //transform.DORotate(new Vector3(0, 0, 180), 2);      //z���� 2�� �ȿ� 180�� ȸ��
        //transform.DOScale(new Vector3(2, 2, 2), 2);             //������Ʈ�� x, y, x������ ���� 2�踸ŭ 2�ʾȿ� ����

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
