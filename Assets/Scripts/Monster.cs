/** Sam Carpenter
*   Facade
*   Monster.cs
*   fake interface
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public bool open;
	public Manager m;
	
	public Monster(Manager g){
		open = false;
		m = g;
	}
	
	public Sprite GetSprite(){
		if(open){
			return Resources.Load<Sprite>("chest3");
		}
		return Resources.Load<Sprite>("chest1");
	}
	
	public void Attack(){
		m.gold = 0;
		m.t.text = "A mimic! You lost all your gold!";
		open = true;
	}
}
