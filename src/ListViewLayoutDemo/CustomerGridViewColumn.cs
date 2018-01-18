// -- FILE ------------------------------------------------------------------
// name       : CustomerGridViewColumn.cs
// created    : Jani Giannoudis - 2008.03.27
// language   : c#
// environment: .NET 3.0
// copyright  : (c) 2008-2012 by Itenso GmbH, Switzerland
// --------------------------------------------------------------------------
using Itenso.Windows.Controls.ListViewLayout;

namespace Itenso.Windows.Controls.ListViewLayoutDemo
{

	// ------------------------------------------------------------------------
	public enum CustomerColumn
	{
		FirstName,
		LastName,
		Address,
	} // enum CustomerColumn

	// ------------------------------------------------------------------------
	public class CustomerGridViewColumn : ConverterGridViewColumn
	{

		// ----------------------------------------------------------------------
		public CustomerGridViewColumn( CustomerColumn customerColumn, string header ) :
			base( typeof( Customer ) )
		{
			this.customerColumn = customerColumn;
			Header = header;
		} // CustomerGridViewColumn

		// ----------------------------------------------------------------------
		public CustomerColumn CustomerColumn
		{
			get { return customerColumn; }
		} // CustomerColumn

		// ----------------------------------------------------------------------
		protected override object ConvertValue( object value )
		{
			Customer customer = value as Customer;
			if ( customer == null )
			{
				return null;
			}

			switch ( customerColumn )
			{
				case CustomerColumn.FirstName:
					return customer.FirstName;
				case CustomerColumn.LastName:
					return customer.LastName;
				case CustomerColumn.Address:
					return string.Concat( customer.ZipCode, ", ", customer.City, ", ", customer.Street );
			}

			return null;
		} // ConvertValue

		// ----------------------------------------------------------------------
		// members
		private readonly CustomerColumn customerColumn;

	} // class CustomerGridViewColumn

} // namespace Itenso.Windows.Controls.ListViewLayoutDemo
// -- EOF -------------------------------------------------------------------
