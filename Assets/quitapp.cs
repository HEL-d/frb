using GameKit.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitapp : MonoBehaviour
{

    [SerializeField] private Button quitButton;

    private CanvasGroup _canvasGroup;

   
      public void FirstInitialize()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        Reset();
    }

    public  void Reset()
    {
        ShowRoomCreatedFailed();



    }

    public void ShowRoomCreatedSuccess()
    {
       
        _canvasGroup.SetActive(false, true);
    }
    /// <summary>
    /// Shows canvases for a failed room creation.
    /// </summary>
    public void ShowRoomCreatedFailed()
    {
      
        _canvasGroup.SetActive(true, true);
    }


    /// <summary>
    /// Called when successfully joined a room.
    /// </summary>
    public void ShowRoomJoinedSuccess()
    {
        _canvasGroup.SetActive(false, true);
    }
    /// <summary>
    /// Called when failed to joined a room.
    /// </summary>
    public void ShowRoomJoinedFailed()
    {
        _canvasGroup.SetActive(true, true);
    }

    /// <summary>
    /// Called when successfully leaving a room.
    /// </summary>
    public void ShowRoomLeftSuccess()
    {
        _canvasGroup.SetActive(true, true);
    }
    /// <summary>
    /// Called when failing to leave a room.
    /// </summary>
    public void ShowRoomLeftFailed()
    {
        _canvasGroup.SetActive(false, true);
    }






    public void QuitApp()
    {
     Application.Quit();
    }



}
