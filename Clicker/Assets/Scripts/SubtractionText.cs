using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SubtractionText : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public float alpha;
    private void Start()
    {
        tmp = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        while (true)
        {
            if (alpha > 0)
            {
              alpha -= Time.deltaTime;
              tmp.color= Color.Lerp(new Color(tmp.color.r, tmp.color.g, tmp.color.b, 0), new Color(tmp.color.r, tmp.color.g, tmp.color.b, 1), alpha);
            }
            yield return null;
        }
    }
}
