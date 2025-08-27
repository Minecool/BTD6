namespace Assets.Scripts.Unity.UI_New.WorldInteractables;

public class WorldConfig
{
	public float friction; //Field offset: 0x10
	public float dragSensitivity; //Field offset: 0x14
	public float maxVelocity; //Field offset: 0x18
	public float xmin; //Field offset: 0x1C
	public float xmax; //Field offset: 0x20
	public float zmin; //Field offset: 0x24
	public float zmax; //Field offset: 0x28
	public float yPos; //Field offset: 0x2C
	public float xRotation; //Field offset: 0x30
	public float xStartCamPos; //Field offset: 0x34
	public float yStartCamPos; //Field offset: 0x38
	public float zStartCamPos; //Field offset: 0x3C
	public AnimationCurve cameraMoveEase; //Field offset: 0x40
	public float cameraMoveDuration; //Field offset: 0x48

	public WorldConfig() { }

}

