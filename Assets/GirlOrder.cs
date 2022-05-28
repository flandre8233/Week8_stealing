using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlOrder : MonoBehaviour
{
    public static int OrderUID;
    [SerializeField] SpriteRenderer[] Renderers;
    // Start is called before the first frame update
    void Start()
    {
        Renderers[0].sortingOrder = OrderUID + 1;
        Renderers[1].sortingOrder = OrderUID + 2;
        Renderers[2].sortingOrder = OrderUID + 3;
        Renderers[3].sortingOrder = OrderUID + 4;
        Renderers[4].sortingOrder = OrderUID + 5;
        OrderUID += 5;
    }


}
