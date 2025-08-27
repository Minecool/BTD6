namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class GrowBlock : BloonBehavior
{
	public GrowBlock parent; //Field offset: 0x88

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public GrowBlock() { }

	public virtual BloonBehaviorModel get_Def() { }

}

