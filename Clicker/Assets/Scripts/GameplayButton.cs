using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayButton : MonoBehaviour
{
    public int scorePerClick;
    float speed = 0.0f;
    public float heightToTravel;
    public float witdhToTravel;

    float minY;
    float maxY;
    float minX;
    float maxX;


    public enum Dificulty
    {
        level0,
        level1,
        level2,
        level3,
        level4,
        level5,
        level6
    }
    public Dificulty ButtonMode;
    
    private void Start()
    {
        maxY = transform.localPosition.y;
        minY = maxY - heightToTravel;
        minX = transform.localPosition.x;
        maxX = minX + witdhToTravel;

        switch (ButtonMode)
        {
            case Dificulty.level0:
                break;
            case Dificulty.level1:
                speed = 150.0f;
                StartCoroutine(Move(false));

                Debug.Log(minY);
                break;
            case Dificulty.level2:
                speed = 150.0f;
                StartCoroutine(Move(false));
                StartCoroutine(Teleportation(false));
                break;
            case Dificulty.level3:
                speed = 250.0f;
                StartCoroutine(Move(false));
                break;
            case Dificulty.level4:
                speed = 250.0f;
                StartCoroutine(Move(false));
                StartCoroutine(Teleportation(false));
                break;
            case Dificulty.level5:
                speed = 400.0f;
                StartCoroutine(Move(true));
                break;
            case Dificulty.level6:
                speed = 700.0f;
                StartCoroutine(Move(true));
                StartCoroutine(Teleportation(true));
                break;
            default:
                break;
        }

    }

    IEnumerator Move(bool horizontally)
    {
        Vector3 dir;
        if (horizontally) dir = new Vector3(1.0f, 1.0f);
        else dir = new Vector3(0.0f, 1.0f);
        while (true)
        {
            if ((transform.localPosition.y > maxY && dir.y > 0) || (transform.localPosition.y < minY && dir.y < 0))
            {
                dir.y = -dir.y;
            }
            if ((transform.localPosition.x > maxX && dir.x > 0) || (transform.localPosition.x < minX && dir.x < 0))
            {
                dir.x = -dir.x;
            }
            transform.localPosition += dir * speed * Time.deltaTime;
            yield return null;
        }
    }

    IEnumerator Teleportation(bool horizontally)
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if (horizontally) transform.localPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), transform.localPosition.z);
            else transform.localPosition = new Vector3(transform.localPosition.x, Random.Range(minY, maxY), transform.localPosition.z);
        }
    }
}
