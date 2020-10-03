using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    // Start is called before the first frame update
    private void Start()
    {
        collectableName = "Chest";
        description = "increase score by 100";
    }

    public override void Use()
    {
       player.GetComponent<playerManager>().ChangeScore(100);
       Destroy(this.gameObject);
    }
}
