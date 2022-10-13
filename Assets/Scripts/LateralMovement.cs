using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateralMovement : MonoBehaviour
{
    private Vector2 pos;
    public int num = 1;
    [SerializeField] float speed;

    void Update()
    {
        pos = transform.position;

        // �i�|�C���g�j�}�C�i�X�������邱�Ƃŋt�����Ɉړ�����B
        transform.Translate(transform.right * Time.deltaTime * speed * num);

        if (pos.x > 6)
        {
            num = -1;
        }
        if (pos.x < -8)
        {
            num = 1;
        }
    }
}
