using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        // �C�Ӽv�浥�t���U����
        transform.Translate(0, -0.1f, 0);

        // ���b�Y�W�X�C���e���ɴN�˱󪫥�
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }
}