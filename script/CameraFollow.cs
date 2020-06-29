using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform _form;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //캐릭터의 위치 가져오기
        Vector3 charFcs = _form.position;

        //캐릭터의 위치를 가져온 캐릭터의 위치로 세팅해준다(z값은 제외)
        float cmr = transform.position.z;
        transform.position = new Vector3(charFcs.x, charFcs.y, cmr);
    }
}
