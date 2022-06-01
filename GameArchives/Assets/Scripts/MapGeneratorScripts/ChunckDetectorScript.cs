using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunckDetectorScript : MonoBehaviour
{
    [SerializeField] private GameObject _chunckGenerator;
    ChuckGenerator chunckGenScript;

    void Start()
    {
        chunckGenScript = _chunckGenerator.GetComponent<ChuckGenerator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            chunckGenScript.CreateChunck();
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            chunckGenScript.DeleteChunck();
        }
    }
}
