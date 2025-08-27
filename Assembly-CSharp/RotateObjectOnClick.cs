//Type is in global namespace

public class RotateObjectOnClick : OnClickHandler
{
	public Vector3 axis; //Field offset: 0x50
	public float angle; //Field offset: 0x5C
	public float speed; //Field offset: 0x60
	public AnimationCurve curve; //Field offset: 0x68
	private float currentAngle; //Field offset: 0x70
	private float current; //Field offset: 0x74
	private Quaternion previous; //Field offset: 0x78

	public RotateObjectOnClick() { }

	public virtual void OnActivate() { }

	public virtual void Process() { }

}

