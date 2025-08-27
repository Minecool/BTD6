namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(DisallowTowersUntilOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DisallowTowersUntilOnRoundModel : SimulationBehaviorModel
{
	public int round; //Field offset: 0x30
	public bool disallowTowerPurchasing; //Field offset: 0x34
	public bool disallowHeroPurchasing; //Field offset: 0x35

	public DisallowTowersUntilOnRoundModel(int round, bool disallowTowerPurchasing, bool disallowHeroPurchasing) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

