namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(CreatePlacementCircleAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreatePlacementCircleActionModel : EntityActionModel
{
	public string placementId; //Field offset: 0x38
	public Vector2 position; //Field offset: 0x40
	public int radius; //Field offset: 0x48
	public ToggleModdifier blockPlacementOutsideCircle; //Field offset: 0x4C
	public bool hideOverlayIcon; //Field offset: 0x50

	public Vector3 positionV3
	{
		 get { } //Length: 49
	}

	public CreatePlacementCircleActionModel(string name, string placementId, Vector2 position, int radius, ToggleModdifier blockPlacementOutsideCircle, bool hideOverlayIcon) { }

	public virtual Model Clone() { }

	public Vector3 get_positionV3() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

