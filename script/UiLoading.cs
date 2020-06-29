using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiLoading : MonoBehaviour
{
    public Animator anim;
    public Text loading;
    //private 기본값
    public float loadingTime;//로딩시간
    private int nextStage = 0;
    private float waitTime = 0;//현재 대기시간
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextStage(int stageNumber)
    {
        nextStage = stageNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (nextStage > 0)
        {
            //둘이 같음
            waitTime += Time.deltaTime;
            //waitTime = waitTime + Time.deltaTime;
            /* for (float i = 0; i < waitTime; i++)
             {
                 if (i == 0.5f)
                     loading.text = "Loading.";
                 if (i == 1.0f)
                     loading.text = "Loading..";
                 if (i == 1.5f)
                     loading.text = "Loading...";
                 if (i == 2.0f)
                     loading.text = "Loading....";
                 i = 0;
             }
            */


            //몇초간 기다렸다가 로딩시간 차면

            if (waitTime > loadingTime - 1.0f)
            {
                bool roof = anim.GetBool("roof");
                if (roof == false)
                {

                    anim.SetBool("roof", true);

                    GameManager gmr = FindObjectOfType<GameManager>();
                    gmr.NextStage(nextStage);
                }
            }
            if (waitTime > loadingTime)
            {
                               
                
                UiManager uim = FindObjectOfType<UiManager>();
                uim.HideAll();
                uim.Show("UiPlay", true);

                //다음에 로딩화면을 또 사용하기 위해 값 초기화
                waitTime = 0;
                nextStage = 0;
                anim.Rebind();
            }
        }
        

    }
}
