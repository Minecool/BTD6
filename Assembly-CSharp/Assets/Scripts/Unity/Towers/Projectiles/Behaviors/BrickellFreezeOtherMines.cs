namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class BrickellFreezeOtherMines : ProjectileBehavior
{
	public BrickellFreezeOtherMines parent; //Field offset: 0x88
	public float freezeDuration; //Field offset: 0x90
	public string expFreezeDuration; //Field offset: 0x98

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 139
	}

	public BrickellFreezeOtherMines() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

