namespace Assets.Scripts.Unity.Towers.Behaviors;

public class LifeRegen : TowerBehavior
{
	public LifeRegen parent; //Field offset: 0x98
	public float regenAmount; //Field offset: 0xA0
	public string expRegenAmount; //Field offset: 0xA8
	public float overRegenAmount; //Field offset: 0xB0
	public string expOverRegenAmount; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1128
	}

	public LifeRegen() { }

	public virtual TowerBehaviorModel get_Def() { }

}

