namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class CreateHandDragObjectAction : HudModifier
{
	public string handDragId; //Field offset: 0x28
	public Vector2 startPosition; //Field offset: 0x30
	public Vector2 endPosition; //Field offset: 0x38
	public ToggleModdifier hasEndHandDrag; //Field offset: 0x40
	[TowerType]
	public string towerToDragId; //Field offset: 0x48

	public virtual Model Model
	{
		 get { } //Length: 213
	}

	public CreateHandDragObjectAction() { }

	public virtual Model get_Model() { }

}

