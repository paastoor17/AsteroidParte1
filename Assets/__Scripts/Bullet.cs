﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
    static private Transform _BULLET_ANCHOR;
    static Transform BULLET_ANCHOR {
        get {
            if (_BULLET_ANCHOR == null) {
                GameObject go = new GameObject("BulletAnchor");
                _BULLET_ANCHOR = go.transform;
            }
            return _BULLET_ANCHOR;
        }
    }

    public float bulletSpeed = 20;
    public float lifeTime = 2;

    void Start()
    {
        transform.SetParent(BULLET_ANCHOR, true);
        
        Invoke("DestroyMe", lifeTime);
        
        GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;
    }

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
