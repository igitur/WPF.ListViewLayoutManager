# WPF.ListViewLayoutManager

Using a `ListViewLayoutManager` allows controlling the behavior of the column layout of `ListView/GridView` controls:

- Fixed Column: Column with fixed column width
- Range Column: Column with minimal and/or maximal column width
- Proportional Column: Column with proportional column width

The *Range Column* allows to restrict the column width as well as to fill the remaining visible area with the column.

As known from HTML tables or the `Grid` control, the *Proportional Column* determines the column widths on a percentage basis. The following factors determine the width of a proportional column:

- Visibility of the vertical `ListView` scrollbars
- Changes of the `ListView` control width
- Changes of the width of a non-proportional column

The implementation supports both controlling through XAML or Code Behind. Usage of XAML styles allows a `ListViewLayoutManager` to be 'attached' to an existing `ListView` control.

The class `ConverterGridColumn` offers object specific binding by using the interface `IValueConverter`. Using the `ImageGridViewColumn` class allows representing a column as an image/icon using a `DataTemplate`.
