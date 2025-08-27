namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(HeroXpPerBloonLayerBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HeroXpPerBloonLayerBehaviorModel : ItemArtifactBehaviorModel
{
	public float xpPerLayer; //Field offset: 0x30

	public HeroXpPerBloonLayerBehaviorModel(string name, float xpPerLayer) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

