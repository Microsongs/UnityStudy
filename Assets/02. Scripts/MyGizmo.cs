using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmo : MonoBehaviour
{
    //보일 구체의 색상과 반지름 설정
    public Color _color = Color.yellow;
    public float _radius = 0.1f;

    private void OnDrawGizmos()
    {
        //가즈모 색상&구체 생성
        Gizmos.color = _color;
        Gizmos.DrawSphere(transform.position, _radius);
    }
}
