namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class RemoveHandDragObjectAction : HudModifier
{
	public string handDragId; //Field offset: 0x18

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public RemoveHandDragObjectAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

