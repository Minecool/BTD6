namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateEffectOnPop), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnPopModel : BloonBehaviorModelWithTowerTracking
{
	public EffectModel effectModel; //Field offset: 0x38
	public bool ignoreSameFrameDegrade; //Field offset: 0x40

	public CreateEffectOnPopModel() { }

	public CreateEffectOnPopModel(string name, EffectModel effectModel, bool ignoreSameFrameDegrade, ObjectId tower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

