﻿Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace AgDataGrid_TotalSummary
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = ProductList.GetData()
		End Sub
	End Class
End Namespace
