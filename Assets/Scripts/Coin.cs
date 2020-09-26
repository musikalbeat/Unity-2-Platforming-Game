using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectable
{
    // Start is called before the first frame update
    private void Start()
    {
        collectableName = "Coin";
        description = "increase score by 10";
    }

    public override void Use()
    {
        player.GetComponent<playerManager>().ChangeScore(10);
        Destroy(this.gameObject);
    }
}
