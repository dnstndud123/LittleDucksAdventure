using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject _efctPrefab;
    public AdventurerCharacter2D char2D;
    public SoundManager sM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.tag == "enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            enemy.OnDamage(char2D.atk);

            GameObject efctfap = Instantiate(_efctPrefab);
            Vector2 charPos = enemy.transform.position;
            efctfap.transform.position = new Vector2(charPos.x, charPos.y);
            sM.Play("slashHit");
        }
    }
}
