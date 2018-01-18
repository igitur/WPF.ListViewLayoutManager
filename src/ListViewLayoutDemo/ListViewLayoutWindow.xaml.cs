// -- FILE ------------------------------------------------------------------
// name       : ListViewLayoutWindow.xaml.cs
// created    : Jani Giannoudis - 2008.03.27
// language   : c#
// environment: .NET 3.0
// copyright  : (c) 2008-2012 by Itenso GmbH, Switzerland
// --------------------------------------------------------------------------
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Controls;
using System.Collections.Generic;
using Itenso.Windows.Controls.ListViewLayout;

namespace Itenso.Windows.Controls.ListViewLayoutDemo
{

	// ------------------------------------------------------------------------
	public partial class ListViewLayoutWindow
	{

		// ----------------------------------------------------------------------
		public ListViewLayoutWindow()
		{
			InitializeComponent();
			SetupCustomers( CustomerListView );
		} // ListViewLayoutWindow

		// ----------------------------------------------------------------------
		private void SetupCustomers( ListView listView )
		{
			new ListViewLayoutManager( listView ); // apply layout manager

			GridView gridView = new GridView();
			gridView.Columns.Add( FixedColumn.ApplyWidth( new CustomerStateGridViewColumn( "State" ), 25 ) );
			gridView.Columns.Add( ProportionalColumn.ApplyWidth( new CustomerGridViewColumn( CustomerColumn.FirstName, "Fist Name (Proportional=1)" ), 1 ) );
			gridView.Columns.Add( ProportionalColumn.ApplyWidth( new CustomerGridViewColumn( CustomerColumn.LastName, "Last Name (Proportional=1)" ), 1 ) );
			gridView.Columns.Add( ProportionalColumn.ApplyWidth( new CustomerGridViewColumn( CustomerColumn.Address, "Address (Proportional=2)" ), 2 ) );

			listView.View = gridView;
			listView.ItemsSource = Customers;
		} // SetupCustomers

		// ----------------------------------------------------------------------
		private IEnumerable<Customer> Customers
		{
			get
			{
				if ( customers == null )
				{
					customers = new ObservableCollection<Customer>();
					for ( int i = 0; i < 100; i++ )
					{
						string userId = ( i + 1 ).ToString( CultureInfo.InvariantCulture );
						CustomerState state = (CustomerState)( i % 3 );
						Customer customer = new Customer(
							"FisrtName" + userId,
							"LastName" + userId,
							"Street" + userId,
							"City" + userId,
							"ZipCode" + userId,
							state );

						customers.Add( customer );
					}
				}
				return customers;
			}
		} // LoadCustomers

		// ----------------------------------------------------------------------
		// members
		private ObservableCollection<Customer> customers;

	} // class ListViewLayoutWindow

} // namespace Itenso.Windows.Controls.ListViewLayoutDemo
// -- EOF -------------------------------------------------------------------
