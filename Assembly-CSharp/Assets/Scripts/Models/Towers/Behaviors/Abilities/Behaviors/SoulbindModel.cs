namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Soulbind), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SoulbindModel : AbilityBehaviorModel
{
	public PrefabReference selectionObjectPath; //Field offset: 0x30
	public EffectModel soulbindEffectOnTargetModel; //Field offset: 0x38
	public PrefabReference soulbindEffectOnBoundTargetsId; //Field offset: 0x40

	public SoulbindModel(string name, PrefabReference selectionObjectPath, EffectModel soulbindEffectOnTargetModel, PrefabReference soulbindEffectOnBoundTargetsId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

