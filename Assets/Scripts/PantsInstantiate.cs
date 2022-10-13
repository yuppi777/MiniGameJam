using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantsInstantiate : MonoBehaviour
{
    [SerializeField] SpriteRenderer _pants;
    [SerializeField] Transform _spwnArea;
    [SerializeField] float interval;

    private void Start()
    {
        StartCoroutine("Instashade");
    }
    bool RandomX()//‚½‚¾‚Ì’Š‘I
    {

        float randomPosX = Random.Range(0, 7);
        if (randomPosX == 0)
        {
            return true;
        }
        else return false;

    }
    IEnumerator Instashade()
    {
        while (true)
        {
            Instantiate(_pants, _spwnArea.position, Quaternion.identity);
            yield return new WaitForSeconds(interval);
        }
    }
    private void Update()
    {
        
       
    }
}
