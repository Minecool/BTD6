namespace Assets.Scripts.Unity.Towers.Behaviors;

public class StartOfRoundRateBuff : TowerBehavior
{
	public StartOfRoundRateBuff parent; //Field offset: 0x98
	public float modifier; //Field offset: 0xA0
	public string expModifier; //Field offset: 0xA8
	public float duration; //Field offset: 0xB0
	public string expDuration; //Field offset: 0xB8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 165
	}

	public StartOfRoundRateBuff() { }

	public virtual TowerBehaviorModel get_Def() { }

}

