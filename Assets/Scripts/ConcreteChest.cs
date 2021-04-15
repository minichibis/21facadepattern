/** Sam Carpenter
*   Facade
*   ConcreteChest.cs
*   uses interface
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteChest : Chest
{
	public bool open;
	public Manager m;
	
    public ConcreteChest(Manager g){
		open = false;
		m = g;
	}
	
	public Sprite GetSprite(){
		if(open){
			return Resources.Load<Sprite>("chest2");
		}
		return Resources.Load<Sprite>("chest1");
	}
	
	public void Open(){
		if(open){
			m.t.text = "You already opened this!";
		}else{
			m.gold += 500;
			m.t.text = "You get 500 Gold!";
			open = true;
		}
	}
}
