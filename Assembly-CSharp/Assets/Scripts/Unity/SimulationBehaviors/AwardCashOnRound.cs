namespace Assets.Scripts.Unity.SimulationBehaviors;

public class AwardCashOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x18
	public int cashAmount; //Field offset: 0x1C

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 102
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public AwardCashOnRound() { }

	public AwardCashOnRound(int round, int cashAmount) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

