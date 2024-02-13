using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private void Start()
    {
        EventManager.Instance.FOnOverViewModeChange += OnOverviewModeChange;
    }

    private void OnOverviewModeChange(bool overviewMode)
    {
        Debug.Log(transform.rotation.eulerAngles);
        if (overviewMode)
        {
            transform.rotation = Quaternion.Euler(90, 0, 90);
        }
        else
        {
            transform.rotation = Quaternion.Euler(35, 270, 0);
        }
    }
}
