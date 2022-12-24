using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimCuong : Collectable
{
    protected override void Collected()
    {
        GameManager.MyInstance.AddKimcuong();
        Destroy(this.gameObject);
    }

}
