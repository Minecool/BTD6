namespace Assets.Scripts.Data.Behaviors.Attacks;

[CreateAssetMenu(fileName = "TargetTrackOrDefaultAcidPool", menuName = "BTD6/Behaviors/Attacks/TargetTrackOrDefaultAcidPool")]
public class TargetTrackOrDefaultAcidPool : TargetTypeBehavior
{
	public float radius; //Field offset: 0x38
	public bool useTowerRange; //Field offset: 0x3C
	public bool isActive; //Field offset: 0x3D

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 178
	}

	public TargetTrackOrDefaultAcidPool() { }

	public virtual AttackBehaviorModel get_Def() { }

}

