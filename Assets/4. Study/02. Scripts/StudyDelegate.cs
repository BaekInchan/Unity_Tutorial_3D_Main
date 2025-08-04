using UnityEngine;

public class StudyDelegate : MonoBehaviour
{
    public delegate void TimerStart();
    public TimerStart onTimerStart;
    
    public delegate void TimerEnd();
    public TimerStart onTimerEnd;

    private float timer = 5f;
    private bool isTimer = true;

    private void OnEnable()
    {
        onTimerStart += StartEvent;
        onTimerEnd += EndEvent;
    }

    private void Start()
    {
        onTimerStart?.Invoke();
    }

    private void OnDisable()
    {
        onTimerStart -= StartEvent;
        onTimerEnd -= EndEvent;
    }

    private void Update()
    {
        if (!isTimer)
            return;

        timer -= Time.deltaTime;

        if(timer <= 0f)
        {
            isTimer = false;
            onTimerEnd?.Invoke();
        }

    }

    private void StartEvent()
    {
        Debug.Log("Ÿ�̸� ����");
    }

    private void EndEvent()
    {
        Debug.Log("Ÿ�̸� ����");
    }
    #region 
    //// Delegate : �븮�� ����
    //// �Լ� ���� ����

    //// ���������� delegate ��ȯŸ�� ������(�Ű�����);
    //public delegate void MyDelegate();
    //public static MyDelegate onKeyDown;

    //public KeyCode keyCode = KeyCode.Space;

    //public float timer;

    //public bool isTimer = true;


    //private void Start()
    //{
    //    AddMethod(Respond);
    //    AddMethod(StopTimer);
    //    AddMethod(StopBomb);


    //    //onKeyDown += Respond;
    //    //onKeyDown += StopTimer;
    //    //onKeyDown += StopBomb;
    //    //// ��(Delegate) �Ʒ�(Button) ���� ���
    //    //button.onClick.AddListener(Respond);
    //    //button.onClick.AddListener(StopTimer);
    //    //button.onClick.AddListener(StopBomb);
    //    #region ��������Ʈ
    //    // ���� ����� ��������Ʈ �Ҵ�
    //    // myDelegate = new MyDelegate(MethodA);

    //    // �Ҵ� ǥ�� ���
    //    //myDelegate = MethodA;
    //    // Delegate chain ���
    //    //myDelegate += MethodB;
    //    //myDelegate += MethodC;

    //    //myDelegate -= MethodB;

    //    //myDelegate = MethodB;

    //    //myDelegate?.Invoke(); // ? �� �� üũ ������ 
    //    // ��������Ʈ ȣ��
    //    //myDelegate();
    //    //if (myDelegate != null) 
    //    //{
    //    //    myDelegate.Invoke();
    //    //}
    //    //myDelegate += MethodA; // ��� x
    //    //myDelegate += MethodB; // ��� ����
    //    //myDelegate += MethodC;

    //    //myDelegate?.Invoke();
    //    //myDelegate?.Invoke(10);
    //    #endregion
    //}

    //private void Update()
    //{
    //    if (isTimer) 
    //    {
    //        timer += Time.deltaTime;
    //    }

    //    if (Input.GetKeyDown(keyCode))
    //    {
    //        onKeyDown?.Invoke();
    //    }
    //}

    //public void AddMethod(MyDelegate myDelegate)
    //{
    //    onKeyDown += myDelegate;
    //}

    //private void Respond()
    //{
    //    Debug.Log("Ű�� ���Ƚ��ϴ�");
    //}

    //private void StopTimer()
    //{
    //    isTimer = false;
    //    Debug.Log("Ÿ�̸� ����");
    //}

    //private void StopBomb()
    //{
    //    Debug.Log("��ź ��� ����");
    //}
    #endregion
}
