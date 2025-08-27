namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class CreatePlacementCircleAction : HudModifier
{
	public string placementId; //Field offset: 0x28
	public Vector2 position; //Field offset: 0x30
	public int radius; //Field offset: 0x38
	public ToggleModdifier blockPlacementOutsideCircle; //Field offset: 0x3C
	public bool hideOverlayIcon; //Field offset: 0x40

	public virtual Model Model
	{
		 get { } //Length: 179
	}

	public CreatePlacementCircleAction() { }

	public virtual Model get_Model() { }

}

