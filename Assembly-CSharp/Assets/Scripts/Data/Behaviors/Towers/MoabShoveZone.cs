namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "MoabShoveZone", menuName = "BTD6/Behaviors/Towers/MoabShoveZone")]
public class MoabShoveZone : TowerBehavior
{
	public float range; //Field offset: 0x30
	public float moabPushSpeedScaleCap; //Field offset: 0x34
	public float bfbPushSpeedScaleCap; //Field offset: 0x38
	public float zomgPushSpeedScaleCap; //Field offset: 0x3C
	public FilterInvisible filterInvisible; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 324
	}

	public MoabShoveZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

