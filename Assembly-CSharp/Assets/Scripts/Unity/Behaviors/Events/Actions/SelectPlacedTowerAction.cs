namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class SelectPlacedTowerAction : HudModifier
{
	public Vector2 selectTowerAtPosition; //Field offset: 0x18
	[TowerType]
	public string tower; //Field offset: 0x20
	public ToggleModdifier showTowerSelectionPanel; //Field offset: 0x28
	public int giftTowerXp; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 175
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public SelectPlacedTowerAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

	public virtual void ModifyHud(HookCondition condition, object metadata) { }

}

