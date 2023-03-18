using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWidth : MonoBehaviour
{
    private SpriteRenderer sprite;


    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        Vector3 escalaTemp = transform.localScale;

        float largura = sprite.bounds.size.x;
        float altura = sprite.bounds.size.y;

        float alturaWorld = Camera.main.orthographicSize * 2f;
        float larguraWorld = alturaWorld / Screen.height * Screen.width;

        escalaTemp.x = larguraWorld / largura;
        //escalaTemp.y = alturaWorld / altura;

        transform.localScale = escalaTemp;
    }
}
