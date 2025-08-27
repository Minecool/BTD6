namespace Assets.Scripts.Unity.Towers.Behaviors.Attack.Behaviors;

public class TargetDesperado : TargetFirstPrioCamo
{
	public bool canTargetMarked; //Field offset: 0xA0
	public string expCanTargetMarked; //Field offset: 0xA8
	public bool canPrioritiseCamo; //Field offset: 0xB0
	public string expCanPrioritiseCamo; //Field offset: 0xB8

	public virtual AttackBehaviorModel Def
	{
		 get { } //Length: 174
	}

	public TargetDesperado() { }

	public virtual AttackBehaviorModel get_Def() { }

}

