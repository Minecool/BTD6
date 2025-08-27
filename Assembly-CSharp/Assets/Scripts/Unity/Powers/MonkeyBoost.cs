namespace Assets.Scripts.Unity.Powers;

public class MonkeyBoost : PowerBehavior
{
	public float rateScale; //Field offset: 0x20
	public float duration; //Field offset: 0x24

	public virtual PowerBehaviorModel Def
	{
		 get { } //Length: 160
	}

	public MonkeyBoost() { }

	public virtual PowerBehaviorModel get_Def() { }

}

