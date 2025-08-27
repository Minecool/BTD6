namespace Assets.Scripts.Unity.Map.Triggers;

public class RotateAreaAction : MapAction
{
	public Area area; //Field offset: 0x20
	public float rotation; //Field offset: 0x28
	public float duration; //Field offset: 0x2C
	public RotateModelAction[] rotateModelActions; //Field offset: 0x30
	public AudioClip startSound; //Field offset: 0x38
	public AudioClip stopSound; //Field offset: 0x40
	private RotateAreaActionModel def; //Field offset: 0x48

	public virtual MapActionModel Def
	{
		 get { } //Length: 384
	}

	public RotateAreaAction() { }

	public virtual MapActionModel get_Def() { }

}

