namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewOnBloonInRangeOfHeroDialogueTrigger", menuName = "BTD6/Behaviors/Simulations/OnBloonInRangeOfHeroDialogueTrigger")]
public class OnBloonInRangeOfHeroDialogueTrigger : SimulationBehavior
{
	[TowerType]
	public string hero; //Field offset: 0x30
	[BloonType]
	public string bloonType; //Field offset: 0x38
	public DialogueDataModel dialogue; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public OnBloonInRangeOfHeroDialogueTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

