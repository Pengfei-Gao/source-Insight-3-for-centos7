public class DataGridViewRowDividerDoubleClickEventArgs : HandledMouseEventArgs
{

	// Constructors
	public DataGridViewRowDividerDoubleClickEventArgs(int rowIndex, HandledMouseEventArgs e) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public bool Handled { get{} set{} }
	public MouseButtons Button { get{} }
	public int Clicks { get{} }
	public int X { get{} }
	public int Y { get{} }
	public int Delta { get{} }
	public System.Drawing.Point Location { get{} }
}

