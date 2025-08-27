namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SoulbindManager : TowerBehavior
{
	public SoulbindManager parent; //Field offset: 0x98
	public Effect effectOnTransitionBack; //Field offset: 0xA0
	public Effect expEffectOnTransitionBack; //Field offset: 0xA8
	public GameObject display; //Field offset: 0xB0
	public GameObject expDisplay; //Field offset: 0xB8
	public float lifespan; //Field offset: 0xC0
	public string expLifespan; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 289
	}

	public SoulbindManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

