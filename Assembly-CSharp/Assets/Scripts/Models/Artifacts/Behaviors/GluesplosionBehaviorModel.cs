namespace Assets.Scripts.Models.Artifacts.Behaviors;

[Implementation(typeof(GluesplosionBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GluesplosionBehaviorModel : ItemArtifactBehaviorModel
{
	[SerializeField]
	public string damageType; //Field offset: 0x30
	[ExtendedDrawer]
	[SerializeField]
	public EffectModel effectModel; //Field offset: 0x38
	[SerializeField]
	public int bloonCount; //Field offset: 0x40
	[SerializeField]
	public float range; //Field offset: 0x44

	public GluesplosionBehaviorModel(string name, string damageType, EffectModel effectModel, int bloonCount, float range) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

