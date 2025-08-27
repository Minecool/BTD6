namespace Assets.Scripts.Data.Behaviors.Events;

[CreateAssetMenu(fileName = "Entity Event", menuName = "BTD6/Behaviors/Entity Event", order = 1)]
[UIComponent("EntityEvent")]
public class EntityEvent : Behavior, IGameEditorAsset
{
	[JsonConverter(typeof(BehaviorConverter))]
	public EntityTrigger[] triggers; //Field offset: 0x28
	[JsonConverter(typeof(BehaviorConverter))]
	public EntityAction[] actions; //Field offset: 0x30
	public bool requiresAllTriggers; //Field offset: 0x38
	public int maxActivationLimit; //Field offset: 0x3C
	[UIVariableHidden]
	public int eventEntityIndex; //Field offset: 0x40

	public virtual Model Model
	{
		 get { } //Length: 147
	}

	public EntityEvent() { }

	public virtual Model get_Model() { }

}

