using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveBar : SingletonMonoBehavior<LoveBar>
{
    [SerializeField] Healthbar HP;

    public void UpdateLove()
    {
        HP.SetHealth(Player.instance.grudge);
    }
}
