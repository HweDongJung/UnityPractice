using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{

    public Transform targetTransform;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 direction = targetTransform.position - transform.position;
        //쿼터니언 (x,y,z,w) 인데 vector3를 이용해 쿼터니언을 만들어줌, 
        //하지만 쿼터니언을 직관적으로 이해하기 쉽지 않으므로, 유니티가 쿼터니언을 제공해주고 우리는 vector3를 이용해 표현
        //Quaternion newRotation = Quaternion.Euler(new Vector3(45,60,90));

        //Quaternion aRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        //Quaternion bRotation = Quaternion.Euler(new Vector3(60, 0, 0));

        //Quaternion targetRotation = Quaternion.Lerp(aRotation, bRotation, 0.5f);// Lerp란 a각도와 b 각도의 소숫점의 퍼센티지 (ex) 0.5 -> 50%) 만큼 a에서 b로 돌려줌

        Quaternion originalRotation = Quaternion.Euler(new Vector3(45, 0, 0)); // 기존의 로테이션 쿼터니언으로 받기
        Quaternion plusRotation = Quaternion.Euler(new Vector3(30, 0, 0));
        originalRotation *= plusRotation;
        transform.rotation = originalRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
