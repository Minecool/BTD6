namespace Assets.Scripts.Unity.Gamepad.Nav;

public class ExplicitNearest
{

	public ExplicitNearest() { }

	public Selectable FindSelectable(Selectable src, Vector3 dir, List<Selectable> s_List) { }

	public override Selectable FindSelectableOnDown(Selectable src, List<Selectable> s_List) { }

	public override Selectable FindSelectableOnLeft(Selectable src, List<Selectable> s_List) { }

	public override Selectable FindSelectableOnRight(Selectable src, List<Selectable> s_List) { }

	public override Selectable FindSelectableOnUp(Selectable src, List<Selectable> s_List) { }

	private Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

}

