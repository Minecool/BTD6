namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SlowBloonsZone", menuName = "BTD6/Behaviors/Towers/SlowBloonsZone")]
public class SlowBloonsZone : TowerBehavior
{
	public float zoneRadius; //Field offset: 0x30
	public string mutationId; //Field offset: 0x38
	public bool isUnique; //Field offset: 0x40
	public float speedScale; //Field offset: 0x44
	public float speedChange; //Field offset: 0x48
	public bool bindRadiusToTowerRange; //Field offset: 0x4C
	public float radiusOffset; //Field offset: 0x50
	public string bloonTag; //Field offset: 0x58
	public bool inclusive; //Field offset: 0x60
	public Filter[] filters; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 302
	}

	public SlowBloonsZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

