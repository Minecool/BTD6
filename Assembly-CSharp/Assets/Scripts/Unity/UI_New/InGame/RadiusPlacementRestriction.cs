namespace Assets.Scripts.Unity.UI_New.InGame;

public class RadiusPlacementRestriction : PlacementRestriction
{
	private Vector2 center; //Field offset: 0x10
	private float radius; //Field offset: 0x18

	public RadiusPlacementRestriction(Vector2 center, float radius) { }

	public override bool CanPlace(Vector2 towerPositionWorld, TowerModel placementModel) { }

}

