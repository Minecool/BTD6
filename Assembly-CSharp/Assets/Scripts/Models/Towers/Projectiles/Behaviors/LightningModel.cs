namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Lightning), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class LightningModel : ProjectileBehaviorModel
{
	public int splits; //Field offset: 0x38
	public EmissionModel emissionModel; //Field offset: 0x40
	public float splitRange; //Field offset: 0x48
	[SerializeField]
	private float delay; //Field offset: 0x4C
	public int delayFrames; //Field offset: 0x50

	public LightningModel(string name, int targets, EmissionModel emissionModel, float splitRange, float delay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

