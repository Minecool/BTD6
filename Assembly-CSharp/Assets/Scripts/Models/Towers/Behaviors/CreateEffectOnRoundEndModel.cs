namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnRoundEnd), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnRoundEndModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30

	public CreateEffectOnRoundEndModel(string name, EffectModel effectModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

