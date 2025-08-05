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
        Debug.Log("타이머 시작");
    }

    private void EndEvent()
    {
        Debug.Log("타이머 종료");
    }
    #region 
    //// Delegate : 대리자 역할
    //// 함수 참조 역할

    //// 접근제한자 delegate 반환타입 변수명(매개변수);
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
    //    //// 위(Delegate) 아래(Button) 같은 기능
    //    //button.onClick.AddListener(Respond);
    //    //button.onClick.AddListener(StopTimer);
    //    //button.onClick.AddListener(StopBomb);
    //    #region 델리게이트
    //    // 옛날 방식의 델리게이트 할당
    //    // myDelegate = new MyDelegate(MethodA);

    //    // 할당 표준 방식
    //    //myDelegate = MethodA;
    //    // Delegate chain 방식
    //    //myDelegate += MethodB;
    //    //myDelegate += MethodC;

    //    //myDelegate -= MethodB;

    //    //myDelegate = MethodB;

    //    //myDelegate?.Invoke(); // ? 는 널 체크 연산자 
    //    // 델리게이트 호출
    //    //myDelegate();
    //    //if (myDelegate != null) 
    //    //{
    //    //    myDelegate.Invoke();
    //    //}
    //    //myDelegate += MethodA; // 사용 x
    //    //myDelegate += MethodB; // 사용 가능
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
    //    Debug.Log("키가 눌렸습니다");
    //}

    //private void StopTimer()
    //{
    //    isTimer = false;
    //    Debug.Log("타이머 정지");
    //}

    //private void StopBomb()
    //{
    //    Debug.Log("폭탄 기능 정지");
    //}
    #endregion
}
