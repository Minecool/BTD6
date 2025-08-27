namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetTrackOrDefaultAcidPool : TargetTypeBehavior
{
	public TargetTrackOrDefaultAcidPool parent; //Field offset: 0x98
	public float radius; //Field offset: 0xA0
	public string expRadius; //Field offset: 0xA8
	public bool useTowerRange; //Field offset: 0xB0
	public string expUseTowerRange; //Field offset: 0xB8
	public bool isActive; //Field offset: 0xC0
	public string expIsActive; //Field offset: 0xC8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 199
	}

	public TargetTrackOrDefaultAcidPool() { }

	public virtual AttackBehaviorModel get_Def() { }

}

