namespace Assets.Scripts.Unity.Gamepad.Nav;

public class NavCell
{
	public Mode mode; //Field offset: 0x10
	public Transform[] containers; //Field offset: 0x18
	public List<Selectable> selectables; //Field offset: 0x20
	public List<Selectable> navLeft; //Field offset: 0x28
	public List<Selectable> navRight; //Field offset: 0x30
	public List<Selectable> navUp; //Field offset: 0x38
	public List<Selectable> navDown; //Field offset: 0x40

	public NavCell(Mode mode, Transform[] containers) { }

	public NavCell(Transform[] containers) { }

}

