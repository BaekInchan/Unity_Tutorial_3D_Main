using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Emitters : MonoBehaviour
{
    public PlayableDirector timeline;
    public SignalReceiver receiver;
    public SignalAsset signal;

    private void Start()
    {
        SetSignalEvent();
    }

    public void OnTimelineSpeed(float speed)
    {
        timeline.playableGraph.GetRootPlayable(0).SetSpeed(speed);
    }

    // 시그널에 이벤트를 등록하는 함수
    public void SetSignalEvent()
    {
        UnityEvent eventCOntainer = new UnityEvent();

        eventCOntainer.AddListener(() => 
        {
            Debug.Log("이벤트 종료");
            OnTimelineSpeed(0.2f);
            Debug.Log("Timeline 속도 0.2 설정");
        });

        receiver.AddReaction(signal, eventCOntainer);
    }
}
