using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public enum Type { Ammo, Coin, Heart, Gun, Melee};
    public Type type;
    public int value;

    Rigidbody rigid;
    SphereCollider sphereColider;

    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        sphereColider = GetComponent<SphereCollider>(); //�ΰ��� �־ �� �����Ÿ� ������ �׷��� �ʿ��ѰŸ� �� ���� ���־� ��
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            rigid.isKinematic = true;
            sphereColider.enabled = false;
        }
    }
}
