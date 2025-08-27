namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class CreateHandDragObjectAction : HudModifier
{
	public string handDragId; //Field offset: 0x18
	[TowerType]
	public string towerToDragId; //Field offset: 0x20
	public Vector2 optionalPickupPosition; //Field offset: 0x28
	public Vector2 dropPosition; //Field offset: 0x30
	public ToggleModdifier hasEndHandDrag; //Field offset: 0x38

	public virtual Model Model
	{
		 get { } //Length: 213
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public CreateHandDragObjectAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

