using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletlifeTIme : MonoBehaviour
{
    public float lifetime, life;
    void Update()
    {
        life += Time.deltaTime;
        if(life > lifetime)
        {
            Destroy(this.gameObject);
        }
    }
}
