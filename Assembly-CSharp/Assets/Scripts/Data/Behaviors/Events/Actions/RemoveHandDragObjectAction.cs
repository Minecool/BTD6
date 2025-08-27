namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class RemoveHandDragObjectAction : HudModifier
{
	public string handDragId; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public RemoveHandDragObjectAction() { }

	public virtual Model get_Model() { }

}

