using UnityEngine;
using System.Collections;

public class ClockScrips : MonoBehaviour {
    
    // biến dừng vật phẩm trên trời
    public bool isStop = false;
    // list sprite của item 
    // Random khi Item được tạo ra 
    public Sprite[] listSpriteItem;

    public int[] listKey;

    // sprite của item
    private SpriteRenderer spriteOfItem;

    //  rigibody của item
    public Rigidbody2D rigi;

    // vận tốc rơi của item
    public float gravity = 1.0f;

    void Awake()
    {
        spriteOfItem = GetComponent<SpriteRenderer>();

        int keyCurrent = Random.Range(0, listKey.Length);

        spriteOfItem.sprite = listSpriteItem[keyCurrent];

        rigi = gameObject.GetComponent<Rigidbody2D>();

        rigi.gravityScale = rigi.gravityScale * gravity;

    }

    void Update()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            isStop = true;
            Destroy(this.gameObject);
        }
    }
}
