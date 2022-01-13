using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPortal : Collidable
{
    public string exitName;

    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
            GameManager.instance.player.transform.position = GameObject.Find(exitName).transform.position;
    }
}
