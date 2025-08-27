namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "OrderedPrefabReferences", menuName = "BTD6/Behaviors/Towers/OrderedPrefabReferences")]
public class OrderedPrefabReferences : Behavior<OrderedPrefabReferencesModel>
{
	public PrefabReference[] prefabReferences; //Field offset: 0x28

	public virtual OrderedPrefabReferencesModel Def
	{
		 get { } //Length: 157
	}

	public virtual Model Model
	{
		 get { } //Length: 20
	}

	public OrderedPrefabReferences() { }

	public virtual OrderedPrefabReferencesModel get_Def() { }

	public virtual Model get_Model() { }

}

