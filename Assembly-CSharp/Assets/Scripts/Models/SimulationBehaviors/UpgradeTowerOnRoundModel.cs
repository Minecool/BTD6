namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(UpgradeTowerOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class UpgradeTowerOnRoundModel : SimulationBehaviorModel
{
	public UpgradeTowerOnRoundData[] upgradeOnRoundData; //Field offset: 0x30

	public UpgradeTowerOnRoundModel(UpgradeTowerOnRoundData[] upgradeOnRoundData) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

