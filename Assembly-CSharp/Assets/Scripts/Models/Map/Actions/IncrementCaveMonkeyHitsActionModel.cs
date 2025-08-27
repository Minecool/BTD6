namespace Assets.Scripts.Models.Map.Actions;

[Implementation(typeof(IncrementCaveMonkeyHitsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncrementCaveMonkeyHitsActionModel : MapActionModel
{
	public int amount; //Field offset: 0x38

	public IncrementCaveMonkeyHitsActionModel(string name, int amount) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

