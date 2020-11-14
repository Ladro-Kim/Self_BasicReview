using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 초기화 영역
    private void Awake()
    {
        // 오브젝트 생성시
    }

    private void OnEnable()
    {
        // 오브젝트 활성화시
    }

    private void Start()
    {
        // 업데이트 전
    }

    // 업데이트 영역
    private void FixedUpdate()
    {
        // 물리연산 전에 실행되는 업데이트 -> 물리연산을 많이 넣어서 사용.
        // 컴퓨터 사양과 상관없이 고정적으로 실행 -> CPU 부하가 큼.
    }

    private void Update()
    {
        // 컴퓨터 사양에 따른 실행주기
    }

    private void LateUpdate()
    {
        // 모든업데이트 실행 후 마지막으로 실행. -> 카메라, 후처리 등에 사용
    }

    private void OnDisable()
    {
        // 오브젝트 비활성화.
    }

    private void OnDestroy()
    {
        // 게임 오브젝트 삭제 시 마지막으로 실행 후 오브젝트 삭제.
    }









}
