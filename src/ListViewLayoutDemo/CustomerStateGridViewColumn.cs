// -- FILE ------------------------------------------------------------------
// name       : CustomerStateGridViewColumn.cs
// created    : Jani Giannoudis - 2008.03.27
// language   : c#
// environment: .NET 3.0
// copyright  : (c) 2008-2012 by Itenso GmbH, Switzerland
// --------------------------------------------------------------------------
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Itenso.Windows.Controls.ListViewLayout;

namespace Itenso.Windows.Controls.ListViewLayoutDemo
{

	// ------------------------------------------------------------------------
	public class CustomerStateGridViewColumn : ImageGridViewColumn
	{

		// ----------------------------------------------------------------------
		public CustomerStateGridViewColumn( string header )
		{
			Header = header;
		} // CustomerStateGridViewColumn

		// ----------------------------------------------------------------------
		protected override ImageSource GetImageSource( object value )
		{
			Customer customer = value as Customer;
			if ( customer != null )
			{
				string imageUri = string.Concat(
					packName,
					GetType().Namespace,
					resourcePath,
					"CustomerState",
					Enum.GetName( typeof( CustomerState ), customer.State ),
					resourceImageExtension );
				return new BitmapImage( new Uri( imageUri ) );
			}
			
			return null;
		} // GetImageSource

		// ----------------------------------------------------------------------
		// members
		private const string packName = "pack://application:,,,/";
		private const string resourcePath = ";Component/Resources/";
		private const string resourceImageExtension = ".png";

	} // class CustomerStateGridViewColumn

} // namespace Itenso.Windows.Controls.ListViewLayoutDemo
// -- EOF -------------------------------------------------------------------
