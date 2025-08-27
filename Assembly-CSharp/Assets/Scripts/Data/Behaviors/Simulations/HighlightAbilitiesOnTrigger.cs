namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewHighlightAbilitiesOnTrigger", menuName = "BTD6/Behaviors/Simulations/HighlightAbilitiesOnTrigger")]
public class HighlightAbilitiesOnTrigger : SimulationBehavior
{
	public string triggerId; //Field offset: 0x30
	public string abilityIds; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public HighlightAbilitiesOnTrigger() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

