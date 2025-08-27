namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "UCAV", menuName = "BTD6/Behaviors/Abilities/UCAV")]
public class UCAV : AbilityBehavior
{
	public float duration; //Field offset: 0x30
	public Tower uavTower; //Field offset: 0x38
	public Tower ucavTower; //Field offset: 0x40
	public Effect effectAtTowerEnd; //Field offset: 0x48

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 320
	}

	public UCAV() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

