using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIBase : MonoBehaviour
{
    [SerializeField] protected SoundManager sM;
    [SerializeField] protected GameManager gM;
    [SerializeField] protected UIManager uM;
    public Rigidbody2D rigid;
    protected Character2D player;
    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        sM = FindObjectOfType<SoundManager>();
        
        gM = FindObjectOfType<GameManager>();
        uM = FindObjectOfType<UIManager>();
        player = FindObjectOfType<Character2D>();
        
    }
    protected IEnumerator OnPlay(string name)
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(name);
    }
    public void OnRestart(GameObject level)
    {
        sM.Play("Select");
        StartCoroutine(OnPlay(level.name));

    }
    public virtual void OnButtonClick(GameObject btn)
    {
        sM.Play("Select");
        StartCoroutine(OnPlay(btn.name));
    }
}
