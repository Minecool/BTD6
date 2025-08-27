namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AddMapAssetsEvent), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddMapAssetsEventModel : SimulationBehaviorModel
{
	public bool disableAmbientMapFx; //Field offset: 0x30
	public PrefabReference[] fXPrefabs; //Field offset: 0x38

	public AddMapAssetsEventModel(bool disableAmbientMapFx, PrefabReference[] fXPrefabs) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

