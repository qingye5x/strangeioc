/*************************************************************************************
    * 命名空间：       public
    * 文 件 名：       $safeitemname$
    * 创建时间：       $time$
    * 作    者：       SparkSun
    * 说   明：
    * 修改时间：
    * 修 改 人：
*************************************************************************************/

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BoxView : MonoBehaviour
{
    private List<Transform> _edgeList = new List<Transform>();

    void Awake()
    {
        //find all edge
        for (int i = 0; i < transform.childCount; i++)
        {
            _edgeList.Add(transform.GetChild(i));
        }
    }

    public void DoRotate(Vector3 direction)
    {
        
    }

    Transform GetRotateEdge(Vector3 direction)
    {
        //first find bottom edge
        var bottomEdge = _edgeList.Where(x => x.position.y == 0f);

        return bottomEdge.First(x => x.position.normalized == direction);
    }

}
