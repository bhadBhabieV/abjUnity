using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpOfficial : MonoBehaviour
{
    public Vector3 startVec;
    public Vector3 endVec;
    private float currentLerpTime;
    public float lerpSpeed = 2.0f;
    private float timeStartedLerping;
    private bool shouldLerp = false;

    // Start is called before the first frame update
    void Start()
    {
        //endVec = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            StartLerping();
        }

        if (shouldLerp)
        {
            currentLerpTime += Time.deltaTime;
            transform.position = Vector3.Lerp(startVec, endVec, currentLerpTime * lerpSpeed);
        }
    }

    private void StartLerping()
    {
        currentLerpTime = 0.0f;
        timeStartedLerping = Time.time;
        shouldLerp = true;
    }

    //public Vector3 Lerp(Vector3 start, Vector3 end, float currentLerpTime)
    //{
    //    float percent01 = currentLerpTime / lerpSpeed;
    //    var result = Vector3.Lerp(start, end, percent01);

    //    return result;
    //}
}
