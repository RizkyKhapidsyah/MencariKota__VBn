<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.listKota = New System.Windows.Forms.ListBox()
        Me.teksKota = New System.Windows.Forms.TextBox()
        Me.tombolCari = New System.Windows.Forms.Button()
        Me.labelHasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'listKota
        '
        Me.listKota.FormattingEnabled = True
        Me.listKota.Items.AddRange(New Object() {"Pematang Siantar", "Medan", "Balige", "Padang", "Bukit Tinggi", "Pekan Baru", "Palembang", "Lampung", "Jakarta", "Bandung", "Jogja", "Semarang", "Solo", "Surabaya"})
        Me.listKota.Location = New System.Drawing.Point(13, 13)
        Me.listKota.Name = "listKota"
        Me.listKota.Size = New System.Drawing.Size(126, 160)
        Me.listKota.TabIndex = 0
        '
        'teksKota
        '
        Me.teksKota.Location = New System.Drawing.Point(163, 13)
        Me.teksKota.Name = "teksKota"
        Me.teksKota.Size = New System.Drawing.Size(129, 20)
        Me.teksKota.TabIndex = 1
        '
        'tombolCari
        '
        Me.tombolCari.Location = New System.Drawing.Point(163, 39)
        Me.tombolCari.Name = "tombolCari"
        Me.tombolCari.Size = New System.Drawing.Size(129, 23)
        Me.tombolCari.TabIndex = 2
        Me.tombolCari.Text = "Cari Kota"
        Me.tombolCari.UseVisualStyleBackColor = True
        '
        'labelHasil
        '
        Me.labelHasil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelHasil.Location = New System.Drawing.Point(163, 112)
        Me.labelHasil.Name = "labelHasil"
        Me.labelHasil.Size = New System.Drawing.Size(129, 23)
        Me.labelHasil.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 178)
        Me.Controls.Add(Me.labelHasil)
        Me.Controls.Add(Me.tombolCari)
        Me.Controls.Add(Me.teksKota)
        Me.Controls.Add(Me.listKota)
        Me.Name = "Form1"
        Me.Text = "Mencari Kota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listKota As System.Windows.Forms.ListBox
    Friend WithEvents teksKota As System.Windows.Forms.TextBox
    Friend WithEvents tombolCari As System.Windows.Forms.Button
    Friend WithEvents labelHasil As System.Windows.Forms.Label

End Class
