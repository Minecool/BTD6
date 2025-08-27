namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AwardCashOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AwardCashOnRoundModel : SimulationBehaviorModel
{
	public int round; //Field offset: 0x30
	public int cashAmount; //Field offset: 0x34

	public AwardCashOnRoundModel(int round, int cashAmount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

