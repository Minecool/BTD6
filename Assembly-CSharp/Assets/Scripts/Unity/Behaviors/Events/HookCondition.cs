namespace Assets.Scripts.Unity.Behaviors.Events;

public class HookCondition : EntityEvent
{
	internal class EventHookContainer
	{
		[SerializeReference]
		public EntityTrigger[] eventTriggers; //Field offset: 0x10

		public EventHookContainer() { }

	}

	internal class HudModifierContainer
	{
		[SerializeReference]
		public EntityAction[] eventActions; //Field offset: 0x10

		public HudModifierContainer() { }

	}

	[ExtendedDrawer]
	[ReorderableList("Event Triggers", True)]
	[SerializeField]
	public EventHookContainer eventTriggerCont; //Field offset: 0x40
	[ExtendedDrawer]
	[ReorderableList("Event Actions", True)]
	[SerializeField]
	public HudModifierContainer hudModifierCont; //Field offset: 0x48

	public EntityAction[] EventActions
	{
		 get { } //Length: 27
	}

	public EntityTrigger[] EventTriggers
	{
		 get { } //Length: 27
	}

	public virtual Model Model
	{
		 get { } //Length: 261
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public HookCondition() { }

	public EntityAction[] get_EventActions() { }

	public EntityTrigger[] get_EventTriggers() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

