namespace Poly2Tri;

public class PolygonSet
{
	protected List<Polygon> _polygons; //Field offset: 0x10

	public IEnumerable<Polygon> Polygons
	{
		 get { } //Length: 5
	}

	public PolygonSet() { }

	public PolygonSet(Polygon poly) { }

	public void Add(Polygon p) { }

	public IEnumerable<Polygon> get_Polygons() { }

}

