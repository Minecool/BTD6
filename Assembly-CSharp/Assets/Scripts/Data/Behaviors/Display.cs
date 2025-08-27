namespace Assets.Scripts.Data.Behaviors;

[CreateAssetMenu(fileName = "Display", menuName = "BTD6/Behaviors/Display")]
public class Display : EntityBehavior<DisplayModel>
{
	public PrefabReference display; //Field offset: 0x28
	public int layer; //Field offset: 0x30
	public DisplayCategory category; //Field offset: 0x34
	public Vector3 positionOffset; //Field offset: 0x38
	public float scale; //Field offset: 0x44
	public bool ignoreRotation; //Field offset: 0x48
	public float delayedReveal; //Field offset: 0x4C
	public bool isAnimationPaused; //Field offset: 0x50

	public virtual DisplayModel Def
	{
		 get { } //Length: 260
	}

	public Display() { }

	public virtual DisplayModel get_Def() { }

}

