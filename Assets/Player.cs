using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : SingletonMonoBehavior<Player>
{
    public int Salmon;
    public float grudge;
    public int SexSlaveCount;
    [SerializeField] GameObject GameoverUI;

    [SerializeField] TimerText TimerText;
    [SerializeField] GirlNumberText GirlNumberText;

    public void AddGrudge(float Val)
    {
        grudge += Val * Time.deltaTime;
        LoveBar.instance.UpdateLove();
        if (grudge >= 100)
        {
            Gameover();
        }
    }

    public void OnShoot()
    {
        Salmon -= 1;
        if (Salmon <= 0)
        {
            Gameover();
        }
        NTRPowerText.instance.UpdateText();

    }

    public void addSalmon()
    {
        Salmon += 2;
        NTRPowerText.instance.UpdateText();
    }

    public void Gameover()
    {
        Destroy(gameObject);
        GameoverUI.SetActive(true);
        TimerText.UpdateText();
        GirlNumberText.UpdateText();
    }
}
