<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fcetak_bukti
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
        Me.CRbukti = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRbukti
        '
        Me.CRbukti.ActiveViewIndex = -1
        Me.CRbukti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRbukti.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRbukti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRbukti.Location = New System.Drawing.Point(0, 0)
        Me.CRbukti.Name = "CRbukti"
        Me.CRbukti.Size = New System.Drawing.Size(475, 377)
        Me.CRbukti.TabIndex = 0
        '
        'Fcetak_bukti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 377)
        Me.Controls.Add(Me.CRbukti)
        Me.Name = "Fcetak_bukti"
        Me.Text = "Cetak Bukti Berobat"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRbukti As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
