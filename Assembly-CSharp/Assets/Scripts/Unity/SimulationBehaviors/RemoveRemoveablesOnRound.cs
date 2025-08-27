namespace Assets.Scripts.Unity.SimulationBehaviors;

public class RemoveRemoveablesOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x18
	public string removeableNames; //Field offset: 0x20
	public bool disableRemoveableEffects; //Field offset: 0x28

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 156
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public RemoveRemoveablesOnRound() { }

	public RemoveRemoveablesOnRound(int round) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

