namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(CashRushGameMode), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CashRushGameModeModel : SimulationBehaviorModel
{
	public int cashGoal; //Field offset: 0x30

	public CashRushGameModeModel(int cashGoal) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

