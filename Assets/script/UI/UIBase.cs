using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIBase : MonoBehaviour
{
    [SerializeField] protected SoundManager sM;
    [SerializeField] protected GameManager gM;
    [SerializeField] protected UIManager uM;
    protected AdBanner ad;
    //public Rigidbody2D rigid;
    protected Character2D player;
    public Animator anim;
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        Init();
        
    }
    public virtual void Init()
    {
        GameObject sMObj = GameObject.Find("SoundManager");
        if (sMObj != null)
        sM = sMObj.GetComponent<SoundManager>();

        GameObject gMObj = GameObject.Find("GameManager");
        if (gMObj != null)
        gM = gMObj.GetComponent<GameManager>();

        GameObject uMObj = GameObject.Find("UIManager");
        if (uMObj != null)
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
        if (this is UIClear)
        {
            ad = GetComponentInChildren<AdBanner>();
            ad.DestroyAd();
        }
        sM.Play("Select");
        StartCoroutine(OnPlay(level.name));

    }
    public virtual void OnButtonClick(GameObject btn)
    {
        if (this is UIGameOver || this is UIClear)
        {
            ad = GetComponentInChildren<AdBanner>();
            ad.DestroyAd();
        }
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
        
        if (this is UIGameOver || this is UIClear)
        {
            AdBanner ad = GetComponentInChildren<AdBanner>(true);
            ad.DestroyAd();
        }
        sM.Play("Select");
        StartCoroutine(OnPlay("LevelSelect"));

    }
    public void OnMain()
    {
        sM.Play("Select");
        StartCoroutine(OnPlay("Start"));
    }
}
