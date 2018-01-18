// -- FILE ------------------------------------------------------------------
// name       : Customer.cs
// created    : Jani Giannoudis - 2008.03.27
// language   : c#
// environment: .NET 3.0
// copyright  : (c) 2008-2012 by Itenso GmbH, Switzerland
// --------------------------------------------------------------------------

namespace Itenso.Windows.Controls.ListViewLayoutDemo
{

	// ------------------------------------------------------------------------
	public enum CustomerState
	{
		New,
		Approved,
		Denied,
	} // CustomerState

	// ------------------------------------------------------------------------
	public class Customer
	{

		// ----------------------------------------------------------------------
		public Customer()
		{
		} // Customer

		// ----------------------------------------------------------------------
		public Customer( string firstName, string lastName, string street, 
			string city, string zipCode, CustomerState state )
		{
			FirstName = firstName;
			LastName = lastName;
			Street = street;
			City = city;
			ZipCode = zipCode;
			State = state;
		} // Customer

		// ----------------------------------------------------------------------
		public string FirstName { get; set; }

		// ----------------------------------------------------------------------
		public string LastName { get; set; }

		// ----------------------------------------------------------------------
		public string Street { get; set; }

		// ----------------------------------------------------------------------
		public string City { get; set; }

		// ----------------------------------------------------------------------
		public string ZipCode { get; set; }

		// ----------------------------------------------------------------------
		public CustomerState State { get; set; }

	} // class Customer

} // namespace Itenso.Windows.Controls.ListViewLayoutDemo
// -- EOF -------------------------------------------------------------------
