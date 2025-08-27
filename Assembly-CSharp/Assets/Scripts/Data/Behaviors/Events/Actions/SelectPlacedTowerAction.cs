namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class SelectPlacedTowerAction : HudModifier
{
	public Vector2 selectTowerAtPosition; //Field offset: 0x28
	[TowerType]
	public string tower; //Field offset: 0x30
	public ToggleModdifier showTowerSelectionPanel; //Field offset: 0x38
	public int giftTowerXp; //Field offset: 0x3C

	public virtual Model Model
	{
		 get { } //Length: 175
	}

	public SelectPlacedTowerAction() { }

	public virtual Model get_Model() { }

}

