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

    //회전 속도 변수
    public float rotSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        //스크립트가 실해된 후에 처음 수행되는 Start 함수에서 transform 컴포넌트 할당
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

        //전후좌우 이동 방향 벡터 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //이동 방향은 대각선일 경우 sqrt(2)가 되므로 정규화(normalized) 필요
        //Translate(이동방향.normalized * TIme.deltaTime * 변위값 * 속도, 기준좌표)
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        //Vector3.up축을 기준으로 rotSpeed만큼의 속도로 회전
        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

        /*
        //Translate(이동방향 * 속도 * 변위값(전진,후진변수) * TIme.DeltaTIme, 기준좌표)
        tr.Translate(Vector3.forward * moveSpeed * v * Time.deltaTime, Space.Self);
        
        // 매 프레임마다 10유닛만큼 이동
        //transform.Translate(Vector3.forward * 10);
        
        // 매 초마다 10유닛만큼 이동
        //transform.Translate(Vector3.forward * Time.deltaTime * 10);
        */
    }
}
