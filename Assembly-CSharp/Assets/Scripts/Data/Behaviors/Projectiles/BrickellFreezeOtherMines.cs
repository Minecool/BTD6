namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "BrickellFreezeOtherMines", menuName = "BTD6/Behaviors/Projectiles/BrickellFreezeOtherMines")]
public class BrickellFreezeOtherMines : ProjectileBehavior
{
	public float freezeDuration; //Field offset: 0x30

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public BrickellFreezeOtherMines() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

