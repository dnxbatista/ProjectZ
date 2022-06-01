using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuckGenerator : MonoBehaviour
{
    private GameObject chunck;
    [SerializeField] private GameObject _chunckPrefab;
    private bool _enableToCreateAChunck =  true;

    public void CreateChunck()
    {
        if (_enableToCreateAChunck)
        {
            chunck = Instantiate(_chunckPrefab, new Vector2(transform.position.x + 38f, transform.position.y), Quaternion.identity);
            chunck.name = "Chunck";
            _enableToCreateAChunck = false;
        }
        else
        {
            return;
        }
        
    }

    public void DeleteChunck()
    {
        Destroy(this.gameObject);
    }
}
