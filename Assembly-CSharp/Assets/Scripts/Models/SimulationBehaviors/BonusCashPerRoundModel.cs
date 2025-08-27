namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(BonusCashPerRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BonusCashPerRoundModel : SimulationBehaviorModel
{
	public float roundMultiple; //Field offset: 0x30
	public float baseCash; //Field offset: 0x34

	public BonusCashPerRoundModel(string name, float roundMultiple, float baseCash) { }

	public virtual Model Clone() { }

	public float GetCashForRound(int roundArrayIndex) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

