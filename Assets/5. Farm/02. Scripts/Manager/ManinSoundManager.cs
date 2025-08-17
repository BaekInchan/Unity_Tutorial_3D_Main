using UnityEngine;

public class ManinSoundManager : MonoBehaviour
{
    private void Start()
    {
        if (SoundManager.Instance != null)
        {
            SoundManager.Instance.PlayBGM("On the Farm");
        }
    }
}
