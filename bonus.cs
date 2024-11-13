using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 3;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(transform.position.y <= -3)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "player")
        {
            playerscript playerscript = other.transform.GetComponent<playerscript>();
            if(playerscript != null)
            {
                playerscript.activatetripleshot();
            }

            Destroy(this.gameObject);

        }
    }
}
