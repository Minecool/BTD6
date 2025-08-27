namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(PetCreateEffectOnSell), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetCreateEffectOnSellModel : PetBehaviorModel
{
	public PrefabReference Effect; //Field offset: 0x30
	public float Lifespan; //Field offset: 0x38

	public PetCreateEffectOnSellModel(string name, PrefabReference effect, float lifespan) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

