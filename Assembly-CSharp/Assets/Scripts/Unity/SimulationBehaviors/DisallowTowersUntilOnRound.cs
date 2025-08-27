namespace Assets.Scripts.Unity.SimulationBehaviors;

public class DisallowTowersUntilOnRound : SimulationBehavior
{
	public int round; //Field offset: 0x18
	public bool disallowTowerPurchasing; //Field offset: 0x1C
	public bool disallowHeroPurchasing; //Field offset: 0x1D

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public DisallowTowersUntilOnRound() { }

	public DisallowTowersUntilOnRound(int round, bool disallowTowerPurchasing, bool disallowHeroPurchasing) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

