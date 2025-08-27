namespace Assets.Scripts.Data.Behaviors.Towers;

public class OrderedPrefabReferencesModel : Model
{
	public PrefabReference[] prefabReferences; //Field offset: 0x30

	public OrderedPrefabReferencesModel(PrefabReference[] prefabReferences) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

