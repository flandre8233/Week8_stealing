using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GirlNumberText : SingletonMonoBehavior<GirlNumberText>
{
    [SerializeField] Text text;
    // Update is called once per frame
    public void UpdateText()
    {
        text.text = "Girl : " + Player.instance.SexSlaveCount;
    }
}
