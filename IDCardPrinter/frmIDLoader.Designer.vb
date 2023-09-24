<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIDLoader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRangeFrom = New System.Windows.Forms.TextBox
        Me.txtRangeTo = New System.Windows.Forms.TextBox
        Me.lblIDRange = New System.Windows.Forms.Label
        Me.btnProcessReport = New System.Windows.Forms.Button
        Me.idviewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'txtRangeFrom
        '
        Me.txtRangeFrom.Location = New System.Drawing.Point(123, 17)
        Me.txtRangeFrom.Name = "txtRangeFrom"
        Me.txtRangeFrom.Size = New System.Drawing.Size(100, 20)
        Me.txtRangeFrom.TabIndex = 0
        '
        'txtRangeTo
        '
        Me.txtRangeTo.Location = New System.Drawing.Point(238, 17)
        Me.txtRangeTo.Name = "txtRangeTo"
        Me.txtRangeTo.Size = New System.Drawing.Size(100, 20)
        Me.txtRangeTo.TabIndex = 1
        '
        'lblIDRange
        '
        Me.lblIDRange.AutoSize = True
        Me.lblIDRange.Location = New System.Drawing.Point(36, 20)
        Me.lblIDRange.Name = "lblIDRange"
        Me.lblIDRange.Size = New System.Drawing.Size(53, 13)
        Me.lblIDRange.TabIndex = 2
        Me.lblIDRange.Text = "ID Range"
        '
        'btnProcessReport
        '
        Me.btnProcessReport.Location = New System.Drawing.Point(366, 15)
        Me.btnProcessReport.Name = "btnProcessReport"
        Me.btnProcessReport.Size = New System.Drawing.Size(163, 23)
        Me.btnProcessReport.TabIndex = 3
        Me.btnProcessReport.Text = "Process Report"
        Me.btnProcessReport.UseVisualStyleBackColor = True
        '
        'idviewer
        '
        Me.idviewer.ActiveViewIndex = -1
        Me.idviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idviewer.Location = New System.Drawing.Point(3, 54)
        Me.idviewer.Name = "idviewer"
        Me.idviewer.SelectionFormula = ""
        Me.idviewer.Size = New System.Drawing.Size(919, 409)
        Me.idviewer.TabIndex = 4
        Me.idviewer.ViewTimeSelectionFormula = ""
        '
        'frmIDLoader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 468)
        Me.Controls.Add(Me.idviewer)
        Me.Controls.Add(Me.btnProcessReport)
        Me.Controls.Add(Me.lblIDRange)
        Me.Controls.Add(Me.txtRangeTo)
        Me.Controls.Add(Me.txtRangeFrom)
        Me.Name = "frmIDLoader"
        Me.Text = "ID Card Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRangeFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtRangeTo As System.Windows.Forms.TextBox
    Friend WithEvents lblIDRange As System.Windows.Forms.Label
    Friend WithEvents btnProcessReport As System.Windows.Forms.Button
    Friend WithEvents idviewer As CrystalDecisions.Windows.Forms.CrystalReportViewer

End Class
