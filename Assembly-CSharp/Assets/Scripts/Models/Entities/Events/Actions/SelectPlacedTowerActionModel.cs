namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(SelectPlacedTowerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SelectPlacedTowerActionModel : EntityActionModel
{
	[TowerType]
	public string tower; //Field offset: 0x38
	public ToggleModdifier showTowerSelectionPanel; //Field offset: 0x40
	public Vector2 selectTowerAtPosition; //Field offset: 0x44
	public int giftTowerXp; //Field offset: 0x4C

	public SelectPlacedTowerActionModel(string name, string tower, Vector2 selectTowerAtPosition, ToggleModdifier showTowerSelectionPanel, int giftTowerXp) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

