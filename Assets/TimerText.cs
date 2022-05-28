using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimerText : SingletonMonoBehavior<TimerText>
{
    [SerializeField] Text text;
    // Update is called once per frame
    public void UpdateText()
    {
        text.text = Timer.instance.GetTimeString();
    }
}
