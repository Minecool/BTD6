namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class ActivateMutator : AbilityBehavior
{
	public ActivateMutator parent; //Field offset: 0x88
	public TowerMutator towerMutator; //Field offset: 0x90

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 140
	}

	public ActivateMutator() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

