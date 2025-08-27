namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class CreatePlacementCircleAction : HudModifier
{
	public string placementId; //Field offset: 0x18
	public Vector2 position; //Field offset: 0x20
	public int radius; //Field offset: 0x28
	public ToggleModdifier blockPlacementOutsideCircle; //Field offset: 0x2C
	public bool hideOverlayIcon; //Field offset: 0x30

	public virtual Model Model
	{
		 get { } //Length: 179
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public CreatePlacementCircleAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

