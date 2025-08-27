namespace Poly2Tri;

public class TriangulationConstraint : Edge
{
	private uint mContraintCode; //Field offset: 0x20

	public uint ConstraintCode
	{
		 get { } //Length: 4
	}

	public TriangulationPoint P
	{
		 get { } //Length: 130
		 set { } //Length: 76
	}

	public TriangulationPoint Q
	{
		 get { } //Length: 130
		 set { } //Length: 76
	}

	public TriangulationConstraint(TriangulationPoint p1, TriangulationPoint p2) { }

	public void CalculateContraintCode() { }

	public static uint CalculateContraintCode(TriangulationPoint p, TriangulationPoint q) { }

	public uint get_ConstraintCode() { }

	public TriangulationPoint get_P() { }

	public TriangulationPoint get_Q() { }

	public void set_P(TriangulationPoint value) { }

	public void set_Q(TriangulationPoint value) { }

	public virtual string ToString() { }

}

