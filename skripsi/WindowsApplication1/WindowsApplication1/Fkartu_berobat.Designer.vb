<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fkartu_berobat
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
        Me.CRpasien = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRpasien
        '
        Me.CRpasien.ActiveViewIndex = -1
        Me.CRpasien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRpasien.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRpasien.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRpasien.Location = New System.Drawing.Point(0, 0)
        Me.CRpasien.Name = "CRpasien"
        Me.CRpasien.Size = New System.Drawing.Size(960, 386)
        Me.CRpasien.TabIndex = 0
        '
        'Fkartu_berobat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 386)
        Me.Controls.Add(Me.CRpasien)
        Me.Name = "Fkartu_berobat"
        Me.Text = "Fkartu_berobat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRpasien As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
