using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    // 맴버변수
    public Transform targetTr;      //추적할 타깃 게임오브젝트의 Transform 변수
    public float dist = 10.0f;      //카메라와의 일정 거리
    public float height = 3.0f;     //카메라의 높이 설정
    public float dampTrace = 20.0f; //부드러운 추적을 하기 위한 변수

    // 카메라 자신의 Transform 변수
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        //카메라 자신의 Transform 컴포넌트를 tr에 해당
        tr = GetComponent<Transform>();
    }

    // Update 함수 호출 이후 한 번씩 호출되는 함수인 LateUpdate 사용
    // 추적할 타깃의 이동이 종료된 이후에 카메라가 추적하기 위해서
    void LateUpdate()
    {
        //카메라가 위치를 추적대상의 dist변수만큼 뒤쪽으로 배치하고 height변수만큼 위로 올림
        //Vector3.Lerp( Vector3 시작위치, Vector3 종료위치, float 시간)
        tr.position = Vector3.Lerp(
            tr.position
            , targetTr.position - (targetTr.forward * dist) + (Vector3.up * height)
            , Time.deltaTime * dampTrace
            );
        //카메라가 타깃 게임오브젝트를 바라보도록 설정
        tr.LookAt(targetTr.position);
    }
}
