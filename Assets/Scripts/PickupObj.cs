using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    // �A�C�e���̎�ނ�ݒ肷��
    public Item.Type type;

    //TODO:�N���b�N�����������
    //TODO:�f�[�^�x�[�X����A�C�e���𐶐�����

    //�N���b�N�����������:Trigger
    public void OnClickObj()
    {
        gameObject.SetActive(false);
    }
}
