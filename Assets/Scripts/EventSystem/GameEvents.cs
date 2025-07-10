using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 전체에서 사용할 이벤트 정의
public static class GameEvents
{
    //이벤트 정의
    public static event System.Action<string> OnSceneChanged;       //씬 전환 이벤트
    public static event System.Action OnGamePaused;                 //게임 정지 이벤트
    public static event System.Action OnGameResumed;                //게임 재시작 이벤트

    // 이벤트 호출 메서드
    public static void SceneChanged(string sceneName) => OnSceneChanged?.Invoke(sceneName);
    public static void GamePaused() => OnGamePaused?.Invoke();
    public static void GameResumed() => OnGameResumed?.Invoke();
}
