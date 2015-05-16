using UnityEngine;
using System.Collections;

public class ClockScrips : MonoBehaviour {
    
    // biến dừng vật phẩm trên trời
    public bool isStop = false;
    // list sprite của item 
    // Random khi Item được tạo ra 
    public Sprite[] listSpriteItem;

    public int[] listKey;

    private SpriteRenderer spriteOfItem;

    public Rigidbody2D rigi;

    void Awake()
    {
        spriteOfItem = GetComponent<SpriteRenderer>();

        int keyCurrent = Random.Range(0, listKey.Length);

        spriteOfItem.sprite = listSpriteItem[keyCurrent];

        rigi = gameObject.GetComponent<Rigidbody2D>();
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
