/*************************************************************************************
    * 命名空间：       public
    * 文 件 名：       $safeitemname$
    * 创建时间：       $time$
    * 作    者：       SparkSun
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/


using DG.Tweening;
using UnityEngine;
using System.Collections;

public class RollBox : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.RotateAround( transform.position - new Vector3(0f,0f,0.5f) , Vector3.right,90f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.RotateAround( transform.position + new Vector3(0f, 0f, -0.5f), Vector3.right, -90f);
        }
    }

}
