namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(AmbushTech), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AmbushTechModel : AbilityBehaviorModel
{
	public PrefabReference displayPath; //Field offset: 0x30
	public float radius; //Field offset: 0x38

	public AmbushTechModel(string name, PrefabReference displayPath, float radius) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

