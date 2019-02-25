using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyHolder candyHolder;
    public int reward;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Candy")
        {
            //指定数だけCandyのストック数を増やす
            candyHolder.AddCandy(reward);

            //オブジェクトの消去
            Destroy(other.gameObject);
        }
    }

}
