<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fdaftar_kelahiran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fdaftar_kelahiran))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Bakte = New System.Windows.Forms.Button()
        Me.Bbiaya = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGkelahiran = New System.Windows.Forms.DataGridView()
        Me.Tcari = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGkelahiran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox2.Controls.Add(Me.Bakte)
        Me.GroupBox2.Controls.Add(Me.Bbiaya)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 241)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 95)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PROSES"
        '
        'Bakte
        '
        Me.Bakte.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bakte.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bakte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bakte.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bakte.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bakte.Location = New System.Drawing.Point(34, 22)
        Me.Bakte.Name = "Bakte"
        Me.Bakte.Size = New System.Drawing.Size(261, 50)
        Me.Bakte.TabIndex = 5
        Me.Bakte.Text = "CETAK AKTE KELAHIRAN"
        Me.Bakte.UseVisualStyleBackColor = False
        '
        'Bbiaya
        '
        Me.Bbiaya.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bbiaya.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Bbiaya.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bbiaya.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bbiaya.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Bbiaya.Location = New System.Drawing.Point(386, 22)
        Me.Bbiaya.Name = "Bbiaya"
        Me.Bbiaya.Size = New System.Drawing.Size(263, 52)
        Me.Bbiaya.TabIndex = 2
        Me.Bbiaya.Text = "CETAK BUKTI BIAYA PERSALINAN"
        Me.Bbiaya.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MintCream
        Me.GroupBox1.Controls.Add(Me.DGkelahiran)
        Me.GroupBox1.Controls.Add(Me.Tcari)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 226)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DAFTAR KELAHIRAN"
        '
        'DGkelahiran
        '
        Me.DGkelahiran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGkelahiran.Location = New System.Drawing.Point(6, 64)
        Me.DGkelahiran.Name = "DGkelahiran"
        Me.DGkelahiran.Size = New System.Drawing.Size(680, 150)
        Me.DGkelahiran.TabIndex = 12
        '
        'Tcari
        '
        Me.Tcari.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tcari.Location = New System.Drawing.Point(168, 27)
        Me.Tcari.Name = "Tcari"
        Me.Tcari.Size = New System.Drawing.Size(518, 23)
        Me.Tcari.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pencarian Riwayat Kelahiran"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(629, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "KELUAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Fdaftar_kelahiran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(715, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fdaftar_kelahiran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Kelahiran"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGkelahiran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Bakte As System.Windows.Forms.Button
    Friend WithEvents Bbiaya As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGkelahiran As System.Windows.Forms.DataGridView
    Friend WithEvents Tcari As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
