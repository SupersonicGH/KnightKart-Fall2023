using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using Cinemachine;

public class Player : MonoBehaviour
{
   [SerializeField] CinemachineVirtualCamera MainCam1;
    [SerializeField] CinemachineVirtualCamera MainCam2;

private void OnEnable()
{
    Cam_Switch.Register(MainCam1);
    Cam_Switch.Register(MainCam2);
    Cam_Switch.SwitchCamera(MainCam1);
}

private void OnDisable()
{
    Cam_Switch.Unregister(MainCam1);
     Cam_Switch.Unregister(MainCam2);
}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(Cam_Switch.IsActiveCamera(MainCam1))
            {
                Cam_Switch.SwitchCamera(MainCam2);
            }
            else if(Cam_Switch.IsActiveCamera(MainCam2))
            {
                Cam_Switch.SwitchCamera(MainCam1);
            }
        }
    }
}
