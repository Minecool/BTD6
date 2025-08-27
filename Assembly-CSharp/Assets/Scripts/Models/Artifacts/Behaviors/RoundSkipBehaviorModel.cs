namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(RoundSkipBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RoundSkipBehaviorModel : ItemArtifactBehaviorModel
{
	public float endOfRoundCashMultiplier; //Field offset: 0x30

	public RoundSkipBehaviorModel(string name, float endOfRoundCashMultiplier) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

