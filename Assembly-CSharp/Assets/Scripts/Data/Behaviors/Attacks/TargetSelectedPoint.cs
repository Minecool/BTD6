namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetSelectedPoint", menuName = "BTD6/Behaviors/Attacks/TargetSelectedPoint")]
public class TargetSelectedPoint : TargetTypeBehavior
{
	public PrefabReference display; //Field offset: 0x38
	public float scale; //Field offset: 0x40
	public string customName; //Field offset: 0x48
	public bool lockToInsideTowerRange; //Field offset: 0x50
	public bool startWithClosestTrackPoint; //Field offset: 0x51
	public PrefabReference displayInvalid; //Field offset: 0x58
	public bool alwaysShowTarget; //Field offset: 0x60
	public Projectile projectileToExpireOnTargetChange; //Field offset: 0x68
	public bool dontUseTerrainHeight; //Field offset: 0x70

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 322
	}

	public TargetSelectedPoint() { }

	public virtual AttackBehaviorModel get_Def() { }

}

