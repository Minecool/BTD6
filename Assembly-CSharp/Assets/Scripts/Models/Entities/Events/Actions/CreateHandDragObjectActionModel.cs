namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(CreateHandDragObjectAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateHandDragObjectActionModel : EntityActionModel
{
	public string handDragId; //Field offset: 0x38
	public Vector2 startPosition; //Field offset: 0x40
	public Vector2 endPosition; //Field offset: 0x48
	public ToggleModdifier hasEndHandDrag; //Field offset: 0x50
	[TowerType]
	public string towerToDragId; //Field offset: 0x58

	public CreateHandDragObjectActionModel(string name, string handDragId, Vector2 startPosition, Vector2 endPosition, ToggleModdifier hasEndHandDrag, string towerToDragId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

