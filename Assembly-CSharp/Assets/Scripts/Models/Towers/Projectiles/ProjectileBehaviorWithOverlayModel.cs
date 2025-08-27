namespace Assets.Scripts.Models.Towers.Projectiles;

public abstract class ProjectileBehaviorWithOverlayModel : ProjectileBehaviorModel
{
	public string overlayType; //Field offset: 0x38

	protected ProjectileBehaviorWithOverlayModel(string name, string overlayType) { }

}

