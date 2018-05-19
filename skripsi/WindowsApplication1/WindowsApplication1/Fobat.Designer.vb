<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fkelola_obat
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGobat = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Tstok = New System.Windows.Forms.TextBox()
        Me.Thrg_obat = New System.Windows.Forms.TextBox()
        Me.Cjns_obat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Bexit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Tnm_obat = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGobat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tnm_obat)
        Me.GroupBox1.Controls.Add(Me.DGobat)
        Me.GroupBox1.Controls.Add(Me.Tcari)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Tstok)
        Me.GroupBox1.Controls.Add(Me.Thrg_obat)
        Me.GroupBox1.Controls.Add(Me.Cjns_obat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(440, 409)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ENTRI DATA OBAT"
        '
        'DGobat
        '
        Me.DGobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGobat.Location = New System.Drawing.Point(10, 214)
        Me.DGobat.Name = "DGobat"
        Me.DGobat.Size = New System.Drawing.Size(425, 150)
        Me.DGobat.TabIndex = 12
        '
        'Tcari
        '
        Me.Tcari.Location = New System.Drawing.Point(125, 176)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(227, 22)
        Me.Tcari.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "pencarian obat"
        '
        'Tstok
        '
        Me.Tstok.Location = New System.Drawing.Point(125, 129)
        Me.Tstok.Name = "Tstok"
        Me.Tstok.Size = New System.Drawing.Size(64, 22)
        Me.Tstok.TabIndex = 9
        '
        'Thrg_obat
        '
        Me.Thrg_obat.Location = New System.Drawing.Point(125, 92)
        Me.Thrg_obat.Name = "Thrg_obat"
        Me.Thrg_obat.Size = New System.Drawing.Size(111, 22)
        Me.Thrg_obat.TabIndex = 8
        '
        'Cjns_obat
        '
        Me.Cjns_obat.FormattingEnabled = True
        Me.Cjns_obat.Location = New System.Drawing.Point(125, 55)
        Me.Cjns_obat.Name = "Cjns_obat"
        Me.Cjns_obat.Size = New System.Drawing.Size(121, 22)
        Me.Cjns_obat.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "stock obat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "harga obat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "jenis obat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "nama obat"
        '
        'Bsave
        '
        Me.Bsave.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bsave.Location = New System.Drawing.Point(12, 13)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(75, 23)
        Me.Bsave.TabIndex = 1
        Me.Bsave.Text = "SAVE"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Bexit
        '
        Me.Bexit.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bexit.Location = New System.Drawing.Point(12, 41)
        Me.Bexit.Name = "Bexit"
        Me.Bexit.Size = New System.Drawing.Size(75, 23)
        Me.Bexit.TabIndex = 2
        Me.Bexit.Text = "EXIT"
        Me.Bexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Bexit)
        Me.GroupBox2.Controls.Add(Me.Bsave)
        Me.GroupBox2.Font = New System.Drawing.Font("Bookman Old Style", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(458, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(97, 70)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PROSES"
        '
        'Tnm_obat
        '
        Me.Tnm_obat.Location = New System.Drawing.Point(125, 24)
        Me.Tnm_obat.Name = "Tnm_obat"
        Me.Tnm_obat.Size = New System.Drawing.Size(227, 22)
        Me.Tnm_obat.TabIndex = 13
        '
        'Fkelola_obat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 427)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Fkelola_obat"
        Me.Text = "Kelola Obat"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGobat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGobat As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tstok As System.Windows.Forms.TextBox
    Friend WithEvents Thrg_obat As System.Windows.Forms.TextBox
    Friend WithEvents Cjns_obat As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents Bexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tnm_obat As System.Windows.Forms.TextBox
End Class
