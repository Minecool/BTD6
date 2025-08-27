namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels.EventSystem;

public class EventSystemModelData : CustomPrefabModelData<EntityEvent>
{
	public List<ActionData> actions; //Field offset: 0x50
	public List<TriggerData> triggers; //Field offset: 0x58

	public bool IsValid
	{
		 get { } //Length: 19
	}

	public EventSystemModelData() { }

	public void AddAction(EntityAction action) { }

	public void AddTrigger(EntityTrigger triggerToRemove) { }

	public bool get_IsValid() { }

	public void RemoveAction(EntityTrigger triggerToRemove) { }

	public void RemoveTrigger(EntityAction actionToRemove) { }

}

