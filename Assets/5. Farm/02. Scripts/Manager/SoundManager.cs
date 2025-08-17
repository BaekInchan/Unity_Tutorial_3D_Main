using UnityEngine;
using System.Collections.Generic;
public class SoundManager : Singleton<SoundManager>
{
    // [Header] 어트리뷰트는 인스펙터 창에 제목을 달아 가독성을 높여줍니다.
    [Header("오디오 소스")]
    [SerializeField] private AudioSource bgmPlayer; // 배경음악(BGM) 재생기
    [SerializeField] private AudioSource sfxPlayer; // 효과음(SFX) 재생기

    [Header("오디오 클립")]
    // 인스펙터에서 관리할 오디오 클립 배열
    [SerializeField] private AudioClip[] clips;

    // 오디오 클립을 이름으로 쉽게 찾아 쓰기 위한 딕셔너리
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();

    /// <summary>
    /// 부모 클래스(Singleton)의 Awake를 먼저 실행하고,
    /// 오디오 매니저에 필요한 초기화를 추가로 진행합니다.
    /// </summary>
    protected override void Awake()
    {
        // base.Awake()를 호출하여 부모인 Singleton<T>의 Awake 로직을 먼저 실행합니다.
        // 이 부분이 싱글톤을 설정하고 DontDestroyOnLoad를 처리해줍니다.
        base.Awake();

        // 오디오 클립 배열을 딕셔너리로 변환하여 사용하기 쉽게 만듭니다.
        // 이렇게 하면 이름(string)으로 오디오 클립을 바로 찾을 수 있어 편리하고 빠릅니다.
        foreach (var clip in clips)
        {
            audioClips.Add(clip.name, clip);
        }

        // AudioManager 오브젝트에 있는 AudioSource 컴포넌트들을 가져옵니다.
        // bgmPlayer와 sfxPlayer를 구분하기 위해 두 개를 추가해두는 것이 좋습니다.
        AudioSource[] players = GetComponents<AudioSource>();
        bgmPlayer = players[0];
        sfxPlayer = players[1];
    }
    private void Start()
    {
        if( clips.Length > 0)
        {
            PlayBGM(clips[0].name);
        }
    }


    /// <summary>
    /// 배경음악(BGM)을 재생합니다.
    /// </summary>
    /// <param name="clipName">재생할 오디오 클립의 이름</param>
    public void PlayBGM(string clipName)
    {
        // 딕셔너리에 해당 이름의 클립이 없으면 경고를 출력하고 함수를 종료합니다.
        if (!audioClips.ContainsKey(clipName))
        {
            Debug.LogWarning(clipName + "이라는 이름의 오디오 클립이 없습니다.");
            return;
        }

        // 현재 재생 중인 BGM과 같은 곡이면 다시 재생하지 않습니다.
        if (bgmPlayer.clip != null && bgmPlayer.clip.name == clipName)
        {
            return;
        }

        bgmPlayer.clip = audioClips[clipName]; // 오디오 클립 설정
        bgmPlayer.loop = true;                 // BGM은 보통 반복 재생합니다.
        bgmPlayer.Play();                      // 재생
    }

    /// <summary>
    /// 효과음(SFX)을 재생합니다.
    /// </summary>
    /// <param name="clipName">재생할 오디오 클립의 이름</param>
    public void PlaySFX(string clipName)
    {
        if (!audioClips.ContainsKey(clipName))
        {
            Debug.LogWarning(clipName + "이라는 이름의 오디오 클립이 없습니다.");
            return;
        }

        // PlayOneShot은 기존 재생을 멈추지 않고 사운드를 겹쳐서 재생할 수 있어 효과음에 적합합니다.
        sfxPlayer.PlayOneShot(audioClips[clipName]);
    }
}