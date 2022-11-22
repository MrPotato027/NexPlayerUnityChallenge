using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class DLLManager : MonoBehaviour
{
    [DllImport("NexPlayerDLL")]
    public static extern void Init();
    [DllImport("NexPlayerDLL")]
    public static extern void OnPlayPause(int current_playback_time);
    [DllImport("NexPlayerDLL")]
    public static extern int GetNumberOfPlayPauseEvents();
    [DllImport("NexPlayerDLL")]
    public static extern int GetLastPlayPauseTimestamp();

    void Start()
    {
        Init();
    }

    void Update(){
        UpdateUI();
    }

    public void OnPlayPauseButton(){
        OnPlayPause(0);
    }

    void UpdateUI(){
        
    }
}