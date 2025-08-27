namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(HeroEndOfRoundXpScaleBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroEndOfRoundXpScaleBehaviorModel : ItemArtifactBehaviorModel
{
	public float scale; //Field offset: 0x30

	public HeroEndOfRoundXpScaleBehaviorModel(string name, float scale) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

