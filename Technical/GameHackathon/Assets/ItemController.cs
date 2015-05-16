using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemController : MonoSingleton<ItemController> {

    public Transform spawnLeft;
    public Transform spawnRight;
    private List<int> listItemID;
    public void Start()
    {
        //listItemID = PoolManager.Instance.ListItemID;
    }

    [ContextMenu("Spawn")]
    public void Spawn()
    {
        listItemID = PoolManager.Instance.ListItemID;
        float positionX = Random.Range(spawnLeft.position.x, spawnRight.position.x);
        Vector3 positionItem = new Vector3(positionX, spawnRight.position.y, spawnRight.position.z);
        int index = Random.Range(0, listItemID.Count - 1);
        Debug.Log(listItemID.Count);
        int itemID = listItemID[index];
        GameObject item = PoolManager.Instance.GetItem(itemID);
        item.SetActive(true);
        item.transform.position = positionItem;
        item.transform.SetParent(spawnLeft);
        Debug.Log(item);
    }

    public void Spawn(float temp)
    {
        listItemID = PoolManager.Instance.ListItemID;
        float positionX = Random.Range(spawnLeft.position.x, spawnRight.position.x);
        Vector3 positionItem = new Vector3(positionX, spawnRight.position.y, spawnRight.position.z);
        int index = Random.Range(0, listItemID.Count - 1);
        Debug.Log(listItemID.Count);
        int itemID = listItemID[index];
        GameObject item = PoolManager.Instance.GetItem(itemID);
        item.GetComponent<Itemscrips>().Percent(temp);
        item.SetActive(true);
        item.transform.position = positionItem;
        item.transform.SetParent(spawnLeft);

    }
}
