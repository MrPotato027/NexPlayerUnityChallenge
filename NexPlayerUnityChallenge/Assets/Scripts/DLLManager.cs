using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using NexPlayerSample;
using UnityEngine.UI;

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

    [SerializeField] NexPlayer nexPlayer;
    [SerializeField] Text numberOfPlayPauseEventsTxt, lastPlayPauseTimestampTxt;

    void Start()
    {
        Init();
    }

    void Update(){
        UpdateUI();
    }

    public void OnPlayPauseButton(){
        OnPlayPause(nexPlayer.GetCurrentTime());
    }

    void UpdateUI(){
        numberOfPlayPauseEventsTxt.text = "Number of Play/Pause Events: " + GetNumberOfPlayPauseEvents();

        float timestamp = (float)GetLastPlayPauseTimestamp()/1000f;
        lastPlayPauseTimestampTxt.text = "Last Play/Pause Timestamp: " + timestamp + "s";
    }
}
