namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CreateTextEffect : ProjectileBehavior
{
	public CreateTextEffect parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool useTowerPosition; //Field offset: 0xA0
	public string expUseTowerPosition; //Field offset: 0xA8
	public GameObject display; //Field offset: 0xB0
	public GameObject expDisplay; //Field offset: 0xB8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 1090
	}

	public CreateTextEffect() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

