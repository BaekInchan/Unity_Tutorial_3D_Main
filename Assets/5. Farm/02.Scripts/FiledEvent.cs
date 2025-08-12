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

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.SetCameraState(CameraState.Outside);

        }
    }
}
