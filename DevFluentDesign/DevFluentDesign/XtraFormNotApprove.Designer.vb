﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraFormNotApprove
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelCatatan = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCatatan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabelId
        '
        Me.LabelId.AutoSize = True
        Me.LabelId.Location = New System.Drawing.Point(12, 260)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(18, 17)
        Me.LabelId.TabIndex = 81
        Me.LabelId.Text = "id"
        Me.LabelId.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(315, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 45)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(449, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 45)
        Me.Button1.TabIndex = 76
        Me.Button1.Text = "SIMPAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LabelCatatan
        '
        Me.LabelCatatan.AutoSize = True
        Me.LabelCatatan.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCatatan.ForeColor = System.Drawing.Color.Black
        Me.LabelCatatan.Location = New System.Drawing.Point(26, 79)
        Me.LabelCatatan.Name = "LabelCatatan"
        Me.LabelCatatan.Size = New System.Drawing.Size(181, 21)
        Me.LabelCatatan.TabIndex = 77
        Me.LabelCatatan.Text = "ALASAN TIDAK APPROVE"
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.Black
        Me.LabelTitle.Location = New System.Drawing.Point(24, 22)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(152, 35)
        Me.LabelTitle.TabIndex = 79
        Me.LabelTitle.Text = "DATA REVISI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(230, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 21)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = ":"
        '
        'TextBoxCatatan
        '
        Me.TextBoxCatatan.Location = New System.Drawing.Point(258, 79)
        Me.TextBoxCatatan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxCatatan.Multiline = True
        Me.TextBoxCatatan.Name = "TextBoxCatatan"
        Me.TextBoxCatatan.Size = New System.Drawing.Size(308, 129)
        Me.TextBoxCatatan.TabIndex = 75
        '
        'XtraFormNotApprove
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 319)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelCatatan)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxCatatan)
        Me.Name = "XtraFormNotApprove"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraFormNotApprove"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelId As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelCatatan As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCatatan As TextBox
End Class
