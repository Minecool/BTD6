namespace Assets.Scripts.Simulation.Movement;

public class TrackTargetParameters
{
	public float distance; //Field offset: 0x10
	public float tolerance; //Field offset: 0x14
	public float acceleration; //Field offset: 0x18
	public float speed; //Field offset: 0x1C
	public float minSpeed; //Field offset: 0x20
	public float maxSpeed; //Field offset: 0x24
	public float rotation; //Field offset: 0x28
	public float accelerateInAngle; //Field offset: 0x2C
	public float startDeceleratingIfAngleGreaterThan; //Field offset: 0x30

	public TrackTargetParameters() { }

	public float ClampRotation(float angle) { }

	public float ClampSpeed(float speed) { }

}

