/** Sam Carpenter
*   Facade
*   Manager.cs
*   takes controls
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
	public int gold;
	public Text t;
	public Text goldtext;
	public Chest c;
	public SpriteRenderer r;
	
    // Start is called before the first frame update
    void Start()
    {
        t.text = "Here lies a chest...";
		c = new ConcreteChest(this);
		gold = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)){
			c.Open();
			r.sprite = c.GetSprite();
		}else if(Input.GetKeyDown(KeyCode.W)){
			if((!(c is Mimic)) && Random.Range(1,4) == 3 && gold != 0){
				t.text = "Here lies a chest...?";
				c = new Mimic(this);
			}else{
				t.text = "Here lies a chest...";
				c = new ConcreteChest(this);
			}
			r.sprite = c.GetSprite();
		}else if(Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		goldtext.text = "GOLD: " + gold.ToString();
		r.sprite = c.GetSprite();
    }
}
