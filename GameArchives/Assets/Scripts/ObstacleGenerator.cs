using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    private bool canHave = true;

    private void Start()
    {

        float canHaveFloat = Random.Range(0f, 1f);
        if(canHaveFloat > 0.2f)
        {
            canHave = true;
        }
        else
        {
            canHave = false;
        }

        if (canHave)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

}
