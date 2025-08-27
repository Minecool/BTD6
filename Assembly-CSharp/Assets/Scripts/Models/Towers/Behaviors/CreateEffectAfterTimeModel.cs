namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectAfterTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectAfterTimeModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	[SerializeField]
	private float lifespan; //Field offset: 0x38
	public int lifespanFrames; //Field offset: 0x3C
	public bool useRoundTime; //Field offset: 0x40

	public CreateEffectAfterTimeModel(string name, EffectModel effectModel, float lifespan, bool useRoundTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

