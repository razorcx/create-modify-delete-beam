using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace CreateBeam
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void CreateBeam2_Click(object sender, EventArgs e)
		{
			var model = new Model();

			var point = new Point(0, 3000, 0);
			var point2 = new Point(6000, 3000, 0);
			var profile = new Profile { ProfileString = "W16X50" };
			var material = new Material { MaterialString = "300W" };
			var finish = "NO PAINT";
			var theClass = "4";

			var beam = new Beam
			{
				StartPoint = point,
				EndPoint = point2,
				Profile = profile,
				Finish = finish,
				Class = theClass,
				Material = material,
				StartPointOffset = new Offset(),
				EndPointOffset = new Offset()
			};

			var success = beam.Insert();

			if (success)
				model.CommitChanges();
		}
	}
}
