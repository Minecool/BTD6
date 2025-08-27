namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "RandomPositionBasic", menuName = "BTD6/Behaviors/Attacks/RandomPositionBasic")]
public class RandomPositionBasic : TargetTypeBehavior
{
	public float minRadius; //Field offset: 0x38
	public float maxRadius; //Field offset: 0x3C
	public float mapBorder; //Field offset: 0x40
	public bool useTerrainHeight; //Field offset: 0x44

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 174
	}

	public RandomPositionBasic() { }

	public virtual AttackBehaviorModel get_Def() { }

}

