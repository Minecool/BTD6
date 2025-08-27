namespace Assets.Scripts.Models.Towers.Mutators;

[Implementation(typeof(ProjectileSizeTowerMutator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ProjectileSizeTowerMutatorModel : TowerMutatorModel
{
	public float sizeModifier; //Field offset: 0x40
	public float assetSizeModifier; //Field offset: 0x44
	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C

	public ProjectileSizeTowerMutatorModel(string name, ConditionalModel conditionalId, string mutationId, float sizeModifier, float assetSizeModifier, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

