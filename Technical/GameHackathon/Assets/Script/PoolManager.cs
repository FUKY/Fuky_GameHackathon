using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

public class PoolManager : MonoSingleton<PoolManager>
{
    // list item clock
    private Dictionary<int, List<GameObject>> dicReSources;
    public List<GameObject> ListItemObject;
    public List<int> ListItemID;
    public int size;

    public void Start()
    {
        dicReSources = new Dictionary<int, List<GameObject>>();
        ListItemID = new List<int>();
        this.InitData(size);
    }

    public void InitData(int size)
    {
        List<GameObject> listItem;
        for (int i = 0; i < ListItemObject.Count; i++)
        {
            listItem = this.CreateItem(ListItemObject[i], size);
            GameObject gameObj = ListItemObject[i];
            Itemscrips itemScripts = gameObj.GetComponent<Itemscrips>();
            dicReSources.Add(itemScripts.idOfItem, listItem);
            ListItemID.Add(itemScripts.idOfItem);
        }
    }


    public List<GameObject> CreateItem(GameObject prefab, int size)
    {
        List<GameObject> listItem = new List<GameObject>();
        for (int i = 0; i < size; i++)
        {
            GameObject gamObj = Instantiate(prefab);
            gamObj.SetActive(false);
            listItem.Add(gamObj);
        }
        return listItem;
    }

    public GameObject GetItemFromList(ref List<GameObject> listGameObject)
    {
        foreach (var item in listGameObject)
        {
            if (!item.activeInHierarchy)
            {
                return item;
            }
        }
        return null;
    }

    public GameObject GetItem(int itemID)
    {
        if (this.dicReSources.ContainsKey(itemID))
        {
            List<GameObject> listGameObject = this.dicReSources[itemID];
            return this.GetItemFromList(ref listGameObject);
        }
#if UNITY_EDITOR
        Debug.LogError("Khong the Instance duoc doi tuong");
#endif
        return null;
    }

}
