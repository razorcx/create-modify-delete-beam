using System;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;

namespace CreateBeam
{
	public partial class Form1 : Form
	{
		private Beam _beam;
		private readonly Model _model = new Model();

		public Form1()
		{
			InitializeComponent();
		}

		private void CreateBeam2_Click(object sender, EventArgs e)
		{
			//default values
			var point = new Point(0, 3000, 0);
			var point2 = new Point(6000, 3000, 0);
			var profile = new Profile { ProfileString = "W16X50" };
			var material = new Material { MaterialString = "300W" };
			var finish = "NO PAINT";
			var theClass = "4";

			//use values from user input
			if (!string.IsNullOrEmpty(txtBoxProfile.Text))
				profile = new Profile {ProfileString = txtBoxProfile.Text};

			if (!string.IsNullOrEmpty(txtBoxMaterial.Text))
				material = new Material { MaterialString = txtBoxMaterial.Text };

			if (!string.IsNullOrEmpty(txtBoxFinish.Text))
				finish = txtBoxFinish.Text;

			if (!string.IsNullOrEmpty(txtBoxClass.Text))
				theClass = txtBoxClass.Text;

			//create the beam
			_beam = new Beam
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

			//insert beam in model
			var success = _beam.Insert();

			if (success)
				_model.CommitChanges();
		}

		private void btnDeleteBeam_Click(object sender, EventArgs e)
		{
			if (_beam == null) return;

			//remove beam from model
			var success = _beam.Delete();
			if (success)
				_model.CommitChanges();
		}

		private void btnModifyBeam_Click(object sender, EventArgs e)
		{
			if (_beam == null) return;

			_beam.Select();

			//check if values have changed and modify beam
			if (!string.IsNullOrEmpty(txtBoxProfile.Text) && 
				txtBoxProfile.Text != _beam.Profile.ProfileString)
					_beam.Profile.ProfileString = txtBoxProfile.Text;

			if (!string.IsNullOrEmpty(txtBoxMaterial.Text) 
				&& txtBoxMaterial.Text != _beam.Material.MaterialString)
					_beam.Material.MaterialString = txtBoxMaterial.Text;

			if (!string.IsNullOrEmpty(txtBoxFinish.Text) && 
				txtBoxFinish.Text != _beam.Finish)
					_beam.Finish = txtBoxFinish.Text;

			if (!string.IsNullOrEmpty(txtBoxClass.Text) && 
				txtBoxClass.Text != _beam.Class)
					_beam.Class = txtBoxClass.Text;

			var success = _beam.Modify();
			if (success)
				_model.CommitChanges();
		}
	}
}
