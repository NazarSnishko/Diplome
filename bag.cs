using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bag : MonoBehaviour
{
    public int MoodCount { get; private set; }
    public static bag Instance { get; private set; }
    public event System.Action<bag> OnUpdate;

    public void Awake()
    {
        Instance = this;
    }
    public void AddMood(int count)
    {
        MoodCount += count;
        if (OnUpdate != null)
        {
            OnUpdate(this);
        }
    }
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        Instance = null;
    }
}
