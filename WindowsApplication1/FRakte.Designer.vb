<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRakte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRakte))
        Me.CRakte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRakte
        '
        Me.CRakte.ActiveViewIndex = -1
        Me.CRakte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRakte.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRakte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRakte.Location = New System.Drawing.Point(0, 0)
        Me.CRakte.Name = "CRakte"
        Me.CRakte.Size = New System.Drawing.Size(699, 436)
        Me.CRakte.TabIndex = 0
        '
        'FRakte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 436)
        Me.Controls.Add(Me.CRakte)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRakte"
        Me.Text = "Akte Kelahiran"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRakte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
