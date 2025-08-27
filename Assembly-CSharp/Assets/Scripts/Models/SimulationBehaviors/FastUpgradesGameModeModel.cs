namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(FastUpgradesGameMode), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FastUpgradesGameModeModel : SimulationBehaviorModel
{
	public int maxTier; //Field offset: 0x30
	public FastUpgradesType fastUpgradesModeType; //Field offset: 0x34

	public FastUpgradesGameModeModel(int maxTier, FastUpgradesType fastUpgradesModeType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

