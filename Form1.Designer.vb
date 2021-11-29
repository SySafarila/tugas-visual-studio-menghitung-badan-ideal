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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBeratBadan = New System.Windows.Forms.TextBox()
        Me.TextTinggiBadan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCek = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Berat Badan (Kg)"
        '
        'TextBeratBadan
        '
        Me.TextBeratBadan.Location = New System.Drawing.Point(16, 30)
        Me.TextBeratBadan.Name = "TextBeratBadan"
        Me.TextBeratBadan.Size = New System.Drawing.Size(100, 20)
        Me.TextBeratBadan.TabIndex = 1
        '
        'TextTinggiBadan
        '
        Me.TextTinggiBadan.Location = New System.Drawing.Point(16, 77)
        Me.TextTinggiBadan.Name = "TextTinggiBadan"
        Me.TextTinggiBadan.Size = New System.Drawing.Size(100, 20)
        Me.TextTinggiBadan.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tinggi Badan (Cm)"
        '
        'BtnCek
        '
        Me.BtnCek.Location = New System.Drawing.Point(16, 104)
        Me.BtnCek.Name = "BtnCek"
        Me.BtnCek.Size = New System.Drawing.Size(100, 23)
        Me.BtnCek.TabIndex = 4
        Me.BtnCek.Text = "Cek"
        Me.BtnCek.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCek)
        Me.Controls.Add(Me.TextTinggiBadan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBeratBadan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBeratBadan As TextBox
    Friend WithEvents TextTinggiBadan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCek As Button
End Class
