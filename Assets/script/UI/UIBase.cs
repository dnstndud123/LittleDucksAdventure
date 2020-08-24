using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBase : MonoBehaviour
{
    [SerializeField] protected SoundManager sM;
    [SerializeField] protected GameManager gM;
    [SerializeField] protected UIManager uM;
    //public Rigidbody2D rigid;
    protected Character2D player;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        Init();
        
    }
    public virtual void Init()
    {
        GameObject sMObj = GameObject.Find("SoundManager");
        sM = sMObj.GetComponent<SoundManager>();

        GameObject gMObj = GameObject.Find("GameManager");
        gM = gMObj.GetComponent<GameManager>();

        GameObject uMObj = GameObject.Find("UIManager");
        uM = uMObj.GetComponent<UIManager>();


        player = FindObjectOfType<Character2D>();
    }
    protected IEnumerator OnPlay(string name)
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(name);
    }
    protected IEnumerator OnRestart()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene((int)SCENE.SELECT);
    }
    public void OnRestart(GameObject level)
    {
        sM.Play("Select");
        StartCoroutine(OnPlay(level.name));

    }
    public virtual void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");
        if (btn.name == "Reset")
        {
            StartCoroutine(OnRestart());

        }
        else if (btn.name != "Reset")
        {
            StartCoroutine(OnPlay(btn.name));
        }
    }
    public void OnSelect()
    {

        sM.Play("Select");
        StartCoroutine(OnPlay("LevelSelect"));

    }
}
