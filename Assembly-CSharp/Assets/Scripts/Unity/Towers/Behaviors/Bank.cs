namespace Assets.Scripts.Unity.Towers.Behaviors;

public class Bank : TowerBehavior
{
	public Bank parent; //Field offset: 0x98
	public float capacity; //Field offset: 0xA0
	public string expCapacity; //Field offset: 0xA8
	public float intrest; //Field offset: 0xB0
	public string expIntrest; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8
	public GameObject display; //Field offset: 0xD0
	public GameObject expDisplay; //Field offset: 0xD8
	public bool autoCollect; //Field offset: 0xE0
	public string expAutoCollect; //Field offset: 0xE8
	public GameObject fullDisplay; //Field offset: 0xF0
	public GameObject expFullDisplay; //Field offset: 0xF8
	public int collectAnimation; //Field offset: 0x100
	public string expCollectAnimation; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 1144
	}

	public Bank() { }

	public virtual TowerBehaviorModel get_Def() { }

}

