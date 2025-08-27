namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewAbilityRefreshOnTrigger", menuName = "BTD6/Behaviors/Simulations/AbilityRefreshOnTrigger")]
public class AbilityRefreshOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x30
	public String[] abilityIds; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public AbilityRefreshOnTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

