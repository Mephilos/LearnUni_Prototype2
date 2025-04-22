using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    //시작 지점 저장 벡터
    private Vector3 startPosition;
    private float range = 50.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moveDistance = Vector3.Distance(startPosition, transform.position);
        Debug.Log("이동거리: " + moveDistance);

         if(moveDistance > range)
        {
            Destroy(gameObject);
        }
    }
}

