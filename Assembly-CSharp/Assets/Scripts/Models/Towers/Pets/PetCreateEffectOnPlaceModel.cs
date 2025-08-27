namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(PetCreateEffectOnPlace), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetCreateEffectOnPlaceModel : PetBehaviorModel
{
	public PrefabReference Effect; //Field offset: 0x30
	public float Lifespan; //Field offset: 0x38

	public PetCreateEffectOnPlaceModel(string name, PrefabReference effect, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

