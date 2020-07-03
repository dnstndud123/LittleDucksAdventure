using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBase : MonoBehaviour
{
    protected SoundManager sM;
    public GameManager gM;
    public UIManager uM;
    public Rigidbody2D rigid;
    public Character2D player;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        sM = FindObjectOfType<SoundManager>();
        player = FindObjectOfType<Character2D>();
        gM = FindObjectOfType<GameManager>();
        uM = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnButtonClick(GameObject btn)
    {
        sM.Play("Button");
    }
}
