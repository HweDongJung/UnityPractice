using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //게임 매니저는 모든 ItemBox를 알고 있어야 하고 그 아이템 박스들이 충돌중인지 알아야 한다 

    public ItemBox[] itemBoxes;
    public bool isGameOver;
    public GameObject winUI;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SceneManager.LoadScene("main");
            SceneManager.LoadScene(0);
        }

        if (isGameOver)
        {
            return; //결과값 종료, 함수 종료
        }

        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if(itemBoxes[i].isOveraped  == true)
            {
                count++;
            }

         }
        if (count == 3)
        {
            Debug.Log("게임 이김!");
            isGameOver = true;
            winUI.SetActive(isGameOver);
        }
    }
}
