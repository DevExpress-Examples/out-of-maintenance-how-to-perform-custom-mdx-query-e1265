Imports Microsoft.VisualBasic
Imports System
Namespace HowToDisplayMDXQueryResults
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.pivotGridField1, Me.pivotGridField2, Me.pivotGridField3})
			Me.pivotGridControl1.Location = New System.Drawing.Point(13, 42)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(506, 311)
			Me.pivotGridControl1.TabIndex = 0
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(13, 13)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(110, 23)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Query Server"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' pivotGridField1
			' 
			Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.pivotGridField1.AreaIndex = 0
			Me.pivotGridField1.Caption = "Internet Sales Amount"
			Me.pivotGridField1.CellFormat.FormatString = "c2"
			Me.pivotGridField1.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
			Me.pivotGridField1.FieldName = "[Measures].[Internet Sales Amount]"
			Me.pivotGridField1.Name = "pivotGridField1"
			' 
			' pivotGridField2
			' 
			Me.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField2.AreaIndex = 0
			Me.pivotGridField2.Caption = "Group"
			Me.pivotGridField2.FieldName = "[Sales Territory].[Sales Territory Group].[Sales Territory Group].[MEMBER_CAPTION" & "]"
			Me.pivotGridField2.Name = "pivotGridField2"
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField3.AreaIndex = 1
			Me.pivotGridField3.Caption = "Country"
			Me.pivotGridField3.FieldName = "[Sales Territory].[Sales Territory Country].[Sales Territory Country].[MEMBER_CAP" & "TION]"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(531, 365)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField2 As DevExpress.XtraPivotGrid.PivotGridField
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

