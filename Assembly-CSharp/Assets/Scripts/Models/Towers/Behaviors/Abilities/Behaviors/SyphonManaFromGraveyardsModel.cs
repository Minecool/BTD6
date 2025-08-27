namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(SyphonManaFromGraveyards), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SyphonManaFromGraveyardsModel : AbilityBehaviorModel
{
	public float percent; //Field offset: 0x30

	public SyphonManaFromGraveyardsModel(string name, float percent) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

