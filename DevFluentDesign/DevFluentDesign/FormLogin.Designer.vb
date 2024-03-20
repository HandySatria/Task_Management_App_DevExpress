<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LabelHeader2 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TextEditNama = New DevExpress.XtraEditors.TextEdit()
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(198, 229)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 21)
        Me.CheckBox1.TabIndex = 44
        Me.CheckBox1.Text = "Tampilkan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LabelHeader2
        '
        Me.LabelHeader2.AutoSize = True
        Me.LabelHeader2.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeader2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelHeader2.Location = New System.Drawing.Point(192, 35)
        Me.LabelHeader2.Name = "LabelHeader2"
        Me.LabelHeader2.Size = New System.Drawing.Size(239, 36)
        Me.LabelHeader2.TabIndex = 43
        Me.LabelHeader2.Text = "LOGIN APLIKASI"
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Yellow
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.Location = New System.Drawing.Point(201, 300)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(99, 44)
        Me.ButtonCancel.TabIndex = 40
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonLogin.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonLogin.Location = New System.Drawing.Point(332, 300)
        Me.ButtonLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(99, 44)
        Me.ButtonLogin.TabIndex = 39
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(91, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 33)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Password :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(92, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 33)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Username :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextEditPassword
        '
        Me.TextEditPassword.Location = New System.Drawing.Point(198, 193)
        Me.TextEditPassword.Name = "TextEditPassword"
        Me.TextEditPassword.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditPassword.Properties.Appearance.Options.UseFont = True
        Me.TextEditPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TextEditPassword.Properties.NullText = "Password"
        Me.TextEditPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextEditPassword.Size = New System.Drawing.Size(257, 28)
        Me.TextEditPassword.TabIndex = 38
        '
        'TextEditNama
        '
        Me.TextEditNama.Location = New System.Drawing.Point(201, 132)
        Me.TextEditNama.Name = "TextEditNama"
        Me.TextEditNama.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEditNama.Properties.Appearance.Options.UseFont = True
        Me.TextEditNama.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.TextEditNama.Properties.NullText = "Username"
        Me.TextEditNama.Size = New System.Drawing.Size(254, 28)
        Me.TextEditNama.TabIndex = 37
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(613, 424)
        Me.Controls.Add(Me.TextEditPassword)
        Me.Controls.Add(Me.TextEditNama)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LabelHeader2)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.TextEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEditNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LabelHeader2 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
