namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(EndOfRoundCashBoostBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EndOfRoundCashBoostBehaviorModel : BoostArtifactBehaviorModel
{
	public int amount; //Field offset: 0x38

	public EndOfRoundCashBoostBehaviorModel(string name, float multiplier, int amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

