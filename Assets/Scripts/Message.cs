using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message : Collidable
{
    private bool isTriggered = false;
    // Triggers the Message animation and disables inputs.
    protected override void OnCollide(Collider2D coll)
    {
        if (!isTriggered && coll.name == "Player")
        {
            isTriggered = true;
            GameManager.instance.player.isActive = false;
            GameManager.instance.messageMenuAnimator.SetBool("IsShowing", true);
        }
    }
}
