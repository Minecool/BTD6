namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "NecromancerZone", menuName = "BTD6/Behaviors/Towers/NecromancerZone")]
public class NecromancerZone : TowerBehavior
{
	public Attack attackUsedForRange; //Field offset: 0x30

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 214
	}

	public NecromancerZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

