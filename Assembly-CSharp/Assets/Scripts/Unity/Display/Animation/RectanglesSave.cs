namespace Assets.Scripts.Unity.Display.Animation;

public class RectanglesSave
{
	private const int stride = 4; //Field offset: 0x0
	private const int xMinOffset = 0; //Field offset: 0x0
	private const int xMaxOffset = 1; //Field offset: 0x0
	private const int yMinOffset = 2; //Field offset: 0x0
	private const int yMaxOffset = 3; //Field offset: 0x0
	public Single[] flatRectangeData; //Field offset: 0x10

	public RectanglesSave() { }

	public RectanglesSave(Rect[] rectangles) { }

	public Rect[] GetRectArray() { }

	public void SetRectArray(Rect[] rectangles) { }

}

