using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    //h는 가로(Horizontal) v는 세로(Vertical)을 가리킴
    private float h = 0.0f;
    private float v = 0.0f;

    //접근해야 하는 컴포넌트는 반드시 변수에 할당한 이후에 사용한다.
    private Transform tr;
    //이동 속도 변수
    public float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        //스크립트의 처음에 Transform 컴포넌트를 할당
        tr = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //h에 가로의 데이터, v에 새로의 데이터 삽입
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //디버그 결과 확인
        Debug.Log("H = " + h.ToString());
        Debug.Log("V = " + v.ToString());

        //Translate(이동방향 * 속도 * 변위값 * TIme.DeltaTIme, 기준좌표)
        tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);
    }
}
