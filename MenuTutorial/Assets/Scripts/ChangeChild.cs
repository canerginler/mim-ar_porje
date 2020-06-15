using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading;
using UnityEngine;

public class ChangeChild : MonoBehaviour
{
    public List<GameObject> itemList;
    [SerializeField] GameObject ImageTarget;
    [SerializeField] GameObject ItemsObject;
    private void Start()
    {
        ChangeChildItem(PlayerPrefs.GetInt("ItemId"));
    }
    public void ChangeChildItem(int itemId)
    {
        ImageTarget.transform.GetChild(0).parent = ItemsObject.transform;
        itemList[itemId].transform.parent = ImageTarget.transform;
    }
}
