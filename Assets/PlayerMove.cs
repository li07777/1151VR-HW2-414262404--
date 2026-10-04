using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2[] points = new Vector2[5];

    int index = 0;
    public float speed = 2f;

    Vector3 startScale;
    Vector3 endScale;
    SpriteRenderer sr;

    void Start()
    {
        sr = GetComponentInChildren<SpriteRenderer>();

        if (sr == null)
        {
            Debug.LogError("找不到 SpriteRenderer！");
        }

        // 從右邊樹附近開始
        points[0] = new Vector2(4.5f, 0.5f);

        // 往左前方走
        points[1] = new Vector2(2.5f, -0.5f);

        // 再往前
        points[2] = new Vector2(0f, -1.5f);
        points[3] = new Vector2(-7.5f, -0.5f);
        // 最後到左前方
        points[4] = new Vector2(0f, -2f);

        transform.position = points[0];

        // 一開始比較小
        startScale = new Vector3(0.5f, 0.5f, 1f);

        // 到前面變大
        endScale = new Vector3(1.5f, 1.5f, 1f);

        transform.localScale = startScale;
    }

    void Update()
    {
        if (index < points.Length)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                points[index],
                speed * Time.deltaTime
            );

            // 根據往前走的程度慢慢放大
            float progress =
                Mathf.InverseLerp(0.5f, -2f, transform.position.y);

            transform.localScale =
                Vector3.Lerp(startScale, endScale, progress);

            if ((Vector2)transform.position == points[index])
            {
                index++;
                if (index == 4)
                {
                    sr.flipX = !sr.flipX;
                }

            }
        }
    }
}