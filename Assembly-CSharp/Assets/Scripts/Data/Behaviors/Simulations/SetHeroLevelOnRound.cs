namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewSetHeroLevelOnRound", menuName = "BTD6/Behaviors/Simulations/SetHeroLevelOnRound")]
public class SetHeroLevelOnRound : SimulationBehavior
{
	[TowerType]
	public string tower; //Field offset: 0x30
	public Int32[] round; //Field offset: 0x38
	public Int32[] level; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public SetHeroLevelOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

