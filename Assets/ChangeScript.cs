using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScript : MonoBehaviour
{
    public Sprite[] ImgList;
    public int IndexImg = 0;
    SpriteRenderer Sprite;
    // Start is called before the first frame update
    void Start()
    {
        IndexImg = Random.Range(1, 8);
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Sprite.sprite = ImgList[IndexImg];
        tag = IndexImg.ToString();
    }
}
