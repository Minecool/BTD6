namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewToggleAbilityCooldownOnTrigger", menuName = "BTD6/Behaviors/Simulations/ToggleAbilityCooldownOnTrigger")]
public class ToggleAbilityCooldownOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x30
	public bool unpauseAtRoundEnd; //Field offset: 0x38
	public String[] abilityIds; //Field offset: 0x40

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 129
	}

	public ToggleAbilityCooldownOnTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

