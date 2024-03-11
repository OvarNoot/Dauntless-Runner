using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animPlat : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveDur = 5;
    public Vector3 target = new Vector3(20, 15, -6);
    
    void Start()
    {
        StartCoroutine(movePlat(target));
    }

    // Update is called once per frame
    IEnumerator movePlat(Vector3 targetPosition)
    {
        Vector3 startPosition = transform.position;
        float timeElap = 0;
        
        while (timeElap < moveDur)
        {
        	transform.position = Vector3.Lerp(startPosition, targetPosition, timeElap / moveDur);
        	timeElap += Time.deltaTime;
        	yield return null;
        }
        transform.position = targetPosition;
    }
}
