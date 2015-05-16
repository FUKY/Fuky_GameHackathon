using UnityEngine;
using System.Collections;

public class HellController : MonoSingleton<HellController> {

    public bool isHaveCollision;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Co va cham1" + isHaveCollision);
        if(!isHaveCollision)
            isHaveCollision = true;
        Debug.Log("Co va cham2" + isHaveCollision);
    }
}
