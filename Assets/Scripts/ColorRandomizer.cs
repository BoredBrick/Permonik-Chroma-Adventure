using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomizer : MonoBehaviour
{
    void Awake()
    {
        Color green = new(0.4334f, 0.78f, 0.234f);
        Color red = new(0.8117647f, 0.1803922f, 0.1764706f);
        Color blue = new(0.01176471f, 0.6509804f, 0.8901961f);
        Color yellow = new(0.9019608f, 0.8f, 0.1215686f);
        int rndColor = Random.Range(0, 4);

        switch (rndColor)
        {
            case 0:
                gameObject.GetComponent<SpriteRenderer>().color = green;
                break;
            case 1:
                gameObject.GetComponent<SpriteRenderer>().color = red;
                break;
            case 2:
                gameObject.GetComponent<SpriteRenderer>().color = blue;
                break;
            case 3:
                gameObject.GetComponent<SpriteRenderer>().color = yellow;
                break;
        }
    }
}
