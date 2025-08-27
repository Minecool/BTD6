namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(EnergisingTotemBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class EnergisingTotemBehaviorModel : TowerBehaviorModel
{
	public int rounds; //Field offset: 0x30
	public int monkeyMoneyCost; //Field offset: 0x34
	public Int32[] animationStates; //Field offset: 0x38
	public EffectModel[] effectModels; //Field offset: 0x40

	public EnergisingTotemBehaviorModel(string name, int rounds, int monkeyMoneyCost, Int32[] animationStates, EffectModel[] effectModels) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

