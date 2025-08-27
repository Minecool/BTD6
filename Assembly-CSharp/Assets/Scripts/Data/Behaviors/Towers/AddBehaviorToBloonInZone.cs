namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "AddBehaviorToBloonInZone", menuName = "BTD6/Behaviors/Towers/AddBehaviorToBloonInZone")]
public class AddBehaviorToBloonInZone : TowerBehavior
{
	public float zoneRadius; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x40
	public BloonBehavior behavior; //Field offset: 0x48
	public string overlayType; //Field offset: 0x50
	public Filter[] filters; //Field offset: 0x58
	public bool bindRadiusToTowerRange; //Field offset: 0x60
	public float radiusOffset; //Field offset: 0x64

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 411
	}

	public AddBehaviorToBloonInZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

