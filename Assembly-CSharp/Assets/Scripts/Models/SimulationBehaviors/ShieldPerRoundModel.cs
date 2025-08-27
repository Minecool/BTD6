namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(ShieldPerRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ShieldPerRoundModel : SimulationBehaviorModel
{
	public float shieldPerRound; //Field offset: 0x30

	public ShieldPerRoundModel(string name, float shieldPerRound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

