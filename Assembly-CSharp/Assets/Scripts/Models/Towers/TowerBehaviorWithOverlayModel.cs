namespace Assets.Scripts.Models.Towers;

public abstract class TowerBehaviorWithOverlayModel : TowerBehaviorModel
{
	public string overlayType; //Field offset: 0x30

	protected TowerBehaviorWithOverlayModel(string name, string overlayType) { }

}

