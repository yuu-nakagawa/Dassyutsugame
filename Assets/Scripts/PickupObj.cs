using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    // アイテムの種類を設定する
    public Item.Type type;

    //TODO:クリックしたら消える
    //TODO:データベースからアイテムを生成する

    //クリックしたら消える:Trigger
    public void OnClickObj()
    {
        gameObject.SetActive(false);
    }
}
