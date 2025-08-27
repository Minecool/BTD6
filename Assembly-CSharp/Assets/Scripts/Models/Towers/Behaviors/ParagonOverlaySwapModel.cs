namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ParagonOverlaySwap), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ParagonOverlaySwapModel : TowerBehaviorWithOverlayModel
{
	public string mutatorId; //Field offset: 0x38
	public int displayDegree; //Field offset: 0x40
	public bool applyToAllAbove; //Field offset: 0x44

	public ParagonOverlaySwapModel(string name, string overlayType, string mutatorId, int displayDegree, bool applyToAllAbove) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

