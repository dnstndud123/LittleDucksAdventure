using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        player = FindObjectOfType<Character2D>();
        gM = FindObjectOfType<GameManager>();
        uM = FindObjectOfType<UIManager>();
        
        
    }

    
    public virtual void OnButtonClick(GameObject btn)
    {
        sM.Play("Button");
    }
}
