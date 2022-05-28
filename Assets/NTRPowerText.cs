using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NTRPowerText : SingletonMonoBehavior<NTRPowerText>
{
    [SerializeField] Text text;
    // Update is called once per frame
    public void UpdateText()
    {
        text.text = "NTR Power : " + Player.instance.Salmon.ToString();
    }
}
