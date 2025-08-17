using Unity.Cinemachine;
using UnityEngine;

public class FiledEvent : MonoBehaviour
{
    [SerializeField] private CinemachineClearShot clearShot; // 관리 카메라
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCameraState(CameraState.Field);
            GameManager.Instance.ui.ActivateFieldUI(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCameraState(CameraState.Outside);
            GameManager.Instance.ui.ActivateFieldUI(false);

        }
    }
}
