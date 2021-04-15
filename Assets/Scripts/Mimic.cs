/** Sam Carpenter
*   Facade
*   Mimic.cs
*   uses interface...?
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : Chest
{
	public bool open;
	public Monster m;
	
    public Mimic(Manager g){
		m = new Monster(g);
	}
	
	public Sprite GetSprite(){
		return m.GetSprite();
	}
	
	public void Open(){
		m.Attack();
	}
}
