﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCtrl : MonoBehaviour
{
    //총알 프리랩
    public GameObject bullet;
    //총알 발사좌표
    public Transform firePos;

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼을 누른 경우 Fire함수 호출
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        //동적으로 총알을 생성하는 함수
        CreateBullet();
    }

    void CreateBullet()
    {
        //Bullet 프리랩을 동적으로 생성
        Instantiate(bullet, firePos.position, firePos.rotation);
    }
}
