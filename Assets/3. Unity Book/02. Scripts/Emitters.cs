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

    // �ñ׳ο� �̺�Ʈ�� ����ϴ� �Լ�
    public void SetSignalEvent()
    {
        UnityEvent eventCOntainer = new UnityEvent();

        eventCOntainer.AddListener(() => 
        {
            Debug.Log("�̺�Ʈ ����");
            OnTimelineSpeed(0.2f);
            Debug.Log("Timeline �ӵ� 0.2 ����");
        });

        receiver.AddReaction(signal, eventCOntainer);
    }
}
