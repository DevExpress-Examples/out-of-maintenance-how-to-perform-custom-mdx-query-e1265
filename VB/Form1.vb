Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.OleDb

Namespace HowToDisplayMDXQueryResults
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim connectionString As String = "Provider=msolap;Initial Catalog=Adventure Works DW Standard Edition;Data Source=local\sql2005", query As String = "select" & ControlChars.CrLf & "non empty " & ControlChars.CrLf & "{ [Measures].[Internet Sales Amount] } on columns," & ControlChars.CrLf & "non empty " & ControlChars.CrLf & "{ [Sales Territory].[Sales Territory Group].[Sales Territory Group].members } *" & ControlChars.CrLf & "{ [Sales Territory].[Sales Territory Country].[Sales Territory Country].members } on rows" & ControlChars.CrLf & "from [Adventure Works]"
			Using connection As New OleDbConnection(connectionString)
				connection.Open()
				Using command As OleDbCommand = connection.CreateCommand()
					command.CommandText = query
					pivotGridControl1.DataSource = ReadQueryResult(command)
				End Using
			End Using
		End Sub
		Protected Function ReadQueryResult(ByVal command As OleDbCommand) As DataTable
			Dim table As New DataTable()
			Using reader As OleDbDataReader = command.ExecuteReader()
				For i As Integer = 0 To reader.FieldCount - 1
					table.Columns.Add(reader.GetName(i), reader.GetFieldType(i))
				Next i
				Dim values(reader.FieldCount - 1) As Object
				Do While reader.Read()
					reader.GetValues(values)
					table.Rows.Add(values)
				Loop
			End Using
			Return table
		End Function
	End Class
End Namespace