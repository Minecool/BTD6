namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class IncreaseWorthTextEffect : BloonBehavior
{
	public IncreaseWorthTextEffect parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public bool displayFullPayout; //Field offset: 0xA0
	public string expDisplayFullPayout; //Field offset: 0xA8
	public GameObject display; //Field offset: 0xB0
	public GameObject expDisplay; //Field offset: 0xB8

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 1090
	}

	public IncreaseWorthTextEffect() { }

	public virtual BloonBehaviorModel get_Def() { }

}

