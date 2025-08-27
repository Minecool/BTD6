namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(EnduranceRaceMode), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EnduranceRaceModeModel : SimulationBehaviorModel
{
	public int timeInSeconds; //Field offset: 0x30

	public EnduranceRaceModeModel(int timeInSeconds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

