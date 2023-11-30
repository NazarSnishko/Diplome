using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bagUi : MonoBehaviour
{
    public Text MoodCount;
    private void Start()
    {
        bag.Instance.OnUpdate += UpdateUI;
    }

    public void UpdateUI(bag Bag)
    {
        MoodCount.text = Bag.MoodCount.ToString();
    }
    private void OnDestroy()
    {
        bag.Instance.OnUpdate -= UpdateUI;
    }

}
