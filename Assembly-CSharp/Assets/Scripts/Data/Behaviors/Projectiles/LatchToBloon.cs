namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "LatchToBloon", menuName = "BTD6/Behaviors/Projectiles/LatchToBloon")]
public class LatchToBloon : ProjectileBehavior
{
	public bool rotateWithBloon; //Field offset: 0x30
	public int animationStateOnSetTarget; //Field offset: 0x34
	public int animationStateOnTowerOnDestroy; //Field offset: 0x38
	public float postBloonDestroyTime; //Field offset: 0x3C
	public float bloonSpeedMultiplier; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 189
	}

	public LatchToBloon() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

