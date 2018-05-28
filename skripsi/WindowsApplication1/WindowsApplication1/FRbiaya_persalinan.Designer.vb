<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRbiaya_persalinan
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
        Me.CRbiaya = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRbiaya
        '
        Me.CRbiaya.ActiveViewIndex = -1
        Me.CRbiaya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRbiaya.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRbiaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRbiaya.Location = New System.Drawing.Point(0, 0)
        Me.CRbiaya.Name = "CRbiaya"
        Me.CRbiaya.Size = New System.Drawing.Size(660, 441)
        Me.CRbiaya.TabIndex = 0
        '
        'FRbiaya_persalinan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 441)
        Me.Controls.Add(Me.CRbiaya)
        Me.Name = "FRbiaya_persalinan"
        Me.Text = "Biaya Persalinan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRbiaya As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
