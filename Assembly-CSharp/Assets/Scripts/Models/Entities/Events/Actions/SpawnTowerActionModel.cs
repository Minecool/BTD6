namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SpawnTowerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SpawnTowerActionModel : EntityActionModel
{
	public string towerId; //Field offset: 0x38
	public Int32[] tiers; //Field offset: 0x40

	public SpawnTowerActionModel(string name, string towerId, Int32[] tiers) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

