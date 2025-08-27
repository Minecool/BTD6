namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateEffectOnAirUnit), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateEffectOnAirUnitModel : TowerBehaviorModel
{
	public EffectModel effectModel; //Field offset: 0x30
	public float rotation; //Field offset: 0x38
	public float scale; //Field offset: 0x3C
	public DisplayCategory displayCategory; //Field offset: 0x40

	public CreateEffectOnAirUnitModel(string name, EffectModel effectModel, float rotation, float scale, DisplayCategory displayCategory = 32) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

