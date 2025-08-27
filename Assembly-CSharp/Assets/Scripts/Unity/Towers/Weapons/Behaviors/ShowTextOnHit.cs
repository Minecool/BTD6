namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ShowTextOnHit : ProjectileBehavior
{
	public ShowTextOnHit parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool useTowerPosition; //Field offset: 0xA0
	public string expUseTowerPosition; //Field offset: 0xA8
	public string text; //Field offset: 0xB0
	public string expText; //Field offset: 0xB8
	public GameObject display; //Field offset: 0xC0
	public GameObject expDisplay; //Field offset: 0xC8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1063
	}

	public ShowTextOnHit() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

